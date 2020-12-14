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
    public partial class fPrincipalOng : Form
    {
        public fPrincipalOng()
        {
            InitializeComponent();
        }

        private void bAccederAlForo_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForo foro = new PantallaPrincipalForo();
            this.Visible = false;
            foro.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(null); //M -> HAY QUE CAMBIARLO!!!!
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = true;
        }

        private void fPrincipalOng_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Actividad' Puede moverla o quitarla según sea necesario.
            this.actividadTableAdapter.Fill(this.apsgrupo02DataSet.Actividad);

        }

        private void bEventos_Click(object sender, EventArgs e)
        {
            fPantallaPrincipalAlumno principal = new fPantallaPrincipalAlumno();
            this.Visible = false;
            principal.ShowDialog();
            this.Visible = true;
        }
    }
}
