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
    public partial class fRedactarRespuesta : Form
    {
        private Usuario user;
        private Debate debate;
        public fRedactarRespuesta(Usuario u, Debate d)
        {
            InitializeComponent();
            this.user = u;
            this.debate = d;
        }

        private void fRedactarRespuesta_Load(object sender, EventArgs e)
        {
            lNombreUser.Text = user.NombreUsuario;
            lRol.Text = user.RolUsuario.RolName;
            label3.Text = debate.ID.ToString();
        }

        private void bRespuesta_Click(object sender, EventArgs e)
        {
            try
            {
                Respuesta r = new Respuesta(this.debate, this.user, tRespuesta.Text, DateTime.Now.ToString("dd/MM/yyyy"));
                MessageBox.Show("Respuesta creada con éxito");
                fInfoForo f = new fInfoForo(user, debate);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil f = new fDatosPerfil(user);
            this.Visible = false; ;
            f.ShowDialog();
            this.Visible = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            fDatosPerfil f = new fDatosPerfil(user);
            this.Visible = false; ;
            f.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fInfoForo f = new fInfoForo(user,debate);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
