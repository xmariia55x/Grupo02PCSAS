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
    public partial class fPantallaPrincipalAlumno : Form
    {
        private Usuario alumno;
        private Curso cursoSeleccionado;
        private Actividad actividadSeleccionada;

        public fPantallaPrincipalAlumno(Usuario u)
        {
            InitializeComponent();
            alumno = u;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fPantallaPrincipalAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.ActividadesRealizadas' Puede moverla o quitarla según sea necesario.
            this.actividadesRealizadasTableAdapter.Fill(this.apsgrupo02DataSet.ActividadesRealizadas);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.CursosRealizados' Puede moverla o quitarla según sea necesario.
            this.cursosRealizadosTableAdapter.Fill(this.apsgrupo02DataSet.CursosRealizados);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Actividad' Puede moverla o quitarla según sea necesario.
            this.actividadTableAdapter.Fill(this.apsgrupo02DataSet.Actividad);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Curso' Puede moverla o quitarla según sea necesario.

            lRol.Text = alumno.RolUsuario.RolName;
            lNombreUser.Text = alumno.NombreUsuario;

            cargaGrid();
        }

        private void cargaGrid()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            //nombreCurso 'Nombre', fechaInicioCurso, fechaFinCurso, aforoCurso
            MySqlCommand comandoC = new MySqlCommand("SELECT * FROM Curso WHERE fechaInicioCurso >= '" + DateTime.Now.ToString("dd / MM / yyyy") + "'", conexion);
            MySqlCommand comandoA = new MySqlCommand("SELECT * FROM Actividad WHERE fechaInicioActividad >= '" + DateTime.Now.ToString("dd / MM / yyyy") + "'", conexion);
            MySqlCommand comandoMC = new MySqlCommand("select * from CursosRealizados cr join Curso c on cr.idCurso = c.idCurso where cr.correo = '" + alumno.CorreoUsuario + "'", conexion);
            MySqlDataAdapter adaptadorC = new MySqlDataAdapter();
            MySqlDataAdapter adaptadorA = new MySqlDataAdapter();
            MySqlDataAdapter adaptadorMC = new MySqlDataAdapter();
            adaptadorC.SelectCommand = comandoC;
            adaptadorA.SelectCommand = comandoA;
            adaptadorMC.SelectCommand = comandoMC;
            DataTable tablaC = new DataTable();
            DataTable tablaA = new DataTable();
            DataTable tablaMC = new DataTable();
            adaptadorC.Fill(tablaC);
            adaptadorA.Fill(tablaA);
            adaptadorMC.Fill(tablaMC);
            dgvNuevosCursos.DataSource = tablaC;
            dgvNuevasActividades.DataSource = tablaA;
            dgvMisCursos.DataSource = tablaMC;
        }

       
        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForo foro = new PantallaPrincipalForo(alumno);
            this.Hide();
            foro.ShowDialog();
            this.Close();
        }

        private void dgvNuevosCursos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvNuevosCursos.SelectedRows.Count > 0)
                {
                    int id = (int)dgvNuevosCursos.SelectedRows[0].Cells[0].Value;
                    cursoSeleccionado = new Curso(id);
                }
                else
                {
                    cursoSeleccionado = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bInfoCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (cursoSeleccionado == null)
                {
                    throw new Exception("No hay ningun curso seleccionado");
                }
                else
                {
                    fInfoCurso info = new fInfoCurso(alumno, cursoSeleccionado);
                    this.Hide();
                    info.ShowDialog();
                    this.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bInsCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if(cursoSeleccionado == null)
                {
                    throw new Exception("No hay ningun curso seleccionado");
                } else
                {
                    int plazasDispo = calcularPlazasDisponiblesCurso();

                    if (plazasDispo > 0)
                    {
                        if (!inscritoCurso(alumno))
                        {
                            CursosRealizados c = new CursosRealizados(cursoSeleccionado.CursoID, alumno.CorreoUsuario);
                            MessageBox.Show("Se ha inscrito con éxito");
                            cargaGrid();
                        }
                        else
                        {
                            throw new Error("Ya estabas inscrito en ese curso");
                        }

                    }
                    else
                    {
                        throw new Error("No hay plazas disponibles");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private bool inscritoCurso(Usuario alumno)
        {
            bool ok = false;
            List<Curso> lista = CursosRealizados.listaCursos(alumno.CorreoUsuario);
            foreach(Curso c in lista)
                if (c.CursoID == cursoSeleccionado.CursoID)
                {
                    ok = true;
                    break;
                }
            return ok;
        }

        private void dgvNuevasActividades_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvNuevasActividades.SelectedRows.Count > 0)
                {
                    int id = (int)dgvNuevasActividades.SelectedRows[0].Cells[0].Value;
                    actividadSeleccionada = new Actividad(id);
                }
                else
                {
                    actividadSeleccionada = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private int calcularPlazasDisponiblesCurso()
        {
            List<Usuario> lista = CursosRealizados.listaUsuarios(cursoSeleccionado.CursoID);
            List<Usuario> filtro = new List<Usuario>();
            foreach (Usuario u in lista)
                if (u.RolUsuario.RolName.Equals("ALUMNO") || u.RolUsuario.RolName.Equals("PROFESOR"))
                    filtro.Add(u);
            int plazas = cursoSeleccionado.CursoAforo - filtro.Count;

            return plazas;
        }

        private int calcularPlazasDisponiblesActividad()
        {
            List<Usuario> lista = ActividadesRealizadas.listaUsuarios(actividadSeleccionada.IdActividad);
            List<Usuario> filtro = new List<Usuario>();
            foreach (Usuario u in lista)
                if (u.RolUsuario.RolName.Equals("ALUMNO") || u.RolUsuario.RolName.Equals("PROFESOR"))
                    filtro.Add(u);
            int plazas = actividadSeleccionada.AforoActividad - filtro.Count;

            return plazas;
        }

        private void bInfoAct_Click(object sender, EventArgs e)
        {
            try
            {
                if (actividadSeleccionada == null)
                {
                    throw new Exception("No hay ninguna actividad seleccionada");
                }
                else
                {
                    fInfoActividad info = new fInfoActividad(alumno, actividadSeleccionada);
                    this.Hide();
                    info.ShowDialog();
                    this.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            
        }

        private void bInsAct_Click(object sender, EventArgs e)
        {
            try
            {
                if (actividadSeleccionada == null)
                {
                    throw new Exception("No hay ninguna actividad seleccionada");
                }
                else
                {
                    int plazasDispo = calcularPlazasDisponiblesActividad();
                    if (plazasDispo > 0)
                    {
                        if (!inscritoActividad(alumno))
                        {
                            new ActividadesRealizadas(actividadSeleccionada.IdActividad, alumno.CorreoUsuario);
                            MessageBox.Show("Se ha inscrito con éxito");
                        }
                        else
                        {
                            throw new Error("Ya estabas inscrito en esa actividad");
                        }
                    }
                    else
                    {
                        throw new Error("No hay plazas disponibles");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private bool inscritoActividad(Usuario alumno)
        {
            bool ok = false;
            List<Actividad> lista = ActividadesRealizadas.listaActividades(alumno.CorreoUsuario);
            foreach (Actividad c in lista)
                if (c.IdActividad == actividadSeleccionada.IdActividad)
                {
                    ok = true;
                    break;
                }
            return ok;
        }

        private void dgvMisCursos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvMisCursos.SelectedRows.Count > 0)
                {
                    int id = (int) dgvMisCursos.SelectedRows[0].Cells[0].Value;
                    fInfoCurso info = new fInfoCurso(alumno, new Curso(id));
                    this.Hide();
                    info.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(alumno);
            this.Hide();
            datos.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(alumno);
            this.Hide();
            datos.ShowDialog();
            this.Close();
        }

        private void Noticias_Click(object sender, EventArgs e)
        {
            fNoticia noticias = new fNoticia(alumno);
            this.Hide();
            noticias.ShowDialog();
            this.Close();
        }
    }
}
