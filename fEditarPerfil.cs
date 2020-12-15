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
	public partial class fEditarPerfil : Form
	{
        private Usuario user;
		public fEditarPerfil(Usuario user)
		{
			InitializeComponent();
            this.user = user;
		}
        private void fEditarPerfil_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.ActividadesRealizadas' Puede moverla o quitarla según sea necesario.
            this.actividadesRealizadasTableAdapter.Fill(this.apsgrupo02DataSet.ActividadesRealizadas);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.CursosRealizados' Puede moverla o quitarla según sea necesario.
            this.cursosRealizadosTableAdapter.Fill(this.apsgrupo02DataSet.CursosRealizados);
            lRol.Text = user.RolUsuario.RolName;
			lNombre.Text = user.NombreUsuario;
			if (user.RolUsuario.RolName.Equals("ALUMNO"))
			{
				
				panelAlumno.Visible = true;
				panelProfesor.Visible = false;
				
				panelEntidad.Visible = false;
				

				

			}
			else if (user.RolUsuario.RolName.Equals("PROFESOR"))
			{
				panelAlumno.Visible = false;
				
				panelProfesor.Visible = true;
				panelEntidad.Visible = false;
				
				

			}
			else if (user.RolUsuario.RolName.Equals("ENTIDAD"))
			{
				panelAlumno.Visible = false;
				panelEntidad.Visible = true;
				panelProfesor.Visible = false;
				

			}
			//Cargar el dataGridView filtrado CursoRealizado

			MySqlConnection conexion = new MySqlConnection();
			conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
			conexion.Open();
			MySqlCommand comando = new MySqlCommand("select c.nombreCurso from CursosRealizados cr join Curso c on cr.idCurso=c.idCurso where cr.correo = '" +user.CorreoUsuario+ "';", conexion);
			MySqlDataAdapter adaptador = new MySqlDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dataGridView1.DataSource = tabla;
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
				"where ar.correo = '" + user.CorreoUsuario+"' ;", conexion);
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
		private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void bGuardarCambios_Click(object sender, EventArgs e)
        {
            if (user.RolUsuario.RolName.Equals("ALUMNO"))
            {
                
					if(tEmailAlumno.Text != null ) user.CorreoUsuario = tEmailAlumno.Text;
					if (tNombreAlumno.Text != null) user.NombreUsuario = tNombreAlumno.Text;
					if(tPwdAlumno.Text.Equals(tConfPwdAlumno.Text))user.ContraseniaUsuario = tPwdAlumno.Text;
				
            }
			else if (user.RolUsuario.RolName.Equals("PROFESOR"))
			{
				
					if (tCorreoProfesor.Text != null) user.CorreoUsuario = tCorreoProfesor.Text;
					if (tNombreProfesor.Text != null) user.NombreUsuario = tNombreProfesor.Text;
					if (tPwdAlumno.Text.Equals(tConfPwdProfesor.Text)) user.ContraseniaUsuario = tPwdProfesor.Text;
					if (tNiuProfe.Text != null) user.NiuUsuario = tNiuProfe.Text;
			}else if (user.RolUsuario.RolName.Equals("ENTIDAD"))
			{
				
					if (tCorreoEntidad.Text != null) user.CorreoUsuario = tCorreoEntidad.Text;
					if (tNombreEntidad.Text != null) user.NombreUsuario = tNombreEntidad.Text;
					if (tPwdEntidad.Text.Equals(tConfPwdEntidad.Text)) user.ContraseniaUsuario = tPwdEntidad.Text;
					if (tCifEntidad.Text != null) user.CifUsuario = tCifEntidad.Text;
				
			}
		}

        private void lNombre_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
