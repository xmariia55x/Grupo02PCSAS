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
    public partial class fSatisfaccionActividad : Form
    {
        Usuario user;
        Actividad act;
        public fSatisfaccionActividad(Usuario u, Actividad a)
        {
            this.user = u;
            this.act = a;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void fSatisfaccionActividad_Load(object sender, EventArgs e)
        {
            lRol.Text = user.RolUsuario.RolName;
            lNombreUser.Text = user.NombreUsuario;
            lAct.Text = act.NombreActividad;

            //Hemos comprobado que está inscrito previamente
            lInscrito.Text = "Inscrito";
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            int satisfaccion = (int)nSatisfaccion.Value;
            int lugar = (int)nLugar.Value;
            int horario = (int)nHora.Value;
            int organizadores = (int)nOrganizadores.Value;
            bool repetir = cRepetir.Checked;
            string comentario = tComentarios.Text;

            new ValoracionActividad(user, act, satisfaccion, lugar, horario, organizadores, repetir, comentario);
            MessageBox.Show("Se ha enviado la valoracion con éxito");

            cerrar();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cerrar();
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

        private void cerrar()
        {
            fInfoActividad f = new fInfoActividad(user, act);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
