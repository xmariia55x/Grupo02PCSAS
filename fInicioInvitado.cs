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

        private void fInicioInvitado_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            //nombreCurso 'Nombre', fechaInicioCurso, fechaFinCurso, aforoCurso
            MySqlCommand comandoC = new MySqlCommand("SELECT * FROM Curso WHERE fechaInicioCurso >= '" + DateTime.Now.ToString("dd / MM / yyyy") + "'", conexion);
            MySqlCommand comandoA = new MySqlCommand("SELECT * FROM Actividad WHERE fechaInicioActividad >= '" + DateTime.Now.ToString("dd / MM / yyyy") + "'", conexion);
           
            MySqlDataAdapter adaptadorC = new MySqlDataAdapter();
            MySqlDataAdapter adaptadorA = new MySqlDataAdapter();
            
            adaptadorC.SelectCommand = comandoC;
            adaptadorA.SelectCommand = comandoA;
           
            DataTable tablaC = new DataTable();
            DataTable tablaA = new DataTable();
          
            adaptadorC.Fill(tablaC);
            adaptadorA.Fill(tablaA);

            dgvCursos.DataSource = tablaC;
            dgvActividades.DataSource = tablaA;
            
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
                                this.Visible = false;
                                alumno.ShowDialog();
                                this.Visible = true;
                                break;

                            case "ADMIN":
                                fPantallaAdmin admin = new fPantallaAdmin(user);  // añadir el user
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
                fPantallaAdmin inicio = new fPantallaAdmin(user);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
