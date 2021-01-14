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
    public partial class fInicioInvitado : Form
    {
        private Usuario user;
        private Curso cursoSeleccionado;
        private Actividad actividadSeleccionada;
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        public fInicioInvitado()
        {
            InitializeComponent();
            user = null;
            lError.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        

        private List<Curso> sacarFechasCurso()
        {
            string sentencia = "SELECT idCurso, fechaInicioCurso, horaInicioCurso FROM Curso";
            List<Curso> lista = new List<Curso>();
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach(Object[] obj in bd.Select(sentencia))
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
        private void fInicioInvitado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet2.Curso' Puede moverla o quitarla según sea necesario.
            //this.cursoTableAdapter1.Fill(this.apsgrupo02DataSet2.Curso);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Actividad' Puede moverla o quitarla según sea necesario.
            //this.actividadTableAdapter.Fill(this.apsgrupo02DataSet.Actividad);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Curso' Puede moverla o quitarla según sea necesario.
            //this.cursoTableAdapter.Fill(this.apsgrupo02DataSet.Curso);
            //Console.WriteLine(sacarFechasCurso());
            //Console.WriteLine(sacarFechasActividad());

            //DGVCURSOS
            dgvCursos.DataSource = sacarFechasCurso();
            //Columnas no visibles
            dgvCursos.Columns[0].Visible = false;
            dgvCursos.Columns[1].Visible = false;
            dgvCursos.Columns[3].Visible = false;
            dgvCursos.Columns[6].Visible = false;
            dgvCursos.Columns[7].Visible = false;

            //Columnas visibles
            dgvCursos.Columns[2].HeaderText = "Nombre";
            dgvCursos.Columns[4].HeaderText = "Fecha inicio";
            dgvCursos.Columns[5].HeaderText = "Fecha fin";
            dgvCursos.Columns[8].HeaderText = "Lugar";
            dgvCursos.Columns[9].HeaderText = "Aforo";
            dgvCursos.Columns[10].HeaderText = "Online";

            dgvCursos.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgvCursos.Columns[4].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCursos.Columns[5].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCursos.Columns[8].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCursos.Columns[9].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCursos.Columns[10].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;

            //DGVACTIVIDADES
            dgvActividades.DataSource = sacarFechasActividad();

            dgvActividades.Columns[0].Visible = false;
            dgvActividades.Columns[1].Visible = false;
            dgvActividades.Columns[3].Visible = false;
            dgvActividades.Columns[6].Visible = false;
            dgvActividades.Columns[7].Visible = false;

            //Columnas visibles
            dgvActividades.Columns[2].HeaderText = "Nombre";
            dgvActividades.Columns[4].HeaderText = "Fecha inicio";
            dgvActividades.Columns[5].HeaderText = "Fecha fin";
            dgvActividades.Columns[8].HeaderText = "Lugar";
            dgvActividades.Columns[9].HeaderText = "Aforo";

            dgvActividades.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgvActividades.Columns[4].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvActividades.Columns[5].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvActividades.Columns[8].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvActividades.Columns[9].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bRegistrate_Click(object sender, EventArgs e)
        {
            fRegistro registro = new fRegistro();
            this.Visible = false;
            registro.ShowDialog();
            this.Visible = true;
        }

        private void bIniciarSesión_Click(object sender, EventArgs e)
        {
            try
            {
                user = new Usuario(tbUsuario.Text);

                if (user == null)
                {
                    throw new Error();
                }
                else
                {
                    if (user.ContraseniaUsuario != tbPassword.Text)
                    {
                        throw new Error();
                    }
                    else
                    {
                        switch (user.RolUsuario.RolName)
                        {
                            case "ALUMNO":
                                fPantallaPrincipalAlumno alumno = new fPantallaPrincipalAlumno(user);  // añadir el user
                                alumno.Show();
                                this.Close();
                                break;

                            case "ADMIN":
                                fPantallaAdminFinal admin = new fPantallaAdminFinal(user);  // añadir el user
                                this.Visible = false;
                                admin.ShowDialog();
                                this.Visible = true;
                                break;

                            case "ENTIDAD":
                                fPrincipalOng ong = new fPrincipalOng(user);  // añadir el user
                                this.Visible = false;
                                ong.ShowDialog();
                                this.Visible = true;
                                break;

                            case "PROFESOR":
                                fPrincipalProfesor profesor = new fPrincipalProfesor(user);  // añadir el user
                                this.Visible = false;
                                profesor.ShowDialog();
                                this.Visible = true;
                                break;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Usuario o contraseña incorrecta");
            }
        } 

        private void dgvCursos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCursos.SelectedRows.Count > 0)
                {
                    int id = (int)dgvCursos.SelectedRows[0].Cells[0].Value;
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


        private void dgvActividades_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvActividades.SelectedRows.Count > 0)
                {
                    int id = (int)dgvActividades.SelectedRows[0].Cells[0].Value;
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
                    fInfoCurso info = new fInfoCurso(null, cursoSeleccionado);
                    this.Visible = false;
                    info.ShowDialog();
                    this.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }

        private void bInfoActividad_Click(object sender, EventArgs e)
        {
            try
            {
                if (actividadSeleccionada == null)
                {
                    throw new Exception("No hay ninguna actividad seleccionada");
                } else
                {
                    fInfoActividad info = new fInfoActividad(null, actividadSeleccionada);
                    this.Visible = false;
                    info.ShowDialog();
                    this.Visible = true;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void lRecuperarContrasenia_Click(object sender, EventArgs e) {
            if (tbUsuario.Text.Equals(""))
            {
                MessageBox.Show("ERROR: NO SE HA ESCRITO NADA EN EL CAMPO USUARIO");
            }
            else
            {

                if (!Usuario.emailEnBD(tbUsuario.Text))
                {
                    MessageBox.Show("ERROR: CORREO ELECTRÓNICO NO VÁLIDO");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Se enviará un correo con tu nueva contraseña a la dirección " + tbUsuario.Text + " ¿Estás seguro?", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        user = new Usuario(tbUsuario.Text);
                        string recordatorio = Correo.recuperarContrasenia(user);
                        Correo.sendEmail(recordatorio, "Nueva contraseña", user);

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else

                    }
                }

            }
        }
        private void bNoticias_Click(object sender, EventArgs e)
        {
            
            fNoticia noticias = new fNoticia(null);
            this.Visible = false;
            noticias.ShowDialog();
            this.Visible = true;
        }
    }
}
