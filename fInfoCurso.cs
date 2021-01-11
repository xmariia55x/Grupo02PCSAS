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
    public partial class fInfoCurso : Form
    {
        Usuario user;
        Curso curso;
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;


        public fInfoCurso(Usuario user, Curso curso)
        {
            this.user = user;
            this.curso = curso;
            InitializeComponent();
        }

        private void fInfoCurso_Load(object sender, EventArgs e)
        {
            
            if (user == null)
            {
                pictureBox2.Visible = false;
                label5.Visible = false;
                label9.Visible = false;
                lInscrito.Visible = false;
            } else
            {
                if (user.Equals(curso.CursoProfesor))
                {
                    label9.Visible = false;
                    lInscrito.Visible = false;
                }
                else
                    comprobarInscrito();
            }
            mostrarUsuario();
            mostrarCurso();
            calcularPlazasDisponibles();

            cargaGrid();


        }

        private void calcularPlazasDisponibles()
        {
            List<Usuario> lista = CursosRealizados.listaUsuarios(curso.CursoID);
            List<Usuario> filtro = new List<Usuario>();
            foreach(Usuario u in lista) 
                if (u.RolUsuario.RolName.Equals("ALUMNO") || u.RolUsuario.RolName.Equals("PROFESOR")) 
                    filtro.Add(u);
            lPlazasDisp.Text = (curso.CursoAforo - filtro.Count).ToString();
        }

        private void dgvDescargas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDescargas.SelectedRows.Count > 0)
                {
                    String nombre = (String)dgvDescargas.SelectedRows[0].Cells[0].Value;
                    if(MessageBox.Show("¿Está seguro que quiere descargar el archivo?", "Descargar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process.Start(new MaterialCurso(curso.CursoID,nombre).Enlace);
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
        private void comprobarInscrito()
        {
            bool inscrito = false;
            foreach (Usuario u in CursosRealizados.listaUsuarios(curso.CursoID))
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

        private void mostrarCurso()
        {
            lNombreCurso.Text = curso.CursoNombre;
            lDescripcion.Text = curso.CursoDescripcion;
            lNombreProf.Text = curso.CursoProfesor.NombreUsuario;
            lPlazasTotales.Text = curso.CursoAforo.ToString();
            lFechaInicio.Text = curso.CursoFechaInicio;
            lFechaFin.Text = curso.CursoFechaFin;
            lHoraInicio.Text = curso.CursoHoraInicio;
            lHoraF.Text = curso.CursoHoraFin;
            lLugar.Text = curso.CursoOnline ? "Online" : curso.CursoLugar;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void bParticipantes_Click(object sender, EventArgs e)
        {
            PantallaListaUsuarios usu = new PantallaListaUsuarios(curso, user);
            usu.Show();
            this.Close();
            //this.Visible = true;
        }

        

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }


        private void cargaGrid()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            //nombreCurso 'Nombre', fechaInicioCurso, fechaFinCurso, aforoCurso
            MySqlCommand comandoC = new MySqlCommand("SELECT nombre FROM MaterialCurso WHERE idCurso = " + curso.CursoID , conexion);
            MySqlDataAdapter adaptadorC = new MySqlDataAdapter();
            adaptadorC.SelectCommand = comandoC;
            DataTable tablaC = new DataTable();
            adaptadorC.Fill(tablaC);
            dgvDescargas.DataSource = tablaC;
        }

        
    }

}
