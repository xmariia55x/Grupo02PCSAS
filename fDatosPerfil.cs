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
	public partial class fDatosPerfil : Form
	{
		private Usuario user;
        public fDatosPerfil(Usuario user)
		{
			InitializeComponent();
			this.user = user;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void fDatosPerfil_Paint(object sender, PaintEventArgs e)
		{
			Graphics l = e.Graphics;
			Pen p = new Pen(Color.Black);
			//l.DrawLine(p, 400, 386, 400, 886);
		}

		private void fDatosPerfil_Load(object sender, EventArgs e)
		{
			lRol.Text = user.RolUsuario.RolName;
			lNombre.Text = user.NombreUsuario;
            if (user.RolUsuario.RolName.Equals("ALUMNO"))
            {

				panelAlumno.Visible = true;
				panelProfesor.Visible = false;
				panelProfesor.Enabled = false;
				panelEntidad.Visible = false;
				panelEntidad.Enabled = false;

				lNombreAlumno.Text = user.NombreUsuario;
				lEmailAlumno.Text = user.CorreoUsuario;
				lPwdAlumno.Text = user.ContraseniaUsuario;

			}else if (user.RolUsuario.RolName.Equals("PROFESOR"))
            {
				panelAlumno.Visible = false;
				panelAlumno.Enabled = false;
				panelProfesor.Visible = true;
				panelEntidad.Visible = false;
				panelEntidad.Enabled = false;

				lNombreProfe.Text = user.NombreUsuario;
				lEmailProfe.Text = user.CorreoUsuario;
				lNiuProfe.Text = user.NiuUsuario;
				lPwdProfe.Text = user.ContraseniaUsuario;

            }else if (user.RolUsuario.RolName.Equals("ENTIDAD"))
            {
				panelAlumno.Visible = false;
				panelAlumno.Enabled = false;
				panelEntidad.Visible = true;
				panelProfesor.Visible = false;
				panelProfesor.Enabled = false;

				lEmailEntidad.Text = this.user.CorreoUsuario;
				lCifEntidad.Text = this.user.CifUsuario;
				lPwdEntidad.Text = this.user.ContraseniaUsuario;

			}
			//Cargar el dataGridView filtrado CursoRealizado

			MySqlConnection conexion = new MySqlConnection();
			conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
			conexion.Open();
			MySqlCommand comando = new MySqlCommand("select c.nombreCurso from CursosRealizados cr join Curso c on cr.idCurso=c.idCurso where cr.correo = '" + user.CorreoUsuario + "';", conexion);
			MySqlDataAdapter adaptador = new MySqlDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dataGridView1.DataSource = tabla;

			//Hazle el resize
			dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

			int i = 0;
			foreach (DataGridViewColumn c in dataGridView1.Columns)
			{
				i += c.Width;
			}

			dataGridView1.Width = i + dataGridView1.RowHeadersWidth + 2;
			dataGridView1.Height = dataGridView1.GetRowDisplayRectangle(dataGridView1.NewRowIndex, true).Bottom + 
				dataGridView1.GetRowDisplayRectangle(dataGridView1.NewRowIndex, false).Height;

			//Cargar el dataGridView filtrado ActividadRealizado

			conexion = new MySqlConnection();
			conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
			conexion.Open();
			comando = new MySqlCommand("select a.nombreActividad from ActividadesRealizadas ar join Actividad a on ar.idActividad = a.idActividad " +
				"where ar.correo = '" + user.CorreoUsuario + "' ;", conexion);
			adaptador = new MySqlDataAdapter();
			adaptador.SelectCommand = comando;
			tabla = new DataTable();
			adaptador.Fill(tabla);
			dataGridView2.DataSource = tabla;
			
			dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			 i = 0;
			foreach (DataGridViewColumn c in dataGridView1.Columns)
			{
				i += c.Width;
			}

			dataGridView2.Width = i + dataGridView2.RowHeadersWidth + 2;
			dataGridView2.Height = dataGridView2.GetRowDisplayRectangle(dataGridView2.NewRowIndex, true).Bottom +
				dataGridView2.GetRowDisplayRectangle(dataGridView2.NewRowIndex, false).Height;


		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void bBorrarPerfil_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("¿Desea borrar el usuario?", "ALERTA", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				this.user.BorrarUsuario();
			}
			else if (dialogResult == DialogResult.No)
			{
				//do something else
				
			}
		}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bEditarPerfil_Click(object sender, EventArgs e)
        {
			fEditarPerfil edicion = new fEditarPerfil(this.user);
			this.Visible = false;
			edicion.ShowDialog();
			this.Visible = true;
		}

        private void pictureBox3_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
			
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
				fPantallaAdmin inicio = new fPantallaAdmin(user);
				this.Visible = false;
				inicio.ShowDialog();
				this.Visible = true;
			}
		}
    }
}
