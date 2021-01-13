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
    public partial class fRedactarMensaje : Form
    {
        private Usuario user;
        public fRedactarMensaje(Usuario u)
        {
            InitializeComponent();
            user = u;
        }

        private void fRedactarMensaje_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet1.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.apsgrupo02DataSet1.Usuario);
            lNombreUser.Text = user.NombreUsuario;
            lRol.Text = user.RolUsuario.RolName;



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bEnviarMensaje_Click(object sender, EventArgs e)
        {
            Mensaje m = new Mensaje(this.user.CorreoUsuario, tUsuario.Text,  0, tAsunto.Text, tCuerpo.Text,DateTime.Now.ToString("dd/MM/yyyy"));
            fBandejaMensajes f = new fBandejaMensajes(user);
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string correo = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
                tUsuario.Text = correo;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            fBandejaMensajes f = new fBandejaMensajes(user);
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            fDatosPerfil f = new fDatosPerfil(user);
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil f = new fDatosPerfil(user);
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }
    }
}
