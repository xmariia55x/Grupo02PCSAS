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
    public partial class fSatisfaccionCurso : Form
    {
        Usuario user;
        Curso curso;

        public fSatisfaccionCurso(Usuario user, Curso curso)
        {
            lRol.Text = user.RolUsuario.RolName;
            lNombreUser.Text = user.NombreUsuario;

            InitializeComponent();
        }

        private void fSatisfaccionCurso_Load(object sender, EventArgs e)
        {
            lRol.Text = user.RolUsuario.RolName;
            lNombreUser.Text = user.NombreUsuario;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }
    }
}
