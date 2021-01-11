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
    public partial class fInfoNoticia : Form
    {
        Noticias noticia;
        Usuario user;

        public fInfoNoticia(Usuario u, Noticias n)
        {
            this.noticia = n;
            this.user = u;
            InitializeComponent();
        }

        private void fInfoNoticia_Load(object sender, EventArgs e)
        {
            if (user != null)
            {
                lNombreUser.Text = user.NombreUsuario;
                lRol.Text = user.RolUsuario.RolName;
            }
            else
            {
                lNombreUser.Text = "Invitado";
                lRol.Text = "INVITADO";
            }

            lTitNoticia.Text = noticia.Titulo;
            lAutor.Text = noticia.Autor;
            lCuerpo.Text = noticia.Cuerpo;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (user != null)
                {
                    fDatosPerfil datosPerfil = new fDatosPerfil(user);
                    this.Visible = false;
                    datosPerfil.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    throw new Exception("El usuario no está registrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                if (user != null)
                {
                    fDatosPerfil datosPerfil = new fDatosPerfil(user);
                    this.Visible = false;
                    datosPerfil.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    throw new Exception("El usuario no está registrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
