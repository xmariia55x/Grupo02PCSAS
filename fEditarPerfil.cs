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
	public partial class fEditarPerfil : Form
	{
        private Usuario user;
		public fEditarPerfil(Usuario user)
		{
			InitializeComponent();
            this.user = user;
		}
        private void fEditarPerfil_Load(object sender, EventArgs e)
        {
			lRol.Text = user.RolUsuario.RolName;
			lNombre.Text = user.NombreUsuario;
			if (user.RolUsuario.RolName.Equals("ALUMNO"))
			{
				
				panelAlumno.Visible = true;
				panelProfesor.Visible = false;
				
				panelEntidad.Visible = false;
				

				

			}
			else if (user.RolUsuario.RolName.Equals("PROFESOR"))
			{
				panelAlumno.Visible = false;
				
				panelProfesor.Visible = true;
				panelEntidad.Visible = false;
				
				

			}
			else if (user.RolUsuario.RolName.Equals("ENTIDAD"))
			{
				panelAlumno.Visible = false;
				panelEntidad.Visible = true;
				panelProfesor.Visible = false;
				

			}
		}
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void bGuardarCambios_Click(object sender, EventArgs e)
        {
            if (user.RolUsuario.RolName.Equals("ALUMNO"))
            {
                
					if(tEmailAlumno.Text != null ) user.CorreoUsuario = tEmailAlumno.Text;
					if (tNombreAlumno.Text != null) user.NombreUsuario = tNombreAlumno.Text;
					if(tPwdAlumno.Text.Equals(tConfPwdAlumno.Text))user.ContraseniaUsuario = tPwdAlumno.Text;
				
            }
			else if (user.RolUsuario.RolName.Equals("PROFESOR"))
			{
				
					if (tCorreoProfesor.Text != null) user.CorreoUsuario = tCorreoProfesor.Text;
					if (tNombreProfesor.Text != null) user.NombreUsuario = tNombreProfesor.Text;
					if (tPwdAlumno.Text.Equals(tConfPwdProfesor.Text)) user.ContraseniaUsuario = tPwdProfesor.Text;
					if (tNiuProfe.Text != null) user.NiuUsuario = tNiuProfe.Text;
			}else if (user.RolUsuario.RolName.Equals("ENTIDAD"))
			{
				
					if (tCorreoEntidad.Text != null) user.CorreoUsuario = tCorreoEntidad.Text;
					if (tNombreEntidad.Text != null) user.NombreUsuario = tNombreEntidad.Text;
					if (tPwdEntidad.Text.Equals(tConfPwdEntidad.Text)) user.ContraseniaUsuario = tPwdEntidad.Text;
					if (tCifEntidad.Text != null) user.CifUsuario = tCifEntidad.Text;
				
			}
		}

        private void lNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
