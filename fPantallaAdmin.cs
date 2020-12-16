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
        private Usuario admin;
        public fPantallaAdmin(Usuario u)
        {
            InitializeComponent();
            admin = u;
        }

        private void fPantallaAdmin_Load(object sender, EventArgs e)
        {
            lRol.Text = admin.RolUsuario.RolName;
            lNombre.Text = admin.NombreUsuario;
            this.usuarioTableAdapter.Fill(this.apsgrupo02DataSet.Usuario);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosp = new fDatosPerfil(admin);
            this.Visible = false;
            datosp.ShowDialog();
            this.Visible = true;
        }

        private void bCrearActividad_Click(object sender, EventArgs e)
        {
            fCrearActividadAdmin actividad = new fCrearActividadAdmin(null); //RECORDAR QUE HAY QUE CAMBIAR ESTO
            this.Visible = false;
            actividad.ShowDialog();
            this.Visible = true;
        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            fCrearCursoAdmin curso = new fCrearCursoAdmin(null);
            this.Visible = false;
            curso.ShowDialog();
            this.Visible = true;
        }

        private void fPantallaAdmin_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Usuario' Puede moverla o quitarla según sea necesario.

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
