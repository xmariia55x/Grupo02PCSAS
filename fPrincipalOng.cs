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
        Curso cursoSeleccionado;
        Actividad actividadSeleccionada;
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
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet1.Curso' Puede moverla o quitarla según sea necesario.
            this.cursoTableAdapter.Fill(this.apsgrupo02DataSet1.Curso);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Actividad' Puede moverla o quitarla según sea necesario.
            //this.actividadTableAdapter.Fill(this.apsgrupo02DataSet.Actividad);
            lRol.Text = ong.RolUsuario.RolName;
            lNombreUser.Text = ong.NombreUsuario;

            cargaGrid();
        }

        private void cargaGrid()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Actividad WHERE creadorActividad = '" + ong.CorreoUsuario + "'", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            cargaActividadesFecha(DateTime.Now.ToShortDateString());
            cargaCursosFecha(DateTime.Now.ToShortTimeString());
        }

        private void cargaActividadesFecha(string fecha)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            //MySqlCommand comando = new MySqlCommand("SELECT creadorActividad as `Creador`, nombreActividad as `Nombre`, descripcionActividad as `Descripcion`, lugarActividad as `Lugar` FROM Curso WHERE fechaInicioActividad = '" + fecha + "'", conexion);
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Actividad WHERE fechaInicioActividad = '" + fecha + "'", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            if (tabla.Rows.Count == 0)
            {
                lNoActividades.Visible = true;
                lNoActividades.Text = "No hay actividades disponibles para el día seleccionado";
                dgvActividades.Visible = false;
                bInformacionActividad.Visible = false;
               
            }
            else
            {
                dgvActividades.Visible = true;
                dgvActividades.DataSource = tabla;
                lNoActividades.Visible = false;
                bInformacionActividad.Visible = true;
               
            }
        }

        private void cargaCursosFecha(string fecha)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            //MySqlCommand comando = new MySqlCommand("SELECT profesorCurso as `Profesor`, nombreCurso as `Nombre`, descripcionCurso as `Descripcion`, lugarCurso as `Lugar` FROM Curso WHERE fechaInicioCurso = '" + fecha + "'", conexion);
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Curso WHERE fechaInicioCurso = '" + fecha + "'", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            if (tabla.Rows.Count == 0)
            {
                lNoCursos.Visible = true;
                lNoCursos.Text = "No hay cursos disponibles para el día seleccionado";
                dgvCursos.Visible = false;
                bInformacionCurso.Visible = false;
            }
            else
            {
                dgvCursos.Visible = true;
                dgvCursos.DataSource = tabla;
                lNoCursos.Visible = false;
                bInformacionCurso.Visible = true;
            }

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

            cargaGrid();
        }

        private void bNoticias_Click(object sender, EventArgs e)
        {
            fNoticia noticias = new fNoticia(ong);
            this.Visible = false;
            noticias.ShowDialog();
            this.Visible = true;
        }

        private void bInformacionCurso_Click(object sender, EventArgs e)
        {
            try
            {

                fInfoCurso infoCurso = new fInfoCurso(ong, cursoSeleccionado);
                this.Hide();
                infoCurso.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bInformacionActividad_Click(object sender, EventArgs e)
        {
            try
            {
                if (actividadSeleccionada == null)
                {
                    fInfoActividad infoActividad = new fInfoActividad(ong, actividadSeleccionada);
                    this.Hide();
                    infoActividad.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            string fechaSeleccionada = e.Start.ToShortDateString();
            cargaActividadesFecha(fechaSeleccionada);
            cargaCursosFecha(fechaSeleccionada);
        }

        private void dgvCursos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCursos.SelectedRows.Count > 0)
            {
                int idSel = (int)dgvCursos.SelectedRows[0].Cells[0].Value;
                cursoSeleccionado = new Curso(idSel);
            }
        }

        private void dgvActividades_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvActividades.SelectedRows.Count > 0)
            {
                int idSel = (int)dgvActividades.SelectedRows[0].Cells[0].Value;
                actividadSeleccionada = new Actividad(idSel);
            }
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado == null)
                {
                    throw new Exception("No hay ninguna actividad seleccionada");
                } else
                {
                    fModificarActividad f = new fModificarActividad(ong, seleccionado);
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                    cargaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado == null)
                {
                    throw new Exception("No hay ninguna actividad seleccionada");
                }
                else
                {
                    if (MessageBox.Show("¿Quieres eliminar la actividad " + seleccionado.NombreActividad + "?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        seleccionado.BorrarActividad();
                        cargaGrid();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
