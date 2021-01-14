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
    public partial class fArchivoActividad : Form
    {
        Usuario user;
        Actividad act;
        public fArchivoActividad(Usuario user, Actividad act)
        {
            this.user = user;
            this.act = act;
            InitializeComponent();
        }

        private void fArchivoActividad_Load(object sender, EventArgs e)
        {
            lNombreUser.Text = user.NombreUsuario;
            lRol.Text = user.RolUsuario.RolName;
            lNombreAct.Text = act.NombreActividad;
            lNombreCreador.Text = act.UsuarioCreador.NombreUsuario;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(user);
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = true;
        }

     

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void cerrar()
        {
            fModificarActividad modificarActividad = new fModificarActividad(user, act);
            this.Hide();
            modificarActividad.ShowDialog();
            this.Close();
        }

        private void bSubirArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbNombre.Text.Equals("") || tbEnlace.Text.Equals(""))
                {
                    throw new Exception("Campos vacios");
                } else
                {
                    MaterialActividad ma = new MaterialActividad(tbNombre.Text,tbEnlace.Text,act);
                    MessageBox.Show("Material aniadido con exito");
                    cerrar();
                }
            } catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void lNombreAct_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
