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
    
    public partial class fBorrarArchivoCurso : Form
    {
        private Curso curso;
        private Usuario user;
        private MaterialCurso archivoSeleccionado;
        public fBorrarArchivoCurso(Usuario u, Curso c)
        {
            InitializeComponent();
            this.user = u;
            this.curso = c;
        }

        private void fBorrarArchivoCurso_Load(object sender, EventArgs e)
        {

            lNombreUser.Text = user.NombreUsuario;
            lRol.Text = user.RolUsuario.RolName;

            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select nombre as `Nombre archivo` from MaterialCurso where idCurso= " + curso.CursoID + ";", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            dataGridView1.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nombre= (string)dataGridView1.SelectedRows[0].Cells[0].Value;
                archivoSeleccionado = new MaterialCurso(curso.CursoID, nombre);

            }
            else
            {
                archivoSeleccionado = null;
            }
        }

        private void bEliminarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea borrar el archivo?", "ALERTA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if(archivoSeleccionado != null)
                    {
                        this.archivoSeleccionado.BorrarMaterialCurso();
                        MessageBox.Show("Archivo borrado con exito");
                        fModificarCursos f = new fModificarCursos(user, curso);
                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                    } else
                    {
                        throw new Exception("No se ha seleccionado ningún archivo");
                    }
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(user);
            this.Hide();
            datosPerfil.ShowDialog();
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(user);
            this.Hide();
            datosPerfil.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fModificarCursos f = new fModificarCursos(user, curso);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
