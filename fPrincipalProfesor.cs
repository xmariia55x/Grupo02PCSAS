using MySql.Data.MySqlClient;
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
    public partial class fPrincipalProfesor : Form
    {
        Usuario profesor;
        public fPrincipalProfesor(Usuario u)
        {
            InitializeComponent();
            profesor = u;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bAccederAlForo_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForo foro = new PantallaPrincipalForo();
            this.Visible = false;
            foro.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(profesor); 
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = true;
        }

        private void fPrincipalProfesor_Load(object sender, EventArgs e)
        {
            lRol.Text = profesor.RolUsuario.RolName;
            lNombre.Text = profesor.NombreUsuario;

            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Curso WHERE profesorCurso = '" + profesor.CorreoUsuario + "'", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            fCrearCursoAdmin crearCurso = new fCrearCursoAdmin(profesor);
            this.Visible = false;
            crearCurso.ShowDialog();
            this.Visible = true;
        }
    }
}
