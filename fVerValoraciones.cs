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
    
    public partial class fVerValoraciones : Form
    {
        private Usuario user;
        private Object evento;
        public fVerValoraciones(Usuario user, Object evento)
        {
            InitializeComponent();
            this.user = user;
            this.evento = evento;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void cargaGridCurso()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            //nombreCurso 'Nombre', fechaInicioCurso, fechaFinCurso, aforoCurso
            MySqlCommand comandoC = new MySqlCommand("SELECT * FROM ValoracionCurso WHERE idCurso = " + ((Curso)evento).CursoID, conexion);
            MySqlDataAdapter adaptadorC = new MySqlDataAdapter();
            adaptadorC.SelectCommand = comandoC;
            DataTable tablaC = new DataTable();
            adaptadorC.Fill(tablaC);
            dgvValoracionCursos.DataSource = tablaC;
        }
        private void cargaGridActividad()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            //nombreCurso 'Nombre', fechaInicioCurso, fechaFinCurso, aforoCurso
            MySqlCommand comandoC = new MySqlCommand("SELECT * FROM ValoracionActividad WHERE idActividad = " + ((Actividad)evento).IdActividad, conexion);
            MySqlDataAdapter adaptadorC = new MySqlDataAdapter();
            adaptadorC.SelectCommand = comandoC;
            DataTable tablaC = new DataTable();
            adaptadorC.Fill(tablaC);
            dgvValoracionesActividad.DataSource = tablaC;
        }



        private void fVerValoraciones_Load(object sender, EventArgs e)
        {
            mostrarUsuario();

            if(evento is Curso)
            {
                lCurso.Visible = true;
                lActividad.Visible = false;
                dgvValoracionCursos.Visible = true;
                dgvValoracionesActividad.Visible = false;
                cargaGridCurso();
            }
            else
            {
                lCurso.Visible = false;
                lActividad.Visible = true;
                dgvValoracionCursos.Visible = false;
                dgvValoracionesActividad.Visible = true;
                cargaGridActividad();
            }
        }

        private void mostrarUsuario()
        {
            if (user == null)
            {
                lNombreUser.Text = "INVITADO";
                lRol.Text = "INVITADO";
            }
            else
            {
                lNombreUser.Text = user.NombreUsuario;
                lRol.Text = user.RolUsuario.RolName;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(evento is Curso)
            {
                fInfoCursoProfesor curso = new fInfoCursoProfesor(user, (Curso)evento);
                this.Hide();
                curso.ShowDialog();
                this.Close();
            }
            else
            {
                fInfoActividad curso = new fInfoActividad(user, (Actividad)evento);
                this.Hide();
                curso.ShowDialog();
                this.Close();
            }
        }
    }
}
