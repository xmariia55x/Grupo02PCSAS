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
    public partial class fRespuestaPrueba : Form
    {
        Usuario user;
        Curso curso;
        PruebaConocimiento prueba;

        public fRespuestaPrueba(Usuario user, Curso curso, PruebaConocimiento prueba)
        {
            this.user = user;
            this.curso = curso;
            this.prueba = prueba;
            InitializeComponent();
        }

        private void cargaGrid()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM RespuestaPrueba WHERE idPrueba = " + this.prueba.IdCursoPrueba, conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            //Columnas no visibles
            dataGridView1.Columns[1].Visible = false;


            //Columnas visibles
            dataGridView1.Columns[0].HeaderText = "Usuario";
            dataGridView1.Columns[2].HeaderText = "Respuesta pregunta 1";
            dataGridView1.Columns[3].HeaderText = "Respuesta pregunta 2";
            dataGridView1.Columns[4].HeaderText = "Respuesta pregunta 3";
            dataGridView1.Columns[5].HeaderText = "Respuesta pregunta 4";
            dataGridView1.Columns[6].HeaderText = "Respuesta pregunta 5";


            dataGridView1.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;

            /*dataGridView1.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            */
            dataGridView1.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        private void fRespuestaPrueba_Load(object sender, EventArgs e)
        {
            lNombreUser.Text = user.NombreUsuario;
            lRol.Text = user.RolUsuario.RolName;
            lNombreCurso.Text = curso.CursoNombre;
            cargaGrid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(user);
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(user);
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fInfoCursoProfesor infoCursoProfesor = new fInfoCursoProfesor(user,curso);
            this.Hide();
            infoCursoProfesor.ShowDialog();
            this.Close();
        }
    }
}
