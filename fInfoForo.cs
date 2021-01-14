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
    public partial class fInfoForo : Form
    {
        private Usuario user;
        private Debate debate;
        public fInfoForo(Usuario u, Debate d)
        {
            InitializeComponent();
            this.user = u;
            this.debate = d;
        }

        private void fInfoForo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet2.Debate' Puede moverla o quitarla según sea necesario.
            //this.debateTableAdapter.Fill(this.apsgrupo02DataSet2.Debate);

            lNombreUser.Text = this.user.NombreUsuario;
            lRol.Text = this.user.RolUsuario.RolName;
            lNombreDebateCreador.Text = this.debate.CreadorDebate;
            lAsunto.Text = this.debate.AsuntoDebate;
            /*
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select cuerpo as `Mensaje`,correoUsuario as `Autor`,fecha as `Fecha del mensaje` from Respuesta where idDebate= " + this.debate.ID + ";", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            */
            cargaGrid();
        }

        private void cargaGrid()
        {
            dataGridView1.DataSource = Respuesta.listaRespuestas(debate.ID);

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;

            //Columnas visibles
            dataGridView1.Columns[2].HeaderText = "Usuario";
            dataGridView1.Columns[3].HeaderText = "Mensaje";
            dataGridView1.Columns[4].HeaderText = "Fecha";

            dataGridView1.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void bRespuesta_Click(object sender, EventArgs e)
        {
            fRedactarRespuesta f = new fRedactarRespuesta(user,debate);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForo f = new PantallaPrincipalForo(user);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
