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
    public partial class PantallaBorrarCurso : Form
    {
        public PantallaBorrarCurso()
        {
            InitializeComponent();
            bBasura.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bBasura_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("¿Quieres borrar el curso definitivamente?","Borrar Curso",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PantallaBorrarCurso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Curso' Puede moverla o quitarla según sea necesario.
            this.cursoTableAdapter.Fill(this.apsgrupo02DataSet.Curso);

        }

        private void dgvMisCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
