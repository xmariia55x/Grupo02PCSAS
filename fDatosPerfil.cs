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
	public partial class fDatosPerfil : Form
	{
		private Usuario user;
        public fDatosPerfil(Usuario user)
		{
			InitializeComponent();
			this.user = user;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void fDatosPerfil_Paint(object sender, PaintEventArgs e)
		{
			Graphics l = e.Graphics;
			Pen p = new Pen(Color.Black);
			//l.DrawLine(p, 400, 386, 400, 886);
		}

		private void fDatosPerfil_Load(object sender, EventArgs e)
		{
			lRol.Text = user.RolUsuario.RolName;
			lNombre.Text = user.NombreUsuario;
            if (user.RolUsuario.RolName.Equals("ALUMNO"))
            {

				panelAlumno.Visible = true;
				panelProfesor.Visible = false;
				panelProfesor.Enabled = false;
				panelEntidad.Visible = false;
				panelEntidad.Enabled = false;

				lNombreAlumno.Text = user.NombreUsuario;
				lEmailAlumno.Text = user.CorreoUsuario;
				lPwdAlumno.Text = user.ContraseniaUsuario;

			}else if (user.RolUsuario.RolName.Equals("PROFESOR"))
            {
				panelAlumno.Visible = false;
				panelAlumno.Enabled = false;
				panelProfesor.Visible = true;
				panelEntidad.Visible = false;
				panelEntidad.Enabled = false;

				lNombreProfe.Text = user.NombreUsuario;
				lEmailProfe.Text = user.CorreoUsuario;
				lNiuProfe.Text = user.NiuUsuario;
				lPwdProfe.Text = user.ContraseniaUsuario;

            }else if (user.RolUsuario.RolName.Equals("ENTIDAD"))
            {
				panelAlumno.Visible = false;
				panelAlumno.Enabled = false;
				panelEntidad.Visible = true;
				panelProfesor.Visible = false;
				panelProfesor.Enabled = false;

				lEmailEntidad.Text = this.user.CorreoUsuario;
				lCifEntidad.Text = this.user.CifUsuario;
				lPwdEntidad.Text = this.user.ContraseniaUsuario;

			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void bBorrarPerfil_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("¿Desea borrar el usuario?", "ALERTA", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				this.user.BorrarUsuario();
			}
			else if (dialogResult == DialogResult.No)
			{
				//do something else
				
			}
		}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bEditarPerfil_Click(object sender, EventArgs e)
        {
			fEditarPerfil edicion = new fEditarPerfil(this.user);
			this.Visible = false;
			edicion.ShowDialog();
			this.Visible = true;
		}

        private void bAtras_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
