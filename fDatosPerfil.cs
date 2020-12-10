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
            if (user.RolUsuario.Equals("ALUMNO"))
            {

				panelAlumno.Visible = true;
				panelProfesor.Visible = false;
				panelProfesor.Enabled = false;
				panelEntidad.Visible = false;
				panelEntidad.Enabled = false;

			}else if (user.RolUsuario.Equals("PROFESOR"))
            {
				panelAlumno.Visible = false;
				panelAlumno.Enabled = false;
				panelProfesor.Visible = true;
				panelEntidad.Visible = false;
				panelEntidad.Enabled = false;

            }else if (user.RolUsuario.Equals("ENTIDAD"))
            {
				panelAlumno.Visible = false;
				panelAlumno.Enabled = false;
				panelEntidad.Visible = true;
				panelProfesor.Visible = false;
				panelProfesor.Enabled = false;

			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void bBorrarPerfil_Click(object sender, EventArgs e)
		{
			MessageBox.Show("ALERTA: ¿ESTÁ SEGURO QUE DESEA BORRAR EL PERFIL?");
		}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bEditarPerfil_Click(object sender, EventArgs e)
        {
			fEditarPerfil edicion = new fEditarPerfil();
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
