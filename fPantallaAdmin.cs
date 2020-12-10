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
    public partial class fPantallaAdmin : Form
    {
        public fPantallaAdmin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosp = new fDatosPerfil(null); //M -> ESTO HAY QUE CAMBIARLO!!!!!
            this.Visible = false;
            datosp.ShowDialog();
            this.Visible = true;
        }

        private void bCrearActividad_Click(object sender, EventArgs e)
        {
            fCrearActividadAdmin actividad = new fCrearActividadAdmin();
            this.Visible = false;
            actividad.ShowDialog();
            this.Visible = true;
        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            fCrearCursoAdmin curso = new fCrearCursoAdmin();
            this.Visible = false;
            curso.ShowDialog();
            this.Visible = true;
        }
    }
}
