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
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
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
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet1.Actividad' Puede moverla o quitarla según sea necesario.
            //this.actividadTableAdapter1.Fill(this.apsgrupo02DataSet1.Actividad);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.ActividadesRealizadas' Puede moverla o quitarla según sea necesario.
            //this.actividadesRealizadasTableAdapter.Fill(this.apsgrupo02DataSet.ActividadesRealizadas);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.CursosRealizados' Puede moverla o quitarla según sea necesario.
            //this.cursosRealizadosTableAdapter.Fill(this.apsgrupo02DataSet.CursosRealizados);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Actividad' Puede moverla o quitarla según sea necesario.
            //this.actividadTableAdapter.Fill(this.apsgrupo02DataSet.Actividad);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Curso' Puede moverla o quitarla según sea necesario.

            lRol.Text = alumno.RolUsuario.RolName;
            lNombreUser.Text = alumno.NombreUsuario;

            cargaGrid();
            cargaActividadesFecha(DateTime.Now.ToShortDateString());
            cargaCursosFecha(DateTime.Now.ToShortDateString());
        }
        private List<Curso> sacarFechasCurso()
        {
            string sentencia = "SELECT idCurso, fechaInicioCurso, horaInicioCurso FROM Curso";
            List<Curso> lista = new List<Curso>();
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach (Object[] obj in bd.Select(sentencia))
            {
                string fecha = (string)obj[1];
                string hora = (string)obj[2];
                string[] fechaSplit = fecha.Split('/');
                string[] horaSplit = hora.Split(':');
                DateTime dt = new DateTime(int.Parse(fechaSplit[2]), int.Parse(fechaSplit[1]), int.Parse(fechaSplit[0]), int.Parse(horaSplit[0]), int.Parse(horaSplit[1]), 0);
                if (dt.CompareTo(DateTime.Now) >= 0)
                {
                    Curso c = new Curso((int)obj[0]);
                    lista.Add(c);
                }
            }
            return lista;
        }

        private List<Actividad> sacarFechasActividad()
        {
            string sentencia = "SELECT idActividad, fechaInicioActividad, horaInicioActividad FROM Actividad";
            List<Actividad> lista = new List<Actividad>();
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach (Object[] obj in bd.Select(sentencia))
            {

                string fecha = (string)obj[1];
                string hora = (string)obj[2];
                string[] fechaSplit = fecha.Split('/');
                string[] horaSplit = hora.Split(':');
                DateTime dt = new DateTime(int.Parse(fechaSplit[2]), int.Parse(fechaSplit[1]), int.Parse(fechaSplit[0]), int.Parse(horaSplit[0]), int.Parse(horaSplit[1]), 0);

                if (dt.CompareTo(DateTime.Now) >= 0)
                {

                    lista.Add(new Actividad((int)obj[0]));
                }

            }
            return lista;
        }
        private void cargaGrid()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            //nombreCurso 'Nombre', fechaInicioCurso, fechaFinCurso, aforoCurso
            
            MySqlCommand comandoMC = new MySqlCommand("select * from CursosRealizados cr join Curso c on cr.idCurso = c.idCurso where cr.correo = '" + alumno.CorreoUsuario + "'", conexion);
            MySqlCommand comandoMA = new MySqlCommand("select * from ActividadesRealizadas ar join Actividad a on ar.idActividad = a.idActividad where ar.correo = '" + alumno.CorreoUsuario + "'", conexion);

           
            MySqlDataAdapter adaptadorMC = new MySqlDataAdapter();
            MySqlDataAdapter adaptadorMA = new MySqlDataAdapter();
         
            adaptadorMC.SelectCommand = comandoMC;
            adaptadorMA.SelectCommand = comandoMA;
         
            DataTable tablaMC = new DataTable();
            DataTable tablaMA = new DataTable();
        
            adaptadorMC.Fill(tablaMC);
            adaptadorMA.Fill(tablaMA);
          
            dgvMisCursos.DataSource = tablaMC;
            dgvMisAct.DataSource = tablaMA;

            //DGVCURSOS
            dgvNuevosCursos.DataSource = sacarFechasCurso();
            //Columnas no visibles
            dgvNuevosCursos.Columns[0].Visible = false;
            dgvNuevosCursos.Columns[1].Visible = false;
            dgvNuevosCursos.Columns[3].Visible = false;
            dgvNuevosCursos.Columns[6].Visible = false;
            dgvNuevosCursos.Columns[7].Visible = false;

            //Columnas visibles
            dgvNuevosCursos.Columns[2].HeaderText = "Nombre";
            dgvNuevosCursos.Columns[4].HeaderText = "Fecha inicio";
            dgvNuevosCursos.Columns[5].HeaderText = "Fecha fin";
            dgvNuevosCursos.Columns[8].HeaderText = "Lugar";
            dgvNuevosCursos.Columns[9].HeaderText = "Aforo";
            dgvNuevosCursos.Columns[10].HeaderText = "Online";

            dgvNuevosCursos.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgvNuevosCursos.Columns[4].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNuevosCursos.Columns[5].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNuevosCursos.Columns[8].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNuevosCursos.Columns[9].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNuevosCursos.Columns[10].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;

            //DGVACTIVIDADES
            dgvNuevasActividades.DataSource = sacarFechasActividad();

            dgvNuevasActividades.Columns[0].Visible = false;
            dgvNuevasActividades.Columns[1].Visible = false;
            dgvNuevasActividades.Columns[3].Visible = false;
            dgvNuevasActividades.Columns[6].Visible = false;
            dgvNuevasActividades.Columns[7].Visible = false;

            //Columnas visibles
            dgvNuevasActividades.Columns[2].HeaderText = "Nombre";
            dgvNuevasActividades.Columns[4].HeaderText = "Fecha inicio";
            dgvNuevasActividades.Columns[5].HeaderText = "Fecha fin";
            dgvNuevasActividades.Columns[8].HeaderText = "Lugar";
            dgvNuevasActividades.Columns[9].HeaderText = "Aforo";

            dgvNuevasActividades.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgvNuevasActividades.Columns[4].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNuevasActividades.Columns[5].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNuevasActividades.Columns[8].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNuevasActividades.Columns[9].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;

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
                            cargaGrid();
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
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(alumno);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void Noticias_Click(object sender, EventArgs e)
        {
            fNoticia noticias = new fNoticia(alumno);
            this.Hide();
            noticias.ShowDialog();
            this.Close();
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

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            string fechaSeleccionada = e.Start.ToShortDateString();
            cargaActividadesFecha(fechaSeleccionada);
            cargaCursosFecha(fechaSeleccionada);
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
                bInscribirCurso.Visible = false;
            }
            else
            {
                dgvCursos.Visible = true;
                dgvCursos.DataSource = tabla;
                lNoCursos.Visible = false;
                bInformacionCurso.Visible = true;
                bInscribirCurso.Visible = true;
            }

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
                bInscribirActividad.Visible = false;
            }
            else
            {
                dgvActividades.Visible = true;
                dgvActividades.DataSource = tabla;
                lNoActividades.Visible = false;
                bInformacionActividad.Visible = true;
                bInscribirActividad.Visible = true;
            }

        }

        private void bInformacionCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if(cursoSeleccionado == null)
                {
                    throw new Exception("Ningún curso seleccionado");
                }
                else
                {
                    fInfoCurso infoCurso = new fInfoCurso(alumno, cursoSeleccionado);
                    this.Hide();
                    infoCurso.ShowDialog();
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bInscribirCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (cursoSeleccionado == null)
                {
                    throw new Exception("Ningún curso seleccionado");
                }
                else
                {
                    int plazasDispo = calcularPlazasDisponiblesCurso();

                    if (plazasDispo > 0)
                    {
                        if (!inscritoCurso(alumno))
                        {
                            string[] horaSplit = cursoSeleccionado.CursoHoraInicio.Split(':');
                            string[] fechaSplit = cursoSeleccionado.CursoFechaInicio.Split('/');
                            DateTime dt = new DateTime(int.Parse(fechaSplit[2]), int.Parse(fechaSplit[1]), int.Parse(fechaSplit[0]), int.Parse(horaSplit[0]), int.Parse(horaSplit[1]), 0);
                            DateTime dt2 = DateTime.Now;
                            if (dt.CompareTo(dt2) <= 0)
                            {
                                throw new Exception("Este curso ya ha finalizado.");
                            } else
                            {
                                CursosRealizados c = new CursosRealizados(cursoSeleccionado.CursoID, alumno.CorreoUsuario);
                                MessageBox.Show("Se ha inscrito con éxito");
                                cargaGrid();
                            }
                            
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

        private void bInformacionActividad_Click(object sender, EventArgs e)
        {
            try
            {
                if(actividadSeleccionada == null)
                {
                    throw new Exception("Ninguna actividad seleccionada");
                } else
                {
                    if (alumno.RolUsuario.RolName.Equals("ALUMNO"))
                    {
                        fInfoActividad infoActividad = new fInfoActividad(alumno, actividadSeleccionada);
                        this.Hide();
                        infoActividad.ShowDialog();
                        this.Close();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bInscribirActividad_Click(object sender, EventArgs e)
        {
            try
            {
                if (actividadSeleccionada == null)
                {
                    throw new Exception("Ninguna actividad seleccionada");
                }
                else
                {
                    int plazasDispo = calcularPlazasDisponiblesActividad();

                    if (plazasDispo > 0)
                    {
                        if (!inscritoActividad(alumno))
                        {
                            string[] horaSplit = actividadSeleccionada.HoraInicioActividad.Split(':');
                            string[] fechaSplit = actividadSeleccionada.FechaInicioActividad.Split('/');
                            DateTime dt = new DateTime(int.Parse(fechaSplit[2]), int.Parse(fechaSplit[1]), int.Parse(fechaSplit[0]), int.Parse(horaSplit[0]), int.Parse(horaSplit[1]), 0);
                            DateTime dt2 = DateTime.Now;
                            if(dt.CompareTo(dt2) <= 0)
                            {
                                throw new Exception("Esta actividad ya ha finalizado.");
                            }
                            else
                            {
                                ActividadesRealizadas a = new ActividadesRealizadas(actividadSeleccionada.IdActividad, alumno.CorreoUsuario);
                                MessageBox.Show("Se ha inscrito con éxito");
                                cargaGrid();
                            }

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

        private void dgvMisAct_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvMisAct.SelectedRows.Count > 0)
                {
                    int id = (int)dgvMisAct.SelectedRows[0].Cells[0].Value;
                    fInfoActividad info = new fInfoActividad(alumno, new Actividad(id));
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

       
    }
}
