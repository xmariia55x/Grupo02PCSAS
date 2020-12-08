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
    public partial class fRegistro : Form
    {
        public fRegistro()
        {
            InitializeComponent();
            pAlumno.Visible = false;
            pProfesor.Visible = false;
            pOng.Visible = false;
        }

        private void fRegistro_Load(object sender, EventArgs e)
        {
            pAlumno.Visible = false;
            pProfesor.Visible = false;
            pOng.Visible = false;
        }

        private void bAlumno_Click(object sender, EventArgs e)
        {
            bAlumno.BackColor = SystemColors.ActiveCaption;
            bProfesor.BackColor = SystemColors.ButtonHighlight;
            bOng.BackColor = SystemColors.ButtonHighlight;

            pAlumno.Visible = true;
            pProfesor.Visible = false;
            pOng.Visible = false;
        }

        private void bProfesor_Click(object sender, EventArgs e)
        {
            bAlumno.BackColor = SystemColors.ButtonHighlight;
            bProfesor.BackColor = SystemColors.ActiveCaption;
            bOng.BackColor = SystemColors.ButtonHighlight;

            pProfesor.Visible = true;
            pAlumno.Visible = false;
            pOng.Visible = false;
        }

        private void bOng_Click(object sender, EventArgs e)
        {
            bOng.BackColor = SystemColors.ActiveCaption;
            bAlumno.BackColor = SystemColors.ButtonHighlight;
            bProfesor.BackColor = SystemColors.ButtonHighlight;

            pOng.Visible = true;
            pAlumno.Visible = false;
            pProfesor.Visible = false;
        }
    }
}
