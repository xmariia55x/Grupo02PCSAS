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
{//hola
    public partial class fInicioSesion : Form
    {
        public fInicioSesion()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fPantallaPrincipalAlumno alumno = new fPantallaPrincipalAlumno(null); //A -> Cambiar el null
            this.Visible = false;
            alumno.ShowDialog();
            this.Close();

        }
    }
}
