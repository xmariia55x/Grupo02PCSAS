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
    public partial class fStartAplicacion : Form
    {
        public fStartAplicacion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fRegistro registro = new fRegistro();
            this.Visible = false;
            registro.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             fInicioSesion inicio = new fInicioSesion();
            this.Visible = false;
            inicio.ShowDialog();
            this.Visible = true;
        }

        private void bAlumno_Click(object sender, EventArgs e)
        {
            fPantallaPrincipalAlumno alumno = new fPantallaPrincipalAlumno(null); //A -> Cambiar null
            this.Visible = false;
            alumno.ShowDialog();
            this.Visible = true;
        }

        private void bProfesor_Click(object sender, EventArgs e)
        {
            fPrincipalProfesor profesor = new fPrincipalProfesor(null);
            this.Visible = false;
            profesor.ShowDialog();
            this.Visible = true;
        }

        private void bEntidad_Click(object sender, EventArgs e)
        {
           
        }

        private void bAdmin_Click(object sender, EventArgs e)
        {
            fPantallaAdmin admin = new fPantallaAdmin(null); //A -> Hay que cambiarlo :/
            this.Visible = false;
            admin.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
