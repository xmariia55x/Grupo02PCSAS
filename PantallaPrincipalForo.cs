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
   
    public partial class PantallaPrincipalForo : Form
    {
        private Usuario user;
        private Debate debateSeleccionado;
        public PantallaPrincipalForo(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void PantallaBorrarCurso_Load(object sender, EventArgs e)
        {
            lNombreApellidos.Text = user.NombreUsuario;
            lRol.Text = user.RolUsuario.RolName;
            cargaGrid();
        }

        private void cargaGrid()
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet2.Debate' Puede moverla o quitarla según sea necesario.
            this.debateTableAdapter.Fill(this.apsgrupo02DataSet2.Debate);
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("Select asunto as `Asunto` from Debate where creador ='" + user.CorreoUsuario + "' ORDER BY fechaInicio DESC", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvMisDebates.DataSource = tabla;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bAniadirDebate_Click(object sender, EventArgs e)
        {
            fNuevoDebateForo nuevoDebate = new fNuevoDebateForo(user);
            this.Hide();
            nuevoDebate.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(user.RolUsuario.RolName.Equals("ALUMNO"))
            {
                fPantallaPrincipalAlumno principalAlumno = new fPantallaPrincipalAlumno(user);
                this.Hide();
                principalAlumno.ShowDialog();
                this.Close();
            } else if(user.RolUsuario.RolName.Equals("ADMIN"))
            {
                fPantallaAdminFinal pantallaAdmin = new fPantallaAdminFinal(user);
                this.Hide();
                pantallaAdmin.ShowDialog();
                this.Close();
            } else if(user.RolUsuario.RolName.Equals("ENTIDAD"))
            {
                fPrincipalOng pantallaOng = new fPrincipalOng(user);
                this.Hide();
                pantallaOng.ShowDialog();
                this.Close();
            } else
            {
                fPrincipalProfesor pantallaProfesor = new fPrincipalProfesor(user);
                this.Hide();
                pantallaProfesor.ShowDialog();
                this.Close();
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Hide();
            datos.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void bInfoDebate_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (debateSeleccionado != null)
                {
                    fInfoForo f = new fInfoForo(user, debateSeleccionado);
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    throw new Exception("No se ha seleccionado ningun debate");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }    
            
            
        }

        private void dgvDebatesRecientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDebatesRecientes.SelectedRows.Count > 0)
            {
                int id = (int)dgvDebatesRecientes.SelectedRows[0].Cells[0].Value;
                debateSeleccionado = new Debate(id);

            }
            else
            {
                debateSeleccionado = null;
            }
        }
    }
}
