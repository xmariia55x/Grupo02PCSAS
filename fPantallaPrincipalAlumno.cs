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
    public partial class fPantallaPrincipalAlumno : Form
    {
        public fPantallaPrincipalAlumno()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fPantallaPrincipalAlumno_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lMiPerfil_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(null); //M -> HAY QUE CAMBIARLO!!!!
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(null); //M -> HAY QUE CAMBIARLO!!!!
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForo foro = new PantallaPrincipalForo(null);
            this.Visible = false;
            foro.ShowDialog();
            this.Visible = true;
        }
    }
}
