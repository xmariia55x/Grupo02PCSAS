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
            this.Hide();
            datos.ShowDialog();
            this.Close();
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
            }
            else
            {
                lCurso.Visible = false;
                lActividad.Visible = true;
                dgvValoracionCursos.Visible = false;
                dgvValoracionesActividad.Visible = true;
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
