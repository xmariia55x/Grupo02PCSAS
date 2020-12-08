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
    public partial class fInicioAplicacion : Form
    {
        public fInicioAplicacion()
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
    }
}
