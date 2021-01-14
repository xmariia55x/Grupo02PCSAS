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
			this.user = user;
			InitializeComponent();
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		/*
		private void fDatosPerfil_Paint(object sender, PaintEventArgs e)
		{
			Graphics l = e.Graphics;
			Pen p = new Pen(Color.Black);
			//l.DrawLine(p, 400, 386, 400, 886);
		}
		*/

		private void fDatosPerfil_Load(object sender, EventArgs e)
		{
			label20.Text = user.RolUsuario.RolName;
			lNombreUser.Text = user.NombreUsuario;
			lNombreDatos.Visible = true;
			lPassword.Visible = true;
			lCorreo.Visible = true;
			if (user.RolUsuario.RolName.Equals("ALUMNO") || user.RolUsuario.RolName.Equals("ADMIN"))
            {
				lNIU.Visible = false;
				lCIF.Visible = false;
				tNIU.Visible = false;
				tCIF.Visible = false;

				tNombre.Text = user.NombreUsuario;
				tPassword.Text = user.ContraseniaUsuario;
				tCorreo.Text = user.CorreoUsuario;
			}
			else if (user.RolUsuario.RolName.Equals("PROFESOR"))
            {
				lNIU.Visible = true;
				lCIF.Visible = false;
				tNIU.Visible = true;
				tCIF.Visible = false;

				tNombre.Text = user.NombreUsuario;
				tPassword.Text = user.ContraseniaUsuario;
				tCorreo.Text = user.CorreoUsuario;
				tNIU.Text = user.NiuUsuario;
			

			}
			else if (user.RolUsuario.RolName.Equals("ENTIDAD"))
            {
				lNIU.Visible = false;
				lCIF.Visible = true;
				tNIU.Visible = false;
				tCIF.Visible = true;

				tNombre.Text = user.NombreUsuario;
				tPassword.Text = user.ContraseniaUsuario;
				tCorreo.Text = user.CorreoUsuario;
				tCIF.Text = user.CifUsuario;

			}
			//Cargar el dataGridView filtrado CursoRealizado

			MySqlConnection conexion = new MySqlConnection();
			conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
			conexion.Open();
			MySqlCommand comando = new MySqlCommand("select c.nombreCurso as `Nombre Curso`, c.fechaInicioCurso as `Fecha Inicio`, c.fechaFinCurso as `Fecha Fin`, c.profesorCurso as `Profesor`, c.lugarCurso as `Lugar` from CursosRealizados cr join Curso c on cr.idCurso=c.idCurso where cr.correo = '" + user.CorreoUsuario + "';", conexion);
			MySqlDataAdapter adaptador = new MySqlDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dataGridView1.DataSource = tabla;

			dataGridView1.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridView1.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridView1.Columns[3].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridView1.Columns[4].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			

			//Cargar el dataGridView filtrado ActividadRealizado

			MySqlConnection conexion2 = new MySqlConnection();
			conexion2.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
			conexion2.Open();
			MySqlCommand comando2 = new MySqlCommand("select a.nombreActividad as `Nombre Actividad`, a.fechaInicioActividad as `Fecha Inicio`, a.fechaFinActividad as `Fecha Fin`, a.creadorActividad as `Creador`, a.lugarActividad as `Lugar` from ActividadesRealizadas ar join Actividad a on ar.idActividad = a.idActividad " +
				"where ar.correo = '" + user.CorreoUsuario + "' ;", conexion2);
			MySqlDataAdapter adaptador2 = new MySqlDataAdapter();
			adaptador2.SelectCommand = comando2;
			DataTable tabla2 = new DataTable();
			adaptador2.Fill(tabla2);
			dataGridView2.DataSource = tabla2;
			dataGridView2.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridView2.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridView2.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridView2.Columns[3].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridView2.Columns[4].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			/*
			dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			 i = 0;
			foreach (DataGridViewColumn c in dataGridView1.Columns)
			{
				i += c.Width;
			}
			
			dataGridView2.Width = i + dataGridView2.RowHeadersWidth + 2;
			dataGridView2.Height = dataGridView2.GetRowDisplayRectangle(dataGridView2.NewRowIndex, true).Bottom +
				dataGridView2.GetRowDisplayRectangle(dataGridView2.NewRowIndex, false).Height;

			*/
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
				fInicioInvitado inicio = new fInicioInvitado();
				//this.Visible = false;
				this.Hide();
				inicio.ShowDialog();
				this.Close();
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
			fEditarPerfil edicion = new fEditarPerfil(user);
			this.Hide();
			edicion.ShowDialog();
			this.Close();
		}

        private void pictureBox3_Click(object sender, EventArgs e)
        {
			this.Close();
		}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
			fDatosPerfil datos = new fDatosPerfil(user);
			this.Visible = false;
			datos.ShowDialog();
			this.Visible = true;
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
				fPantallaAdminFinal inicio = new fPantallaAdminFinal(user);
				this.Visible = false;
				inicio.ShowDialog();
				this.Visible = true;
			}
		}

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bMensajes_Click(object sender, EventArgs e)
        {
			fBandejaMensajes f = new fBandejaMensajes(this.user);
			this.Hide();
			f.ShowDialog();
			this.Close();
		}
    }
}
