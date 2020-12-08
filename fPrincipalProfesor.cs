using MySql.Data.MySqlClient;
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
    public partial class fPrincipalProfesor : Form
    {
        public fPrincipalProfesor()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bAccederAlForo_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForo foro = new PantallaPrincipalForo();
            this.Visible = false;
            foro.ShowDialog();
            this.Visible = true;
        }

        private void bEventosInscritos_Click(object sender, EventArgs e)
        {
            
        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil();
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = true;
        }
    }
}
