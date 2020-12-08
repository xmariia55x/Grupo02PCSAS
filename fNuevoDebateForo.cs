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
    public partial class fNuevoDebateForo : Form
    {
        public fNuevoDebateForo()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bCancelarDebate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fNuevoDebateForo_Load(object sender, EventArgs e)
        {

        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
