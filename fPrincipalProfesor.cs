using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo02PCSAS
{
    public partial class fPrincipalProfesor : Form
    {
        Usuario profesor;
        Curso seleccionado;
        Actividad seleccionada;
        public fPrincipalProfesor(Usuario u)
        {
            InitializeComponent();
            profesor = u;
            seleccionado = null;
            seleccionada = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bAccederAlForo_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForo foro = new PantallaPrincipalForo(profesor);
            this.Hide();
            foro.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(profesor); 
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = true;
        }

        private void fPrincipalProfesor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet1.Actividad' Puede moverla o quitarla según sea necesario.
            //this.actividadTableAdapter.Fill(this.apsgrupo02DataSet1.Actividad);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Curso' Puede moverla o quitarla según sea necesario.
            //this.cursoTableAdapter.Fill(this.apsgrupo02DataSet.Curso);
            lRol.Text = profesor.RolUsuario.RolName;
            lNombreUser.Text = profesor.NombreUsuario;
            cargaGrid();
            cargaActividadesFecha(DateTime.Now.ToShortDateString());
            cargaCursosFecha(DateTime.Now.ToShortTimeString());
        }

        private void cargaGrid()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Curso WHERE profesorCurso = '" + profesor.CorreoUsuario + "'", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
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
            if(tabla.Rows.Count == 0)
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
            if(tabla.Rows.Count == 0)
            {
                lNoActividades.Visible = true;
                lNoActividades.Text = "No hay actividades disponibles para el día seleccionado";
                dgvActividades.Visible = false;
                bInformacionActividad.Visible = false;
                bInscribirActividad.Visible = false;
            } else
            {
                dgvActividades.Visible = true;
                dgvActividades.DataSource = tabla;
                lNoActividades.Visible = false;
                bInformacionActividad.Visible = true;
                bInscribirActividad.Visible = true;
            }
            
        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            fCrearCursoAdmin crearCurso = new fCrearCursoAdmin(profesor);
            this.Hide();
            crearCurso.ShowDialog();
            this.Close();
            cargaGrid();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int idSel = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                seleccionado = new Curso(idSel);
            }
        }

        private void bModCur_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado != null)
                {
                    fModificarCursos modicurso = new fModificarCursos(profesor, seleccionado);
                    this.Hide();
                    modicurso.ShowDialog();
                    this.Close();
                    cargaGrid();
                }
                else
                {
                    throw new Exception("No hay ningun curso seleccionado");
                }

                //para que no se vuelva a seleccionar el mismo
                seleccionado = null;
            } catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            
        }

        private void bDelCur_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado != null)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Desea borrar el curso?", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.seleccionado.BorrarCurso();
                        cargaGrid();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else

                    }
                }
                else
                {
                    throw new Exception("No hay ningun curso seleccionado");
                }

                //para que no se vuelva a seleccionar el mismo
                seleccionado = null;
            } catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bInfCur_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado != null)
                {
                    if(profesor != null)
                    {
                        fInfoCursoProfesor infocurso = new fInfoCursoProfesor(profesor, seleccionado);
                        this.Hide();
                        infocurso.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    throw new Exception("No hay ningun curso seleccionado");
                }

                //para que no se vuelva a seleccionar el mismo
                seleccionado = null;
            } catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            
        }
       

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(profesor);
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = true;
        }

        private void bNotProf_Click(object sender, EventArgs e)
        {
            fNoticia noticias = new fNoticia(profesor);
            this.Hide();
            noticias.ShowDialog();
            this.Close();
        }

        private void bListaParticipantes_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado != null)
                {
                    PantallaListaUsuarios f = new PantallaListaUsuarios(seleccionado, profesor);
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    throw new Exception("No hay ningun curso seleccionado");
                }

                //para que no se vuelva a seleccionar el mismo
                seleccionado = null;
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

        private void bInformacionCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if(seleccionado == null)
                {
                    throw new Exception("Ningún curso seleccionado");
                } else
                {
                    fInfoCurso infoCurso = new fInfoCurso(profesor, seleccionado);
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

        private void dgvCursos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCursos.SelectedRows.Count > 0)
            {
                int idSel = (int)dgvCursos.SelectedRows[0].Cells[0].Value;
                seleccionado = new Curso(idSel);
                
            }
        }
        
        

        private void dgvActividades_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvActividades.SelectedRows.Count > 0)
            {
                int idSel = (int)dgvActividades.SelectedRows[0].Cells[0].Value;
                seleccionada = new Actividad(idSel);
            }
        }

        private void bInformacionActividad_Click(object sender, EventArgs e)
        {
            try
            {
                if(seleccionada == null)
                {
                    throw new Exception("Ninguna actividad seleccionada");
                } else
                {
                    if (profesor.RolUsuario.RolName.Equals("PROFESOR"))
                    {
                        fInfoActividad infoActividad = new fInfoActividad(profesor, seleccionada);
                        this.Hide();
                        infoActividad.ShowDialog();
                        this.Close();
                    }
                }
                
            } catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
        private int calcularPlazasDisponiblesCurso()
        {
            List<Usuario> lista = CursosRealizados.listaUsuarios(seleccionado.CursoID);
            List<Usuario> filtro = new List<Usuario>();
            foreach (Usuario u in lista)
                if (u.RolUsuario.RolName.Equals("ALUMNO") || u.RolUsuario.RolName.Equals("PROFESOR"))
                    filtro.Add(u);
            int plazas = seleccionado.CursoAforo - filtro.Count;

            return plazas;
        }
        private bool inscritoCurso(Usuario alumno)
        {
            bool ok = false;
            List<Curso> lista = CursosRealizados.listaCursos(alumno.CorreoUsuario);
            foreach (Curso c in lista)
                if (c.CursoID == seleccionado.CursoID)
                {
                    ok = true;
                    break;
                }
            return ok;
        }
        private void bInscribirCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado == null)
                {
                    throw new Exception("Ningún curso seleccionado");
                }
                else
                {
                    int plazasDispo = calcularPlazasDisponiblesCurso();

                    if (plazasDispo > 0)
                    {
                        if (!inscritoCurso(profesor) && !creadorCurso(profesor))
                        {
                            string[] horaSplit = seleccionado.CursoHoraInicio.Split(':');
                            string[] fechaSplit = seleccionado.CursoFechaInicio.Split('/');
                            DateTime dt = new DateTime(int.Parse(fechaSplit[2]), int.Parse(fechaSplit[1]), int.Parse(fechaSplit[0]), int.Parse(horaSplit[0]), int.Parse(horaSplit[1]), 0);
                            DateTime dt2 = DateTime.Now;
                            if (dt.CompareTo(dt2) <= 0)
                            {
                                throw new Exception("Este curso ya ha finalizado.");
                            }
                            else
                            {
                                CursosRealizados c = new CursosRealizados(seleccionado.CursoID, profesor.CorreoUsuario);
                                MessageBox.Show("Se ha inscrito con éxito");
                                //cargaGrid();
                            }
                        }
                        else
                        {
                            throw new Error("Ya estabas inscrito en ese curso o bien eres el creador");
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

        private bool creadorCurso(Usuario usuario)
        {
            return seleccionado.CursoProfesor.Equals(usuario);
        }
        private int calcularPlazasDisponiblesActividad()
        {
            List<Usuario> lista = ActividadesRealizadas.listaUsuarios(seleccionada.IdActividad);
            List<Usuario> filtro = new List<Usuario>();
            foreach (Usuario u in lista)
                if (u.RolUsuario.RolName.Equals("ALUMNO") || u.RolUsuario.RolName.Equals("PROFESOR"))
                    filtro.Add(u);
            int plazas = seleccionada.AforoActividad - filtro.Count;

            return plazas;
        }
        private void bInscribirActividad_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionada == null)
                {
                    throw new Exception("No hay ninguna actividad seleccionada");
                }
                else
                {
                    int plazasDispo = calcularPlazasDisponiblesActividad();

                    if (plazasDispo > 0)
                    {
                        if (!inscritoActividad(profesor))
                        {
                            string[] horaSplit = seleccionada.HoraInicioActividad.Split(':');
                            string[] fechaSplit = seleccionada.FechaInicioActividad.Split('/');
                            DateTime dt = new DateTime(int.Parse(fechaSplit[2]), int.Parse(fechaSplit[1]), int.Parse(fechaSplit[0]), int.Parse(horaSplit[0]), int.Parse(horaSplit[1]), 0);
                            DateTime dt2 = DateTime.Now;
                            if (dt.CompareTo(dt2) <= 0)
                            {
                                throw new Exception("Esta actividad ya ha finalizado.");
                            }
                            else
                            {
                                ActividadesRealizadas a = new ActividadesRealizadas(seleccionada.IdActividad, profesor.CorreoUsuario);
                                MessageBox.Show("Se ha inscrito con éxito");
                                //cargaGrid();
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

        private bool inscritoActividad(Usuario profesor)
        {
            bool ok = false;
            List<Actividad> lista = ActividadesRealizadas.listaActividades(profesor.CorreoUsuario);
            foreach (Actividad c in lista)
                if (c.IdActividad == seleccionada.IdActividad)
                {
                    ok = true;
                    break;
                }
            return ok;
        }
    }
}
