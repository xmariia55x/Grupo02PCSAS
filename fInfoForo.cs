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

            lNombreUser.Text = this.user.NombreUsuario;
            lRol.Text = this.user.RolUsuario.RolName;
            lNombreDebateCreador.Text = this.debate.CreadorDebate;
            lAsunto.Text = this.debate.AsuntoDebate;
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select cuerpo as `Mensaje`,correoUsuario as `Autor`,fecha as `Fecha del mensaje` from Respuesta where idDebate= " + this.debate.ID + ";", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
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
