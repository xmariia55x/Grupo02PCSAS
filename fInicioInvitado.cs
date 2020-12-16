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
            lError.Visible = false;
            user = new Usuario(tbUsuario.Text);
            
            if(user == null)
            {
                lError.Text = "Usuario no registrado";
                lError.Visible = true;
            }
            else
            {
                if(user.ContraseniaUsuario != tbPassword.Text)
                {
                    lError.Text = "Password incorrecta";
                    lError.Visible = true;
                }
                else
                {
                    switch (user.RolUsuario.RolName)
                    {
                        case "ALUMNO":
                            fPantallaPrincipalAlumno alumno = new fPantallaPrincipalAlumno(null);  // añadir el user
                            this.Visible = false;
                            alumno.ShowDialog();
                            this.Visible = true;
                            break;

                        case "ADMIN":
                            fPantallaAdmin admin = new fPantallaAdmin(null);  // añadir el user
                            this.Visible = false;
                            admin.ShowDialog();
                            this.Visible = true;
                            break;

                        case "ENTIDAD":
                            fPrincipalOng ong = new fPrincipalOng(null);  // añadir el user
                            this.Visible = false;
                            ong.ShowDialog();
                            this.Visible = true;
                            break;

                        case "PROFESOR":
                            fPrincipalProfesor profesor = new fPrincipalProfesor(null);  // añadir el user
                            this.Visible = false;
                            profesor.ShowDialog();
                            this.Visible = true;
                            break;

                    }
                }
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
            fInfoCurso info = new fInfoCurso(null, cursoSeleccionado);
            this.Visible = false;
            info.ShowDialog();
            this.Visible = true;
        }

        private void bInfoActividad_Click(object sender, EventArgs e)
        {
            fInfoActividad info = new fInfoActividad(null, actividadSeleccionada);
            this.Visible = false;
            info.ShowDialog();
            this.Visible = true;
        }
    }
}
