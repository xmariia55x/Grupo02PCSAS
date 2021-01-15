using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo02PCSAS
{
    public partial class fInfoActividad : Form
    {
        Usuario user;
        Actividad act;

        public fInfoActividad(Usuario user, Actividad act)
        {
            InitializeComponent();
            this.user = user;
            this.act = act;
        }

        private void fInfoActividad_Load(object sender, EventArgs e)
        {
            dgvDescargas.Visible = false;
            if (user == null)
            {
                lRol.Text = "INVITADO";
                lNombreUser.Text = "INVITADO";
                pictureBox2.Visible = false;
                label5.Visible = false;
                label9.Visible = false;
                lInscrito.Visible = false;
                bValorar.Visible = false;
                lValorar.Visible = false;
                lRecordar.Visible = false;
                bRecordar.Visible = false;
                bValoraciones.Visible = false;
                lInvitado.Visible = true;
                lDescargasInscritos.Visible = false;
            }
            else
            {
                string[] fechaSplit = act.FechaFinActividad.Split('/');
                string[] horaSplit = act.HoraFinActividad.Split(':');
                DateTime fecha = new DateTime(int.Parse(fechaSplit[2]), int.Parse(fechaSplit[1]), int.Parse(fechaSplit[0]), int.Parse(horaSplit[0]), int.Parse(horaSplit[1]), 0);
                lInvitado.Visible = false;
                cargaGrid();

                if (!act.UsuarioCreador.CorreoUsuario.Equals(user.CorreoUsuario))
                {
                    bRecordar.Visible = false;
                    lRecordar.Visible = false;
                    bValoraciones.Visible = false;

                    if (ActividadesRealizadas.comprobarInscrito(user, act))
                    {
                        lInscrito.Text = "Inscrito";
                        dgvDescargas.Visible = true;
                        lDescargasInscritos.Visible = false;

                        if (DateTime.Now.CompareTo(fecha) <= 0)
                        {
                            lValorar.Visible = false;
                            bValorar.Visible = false;
                        }
                        else
                        {
                            bValorar.Visible = true;
                            lValorar.Visible = true;
                        }
                    }
                    else
                    {
                        lValorar.Visible = false;
                        bValorar.Visible = false;
                        lInscrito.Text = "No inscrito";
                        lDescargasInscritos.Visible = true;
                    }
                }
                else
                {
                    string[] fechaSplitInicio = act.FechaInicioActividad.Split('/');
                    string[] horaSplitInicio = act.HoraInicioActividad.Split(':');
                    DateTime fechaInicio = new DateTime(int.Parse(fechaSplitInicio[2]), int.Parse(fechaSplitInicio[1]), int.Parse(fechaSplitInicio[0]), int.Parse(horaSplitInicio[0]), int.Parse(horaSplitInicio[1]), 0);

                    lValorar.Visible = false;
                    bValorar.Visible = false;

                    //Si es menor que la fecha de inicio
                    if (DateTime.Now.CompareTo(fechaInicio) <= 0)
                    {
                        bRecordar.Visible = true;
                        lRecordar.Visible = true;
                        bValoraciones.Visible = false;
                    }
                    //Si es menor que la fecha final
                    else if (DateTime.Now.CompareTo(fecha) <= 0)
                    {
                        bRecordar.Visible = false;
                        lRecordar.Visible = false;
                        bValoraciones.Visible = false;
                    }
                    //Si la actividad ha acabado
                    else
                    {
                        bRecordar.Visible = false;
                        lRecordar.Visible = false;
                        bValoraciones.Visible = true;
                    }
                    dgvDescargas.Visible = true;
                    lDescargasInscritos.Visible = false;
                    lInscrito.Text = "Creador";
                }


                mostrarUsuario();
            }
            mostrarActividad();
            calcularPlazasDisponibles();
        }

        private void cargaGrid()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            //nombreCurso 'Nombre', fechaInicioCurso, fechaFinCurso, aforoCurso
            MySqlCommand comandoA = new MySqlCommand("SELECT nombre as `Nombre del recurso` FROM MaterialActividad WHERE idActividad = " + act.IdActividad, conexion);
            MySqlDataAdapter adaptadorA = new MySqlDataAdapter();
            adaptadorA.SelectCommand = comandoA;
            DataTable tablaA = new DataTable();
            adaptadorA.Fill(tablaA);
            dgvDescargas.DataSource = tablaA;
            if (tablaA.Rows.Count == 0)
            {
                dgvDescargas.Visible = false;
            }
        }

        private void calcularPlazasDisponibles()
        {
            List<Usuario> lista = ActividadesRealizadas.listaUsuarios(act.IdActividad);
            List<Usuario> filtro = new List<Usuario>();
            foreach (Usuario u in lista)
                if (u.RolUsuario.RolName.Equals("ALUMNO") || u.RolUsuario.RolName.Equals("PROFESOR")) filtro.Add(u);
            lPlazasDisp.Text = (act.AforoActividad - filtro.Count).ToString();
        }

        private bool estaValorada()
        {
            bool res = false;

            foreach (Actividad a in ValoracionActividad.listaActividadesValoradas(user))
            {
                if (a.Equals(act))
                {
                    res = true;
                }
            }

            return res;
        }
        
        private void mostrarUsuario()
        {
            if (user == null)
            {
                lNombreUser.Text = "INVITADO";
                lRol.Text = "INVITADO";
            } 
            else
            {
                lNombreUser.Text = user.NombreUsuario;
                lRol.Text = user.RolUsuario.RolName;
            }
            
        }

        private void mostrarActividad()
        {
            lNombreAct.Text = act.NombreActividad;
            lDescripcion.Text = act.DescripcionActividad;
            lNombreProf.Text = act.UsuarioCreador.NombreUsuario;
            lPlazasTotales.Text = act.AforoActividad.ToString();
            lLugar.Text = act.LugarActividad;
            lFechaInicio.Text = act.FechaInicioActividad;
            lFechaFin.Text = act.FechaFinActividad;
            lHoraInicio.Text = act.HoraInicioActividad;
            lHoraFin.Text = act.HoraFinActividad;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if( user == null)
            {
                fInicioInvitado inv = new fInicioInvitado();
                this.Hide();
                inv.ShowDialog();
                this.Close();
            }
            else if (user.RolUsuario.RolName.Equals("ENTIDAD"))
            {
                fPrincipalOng ong = new fPrincipalOng(user);
                this.Hide();
                ong.ShowDialog();
                this.Close();
            }
            else if (user.RolUsuario.RolName.Equals("PROFESOR"))
            {
                fPrincipalProfesor profe = new fPrincipalProfesor(user);
                this.Hide();
                profe.ShowDialog();
                this.Close();
            }
            else if(user.RolUsuario.RolName.Equals("ALUMNO"))
            {
                fPantallaPrincipalAlumno alu = new fPantallaPrincipalAlumno(user);
                this.Hide();
                alu.ShowDialog();
                this.Close();
            }
            else
            {
                fPantallaAdminFinal admin = new fPantallaAdminFinal(user);
                this.Hide();
                admin.ShowDialog();
                this.Close();
            }
        }

        private void bRecordar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Se enviará un correo a todos los usuarios inscritos", "ALERTA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string recordatorio;
                foreach (Usuario u in ActividadesRealizadas.listaUsuarios(act.IdActividad))
                {
                    //Console.WriteLine(u.CorreoUsuario);
                    recordatorio = Correo.recordatorioActividad(act);
                    Correo.sendEmail(recordatorio, "Actividad próxima", u);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else

            }
        }

        private void bValorar_Click(object sender, EventArgs e)
        {
            try
            {
                    if(!estaValorada())
                    {
                        fSatisfaccionActividad satisfaccionActividad = new fSatisfaccionActividad(user,act);
                    this.Hide();
                        satisfaccionActividad.ShowDialog();
                    this.Close();
                    } else
                    {
                        throw new Exception("Ya ha valorado la actividad");
                    }
            } catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bValoraciones_Click(object sender, EventArgs e)
        {
            fVerValoraciones ver = new fVerValoraciones(user, act);
            this.Hide();
            ver.ShowDialog();
            this.Close();
        }

        private void dgvDescargas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDescargas.SelectedRows.Count > 0)
                {
                    String nombre = (String)dgvDescargas.SelectedRows[0].Cells[0].Value;
                    if (MessageBox.Show("¿Está seguro que quiere descargar el archivo?", "Descargar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process.Start(new MaterialActividad(nombre, act.IdActividad).Enlace);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
