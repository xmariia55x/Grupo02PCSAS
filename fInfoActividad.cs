using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (user == null)
            {
                pictureBox2.Visible = false;
                label5.Visible = false;
                label9.Visible = false;
                lInscrito.Visible = false;
                bValorar.Visible = false;
                lValorar.Visible = false;
                bValoraciones.Visible = false;
            } else if(!act.UsuarioCreador.Equals(user.CorreoUsuario))
            {
                bValoraciones.Visible = false;
            }
            mostrarUsuario();
            mostrarActividad();
            
            if(ActividadesRealizadas.comprobarInscrito(user, act))
            {
                lInscrito.Text = "Inscrito";
                string[] fechaSplit = act.FechaFinActividad.Split('/');
                string[] horaSplit = act.HoraFinActividad.Split(':');
                DateTime fecha = new DateTime(int.Parse(fechaSplit[2]), int.Parse(fechaSplit[1]), int.Parse(fechaSplit[0]), int.Parse(horaSplit[0]), int.Parse(horaSplit[1]), 0);
                if (DateTime.Now.CompareTo(fecha) <= 0)
                {
                    lValorar.Visible = false;
                    bValorar.Visible = false;
                }/* else
                {
                    lValorar.Visible = true;
                    bValorar.Visible = true;
                }*/
            } else
            {
                lInscrito.Text = "No inscrito";
                bValorar.Visible = false;
                lValorar.Visible = false;
            }
            

            calcularPlazasDisponibles();
            if(user != null && (user.RolUsuario.RolName.Equals("PROFESOR") || user.RolUsuario.RolName.Equals("ENTIDAD")))
            {
                string[] fechaSplit = act.FechaInicioActividad.Split('/');
                string[] horaSplit = act.HoraInicioActividad.Split(':');
                DateTime fecha = new DateTime(int.Parse(fechaSplit[2]), int.Parse(fechaSplit[1]), int.Parse(fechaSplit[0]), int.Parse(horaSplit[0]), int.Parse(horaSplit[1]), 0);
                
                if (fecha.CompareTo(DateTime.Now) >= 0)
                {

                    bRecordar.Enabled = true;
                }
                else
                {
                    bRecordar.Enabled = false;
                    
                }
            } else
            {
                bRecordar.Hide();
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
            fDatosPerfil edicion = new fDatosPerfil(this.user);
            this.Visible = false;
            edicion.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (user.RolUsuario.RolName.Equals("ALUMNO"))
            {
                fPantallaPrincipalAlumno inicio = new fPantallaPrincipalAlumno(user);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
            else if (user.RolUsuario.RolName.Equals("PROFESOR"))
            {
                fPrincipalProfesor inicio = new fPrincipalProfesor(user);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
            else if (user.RolUsuario.RolName.Equals("ENTIDAD"))
            {
                fPrincipalOng inicio = new fPrincipalOng(user);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
            else if (user.RolUsuario.RolName.Equals("ADMIN"))
            {
                fPantallaAdminFinal inicio = new fPantallaAdminFinal(user);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
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
                        this.Visible = false;
                        satisfaccionActividad.ShowDialog();
                        this.Visible = true;
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
    }
}
