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
    public partial class fPrincipalOng : Form
    {
        Usuario ong;
        Actividad seleccionado;
        public fPrincipalOng(Usuario u)
        {
            InitializeComponent();
            ong = u;
        }

        private void bAccederAlForo_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForo foro = new PantallaPrincipalForo(ong);
            this.Visible = false;
            foro.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(ong); 
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = true;
        }

        private void fPrincipalOng_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Actividad' Puede moverla o quitarla según sea necesario.
            //this.actividadTableAdapter.Fill(this.apsgrupo02DataSet.Actividad);
            lRol.Text = ong.RolUsuario.RolName;
            lNombreUser.Text = ong.NombreUsuario;

            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Actividad WHERE creadorActividad = '" + ong.CorreoUsuario + "'", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void bEventos_Click(object sender, EventArgs e)
        {
            fPantallaPrincipalAlumno principal = new fPantallaPrincipalAlumno(ong); 
            this.Visible = false;
            principal.ShowDialog();
            this.Visible = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                seleccionado = new Actividad((int)dataGridView1.SelectedRows[0].Cells[0].Value);
                
            }
        }

        private void bInformacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado != null)
                {
                    fInfoActividad info = new fInfoActividad(ong, seleccionado);
                    this.Visible = false;
                    info.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    throw new Exception("No hay ninguna actividad seleccionada");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            
        }

        private void bCrearActividad_Click(object sender, EventArgs e)
        {
            fCrearActividadAdmin a = new fCrearActividadAdmin(ong);
            this.Visible = false;
            a.ShowDialog();
            this.Visible = true;
        }

        private void bNoticias_Click(object sender, EventArgs e)
        {
            fNoticia noticias = new fNoticia(ong);
            this.Visible = false;
            noticias.ShowDialog();
            this.Visible = true;
        }
    }
}
