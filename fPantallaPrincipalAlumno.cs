using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Grupo02PCSAS
{
    public partial class fPantallaPrincipalAlumno : Form
    {
        private Usuario alumno;
        public fPantallaPrincipalAlumno(Usuario u)
        {
            InitializeComponent();
            alumno = u;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fPantallaPrincipalAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Curso' Puede moverla o quitarla según sea necesario.

            lRol.Text = alumno.RolUsuario.RolName;
            lNombreApellidos.Text = alumno.NombreUsuario;

            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            MySqlCommand comandoC = new MySqlCommand("SELECT* FROM Curso WHERE fechaInicioCurso >= '" + DateTime.Now.ToString("dd / MM / yyyy") + "'", conexion);
            MySqlCommand comandoA = new MySqlCommand("SELECT* FROM Actividad WHERE fechaInicioActividad >= '" + DateTime.Now.ToString("dd / MM / yyyy") + "'", conexion);
            MySqlCommand comandoMC = new MySqlCommand("select c.nombreCurso from CursosRealizados cr join Curso c on cr.idCurso = c.idCurso where cr.correo = '" + alumno.CorreoUsuario + "'", conexion);
            MySqlDataAdapter adaptadorC = new MySqlDataAdapter();
            MySqlDataAdapter adaptadorA = new MySqlDataAdapter();
            MySqlDataAdapter adaptadorMC = new MySqlDataAdapter();
            adaptadorC.SelectCommand = comandoC;
            adaptadorA.SelectCommand = comandoA;
            adaptadorMC.SelectCommand = comandoMC;
            DataTable tablaC = new DataTable();
            DataTable tablaA = new DataTable();
            DataTable tablaMC = new DataTable();
            adaptadorC.Fill(tablaC);
            adaptadorA.Fill(tablaA);
            adaptadorMC.Fill(tablaMC);
            dgvNuevosCursos.DataSource = tablaC;
            dgvNuevasActividades.DataSource = tablaA;
            dgvMisCursos.DataSource = tablaMC;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lMiPerfil_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(alumno); 
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForo foro = new PantallaPrincipalForo(null);
            this.Visible = false;
            foro.ShowDialog();
            this.Visible = true;
        }
    }
}
