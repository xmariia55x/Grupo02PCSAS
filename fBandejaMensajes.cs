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
    public partial class fBandejaMensajes : Form
    {
        private Usuario user;
        private Mensaje mensajeSeleccionado;
        public fBandejaMensajes(Usuario u)
        {
            InitializeComponent();
            user = u;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fBandejaMensajes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet1.Mensaje' Puede moverla o quitarla según sea necesario.
            //this.mensajeTableAdapter.Fill(this.apsgrupo02DataSet1.Mensaje);
            label6.Text = user.RolUsuario.RolName;
            label8.Text = user.NombreUsuario;

            //Carga la bandeja de mensajes del usuario

            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select emisor as `Emisor`,asunto as `Asunto`,idMensaje as 'ID',cuerpo as `Cuerpo`,fecha as `Fecha del mensaje` from Mensaje where receptor= '" + user.CorreoUsuario + "';", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            dataGridView1.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void bNuevoMensaje_Click(object sender, EventArgs e)
        {
            fRedactarMensaje f = new fRedactarMensaje(user);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Hide();
            datos.ShowDialog();
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[2].Value;
                mensajeSeleccionado = new Mensaje(id);

            }
            else
            {
                mensajeSeleccionado = null;
            }
        }

        private void bInfoMensaje_Click(object sender, EventArgs e)
        {
            if (mensajeSeleccionado == null)
            {
                MessageBox.Show("No se ha seleccionado ningún mensaje");
            } else
            {
                fInfoMensaje f = new fInfoMensaje(user, mensajeSeleccionado);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
