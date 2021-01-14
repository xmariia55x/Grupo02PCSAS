using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace Grupo02PCSAS
{
    public partial class fInfoCursoProfesor : Form
    {
        Usuario user;
        Curso curso;
        String enlace;
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        public fInfoCursoProfesor(Usuario user, Curso curso)
        {
            this.user = user;
            this.curso = curso;
            InitializeComponent();
        }


        private void calcularPlazasDisponibles()
        {
            List<Usuario> lista = CursosRealizados.listaUsuarios(curso.CursoID);
            lPlazasDisp.Text = (curso.CursoAforo - lista.Count).ToString();
        }

        private void comprobarInscrito()
        {
            bool inscrito = false;
            foreach (Usuario u in ActividadesRealizadas.listaUsuarios(curso.CursoID))
            //foreach (Usuario u in CursosRealizados.listaUsuarios(curso.CursoID))
            {
                if (user.Equals(u)) inscrito = true;
            }

            if (inscrito)
            {
                lInscrito.Text = "Inscrito";
            }
            else
            {
                lInscrito.Text = "No inscrito";
            }
        }

        private void mostrarUsuario()
        {
            lNombreUser.Text = user.NombreUsuario;
            lRol.Text = user.RolUsuario.RolName;
        }

        private void mostrarActividad()
        {
            lNombreCurso.Text = curso.CursoNombre;
            lDescripcion.Text = curso.CursoDescripcion;
            lNombreProf.Text = curso.CursoProfesor.NombreUsuario;
            lPlazasTotales.Text = curso.CursoAforo.ToString();
            lFechaInicio.Text = curso.CursoFechaInicio;
            lFechaFin.Text = curso.CursoFechaFin;
            lHoraInicio.Text = curso.CursoHoraInicio;
            label21.Text = curso.CursoHoraFin;
            lLugar.Text = curso.CursoLugar;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (user.RolUsuario.RolName.Equals("ALUMNO"))
            {
                fPantallaPrincipalAlumno inicio = new fPantallaPrincipalAlumno(user);
                this.Hide();
                inicio.ShowDialog();
                this.Close();
            }
            else if (user.RolUsuario.RolName.Equals("PROFESOR"))
            {
                fPrincipalProfesor inicio = new fPrincipalProfesor(user);
                this.Hide();
                inicio.ShowDialog();
                this.Close();
            }
            else if (user.RolUsuario.RolName.Equals("ENTIDAD"))
            {
                fPrincipalOng inicio = new fPrincipalOng(user);
                this.Hide();
                inicio.ShowDialog();
                this.Close();
            }
            else if (user.RolUsuario.RolName.Equals("ADMIN"))
            {
                fPantallaAdminFinal inicio = new fPantallaAdminFinal(user);
                this.Hide();
                inicio.ShowDialog();
                this.Close();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fInfoCursoProfesor_Load(object sender, EventArgs e)
        {
            mostrarUsuario();
            mostrarActividad();
            comprobarInscrito();
            calcularPlazasDisponibles();
            string[] fechaSplit = curso.CursoFechaInicio.Split('/');
            string[] horaSplit = curso.CursoHoraInicio.Split(':');
            DateTime fecha = new DateTime(int.Parse(fechaSplit[2]), int.Parse(fechaSplit[1]), int.Parse(fechaSplit[0]), int.Parse(horaSplit[0]), int.Parse(horaSplit[1]), 0);
            if (fecha.CompareTo(DateTime.Now) >= 0)
            {

                bRecordar.Visible = true;
                label3.Visible = true;
            }
            else
            {
                bRecordar.Visible = false;
                label3.Visible = false;
            }


            cargaGrid();
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
                        Process.Start(new MaterialCurso(curso.CursoID, nombre).Enlace);
                    }
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bRecordar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Se enviará un correo a todos los usuarios inscritos", "ALERTA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string recordatorio;
                foreach (Usuario u in CursosRealizados.listaUsuarios(curso.CursoID))
                {
                    //Console.WriteLine(u.CorreoUsuario);
                    recordatorio = Correo.recordatorioCurso(curso);
                    Correo.sendEmail(recordatorio, "Curso próximo", u);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else

            }
        }

        private void cargaGrid()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            //nombreCurso 'Nombre', fechaInicioCurso, fechaFinCurso, aforoCurso
            MySqlCommand comandoC = new MySqlCommand("SELECT nombre as `Nombre del recurso` FROM MaterialCurso WHERE idCurso = " + curso.CursoID, conexion);
            MySqlDataAdapter adaptadorC = new MySqlDataAdapter();
            adaptadorC.SelectCommand = comandoC;
            DataTable tablaC = new DataTable();
            adaptadorC.Fill(tablaC);
            dgvDescargas.DataSource = tablaC;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAnyadirPrueba_Click(object sender, EventArgs e)
        {
            if (PruebaConocimiento.hayPruebaConocimiento(curso))
            {
                MessageBox.Show("Ya hay una prueba asociada al curso");
            } else
            {
                fCrearPruebaConocimiento f = new fCrearPruebaConocimiento(user, curso);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }

        private void bEditarPrueba_Click(object sender, EventArgs e)
        {
            if (PruebaConocimiento.hayPruebaConocimiento(curso))
            {
                fEditarPruebaConocimiento f = new fEditarPruebaConocimiento(user, curso, new PruebaConocimiento(curso.CursoID));
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No existe ninguna prueba asociada al curso");
            }
        }

        private void bEliminarPrueba_Click(object sender, EventArgs e)
        {
            try
            {
                if (PruebaConocimiento.hayPruebaConocimiento(curso))
                {
                    DialogResult dialogResult = MessageBox.Show("¿Desea borrar la prueba de conocimiento?", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        PruebaConocimiento p = new PruebaConocimiento(curso.CursoID);
                        p.BorrarPrueba();
                        MessageBox.Show("Prueba de conocimiento eliminada con exito");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else

                    }
                }
                else
                {
                    throw new Exception("No existe ninguna prueba asociada al curso");
                }
            } catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bValoraciones_Click(object sender, EventArgs e)
        {
            fVerValoraciones ver = new fVerValoraciones(user, curso);
            this.Hide();
            ver.ShowDialog();
            this.Close();
           
        }
    }
}
