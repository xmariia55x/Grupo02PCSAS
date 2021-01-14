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
    public partial class fInfoMensaje : Form
    {
        private Usuario user;
        private Mensaje mensaje;
        public fInfoMensaje(Usuario u , Mensaje m)
        {
            InitializeComponent();
            user = u;
            mensaje = m;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            fBandejaMensajes bandejaMensajes = new fBandejaMensajes(user);
            this.Visible = false;
            bandejaMensajes.ShowDialog();
            this.Visible = true;
        }

        private void fInfoMensaje_Load(object sender, EventArgs e)
        {
            lEmisor.Text = this.mensaje.Emisor;
            lAsunto.Text = this.mensaje.Asunto;
            lFecha.Text = this.mensaje.Fecha;
            tMensaje.Text = this.mensaje.Cuerpo;
            lNombre.Text = this.user.NombreUsuario;
            lRol.Text = this.user.RolUsuario.RolName;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }
    }
}
