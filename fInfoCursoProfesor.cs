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

            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "SELECT enlace FROM MaterialCurso WHERE idCurso = " + curso.CursoID + ";";
            object[] tupla = miBD.Select(sentencia)[0];

            enlace = (string)tupla[0];
            if (enlace == null || enlace.Equals("")) pictureBox5.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start(enlace);
            if(curso.CursoFechaInicio.CompareTo(DateTime.Now.ToString("dd/MM/yyyy")) < 0)
            {
                bRecordar.Enabled = true;
            } else
            {
                bRecordar.Enabled = false;
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
                    Console.WriteLine(u.CorreoUsuario);
                    recordatorio = Correo.recordatorioCurso(curso);
                    Correo.sendEmail(recordatorio, "Eventos próximos", u);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else

            }
        }
    }
}
