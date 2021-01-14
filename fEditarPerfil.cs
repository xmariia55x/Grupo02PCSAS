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
			this.user = user;
			InitializeComponent();
            
		}
        private void fEditarPerfil_Load(object sender, EventArgs e)
        {
			label20.Text = user.RolUsuario.RolName;
			lNombreUser.Text = user.NombreUsuario;
			// TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.ActividadesRealizadas' Puede moverla o quitarla según sea necesario.
			//this.actividadesRealizadasTableAdapter.Fill(this.apsgrupo02DataSet.ActividadesRealizadas);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.CursosRealizados' Puede moverla o quitarla según sea necesario.
            //this.cursosRealizadosTableAdapter.Fill(this.apsgrupo02DataSet.CursosRealizados);
			if (user.RolUsuario.RolName.Equals("ALUMNO"))
			{
				
				panelAlumno.Visible = true;
				panelProfesor.Visible = false;
				panelEntidad.Visible = false;
				MostrarAlumno();
			}
			else if (user.RolUsuario.RolName.Equals("PROFESOR"))
			{
				panelAlumno.Visible = false;
				panelProfesor.Visible = true;
				panelEntidad.Visible = false;
				MostrarProfesor();
			}
			else if (user.RolUsuario.RolName.Equals("ENTIDAD"))
			{
				panelAlumno.Visible = false;
				panelEntidad.Visible = true;
				panelProfesor.Visible = false;
				MostrarEntidad();
			}
			//Cargar el dataGridView filtrado CursoRealizado

			MySqlConnection conexion = new MySqlConnection();
			conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
			conexion.Open();
			MySqlCommand comando = new MySqlCommand("select c.nombreCurso as `Nombre curso` from CursosRealizados cr join Curso c on cr.idCurso=c.idCurso where cr.correo = '" +user.CorreoUsuario+ "';", conexion);
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
			comando = new MySqlCommand("select a.nombreActividad as `Nombre actividad` from ActividadesRealizadas ar join Actividad a on ar.idActividad = a.idActividad " +
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

        private void MostrarEntidad()
        {
			tCorreoEntidad.Text = user.CorreoUsuario;
			tNombreEntidad.Text = user.NombreUsuario;
			tPwdEntidad.Text = user.ContraseniaUsuario;
			tCifEntidad.Text = user.CifUsuario;
		}

        private void MostrarProfesor()
        {
			tCorreoProfesor.Text = user.CorreoUsuario;
			tNombreProfesor.Text = user.NombreUsuario;
			tPwdProfesor.Text = user.ContraseniaUsuario;
			tNiuProfe.Text = user.NiuUsuario;
		}

        private void MostrarAlumno()
        {
			tEmailAlumno.Text = user.CorreoUsuario;
			tNombreAlumno.Text=  user.NombreUsuario;
			tPwdAlumno.Text = user.ContraseniaUsuario;
		}

        
        
        private void bAtras_Click(object sender, EventArgs e)
        {
			fDatosPerfil edicion = new fDatosPerfil(user);
			this.Hide();
			edicion.ShowDialog();
			this.Close();
		}

        

        private void bGuardarCambios_Click(object sender, EventArgs e)
        {
            if (user.RolUsuario.RolName.Equals("ALUMNO"))
            {
					if(!tEmailAlumno.Text.Equals(user.CorreoUsuario)) user.CorreoUsuario = tEmailAlumno.Text;
					if (!tNombreAlumno.Text.Equals(user.NombreUsuario)) user.NombreUsuario = tNombreAlumno.Text;
					if(tPwdAlumno.Text.Equals(tConfPwdAlumno.Text) && !tPwdAlumno.Text.Equals(user.ContraseniaUsuario)) user.ContraseniaUsuario = tPwdAlumno.Text;
            }
			else if (user.RolUsuario.RolName.Equals("PROFESOR"))
			{
					if (!tCorreoProfesor.Text.Equals(user.CorreoUsuario)) user.CorreoUsuario = tCorreoProfesor.Text;
					if (!tNombreProfesor.Text.Equals(user.NombreUsuario)) user.NombreUsuario = tNombreProfesor.Text;
					if (tPwdProfesor.Text.Equals(tConfPwdProfesor.Text) && !tPwdProfesor.Text.Equals(user.ContraseniaUsuario)) user.ContraseniaUsuario = tPwdProfesor.Text;
					if (!tNiuProfe.Text.Equals(user.NiuUsuario)) user.NiuUsuario = tNiuProfe.Text;
			}else if (user.RolUsuario.RolName.Equals("ENTIDAD"))
			{
					if (!tCorreoEntidad.Text.Equals(user.CorreoUsuario)) user.CorreoUsuario = tCorreoEntidad.Text;
					if (!tNombreEntidad.Text.Equals(user.NombreUsuario)) user.NombreUsuario = tNombreEntidad.Text;
					if (tPwdEntidad.Text.Equals(tConfPwdEntidad.Text) && !tPwdEntidad.Text.Equals(user.ContraseniaUsuario)) user.ContraseniaUsuario = tPwdEntidad.Text;
					if (!tCifEntidad.Text.Equals(user.CifUsuario)) user.CifUsuario = tCifEntidad.Text;
			}
			fDatosPerfil f = new fDatosPerfil(user);
			this.Hide();
			f.ShowDialog();
			this.Close();
		}

        private void lNombre_Click(object sender, EventArgs e)
        {

        }


        

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
			fDatosPerfil datos = new fDatosPerfil(user);
			this.Visible = false;
			datos.ShowDialog();
			this.Visible = true;
		}

        private void label1_Click(object sender, EventArgs e)
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
    }
}
