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
    public partial class fNuevoDebateForo : Form
    {
        private Debate debateCreado;
        private Usuario usuario;
        private string asunto, mensaje;
        public fNuevoDebateForo(Usuario usuarioActual)
        {
            usuario = usuarioActual;
            
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bCancelarDebate_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForo f = new PantallaPrincipalForo(this.usuario);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void fNuevoDebateForo_Load(object sender, EventArgs e)
        {
            bEnviarDebate.Enabled = true;
            
            lNombreUser.Text = usuario.NombreUsuario;
            lRol.Text = usuario.RolUsuario.RolName;
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil f = new fDatosPerfil(usuario);
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

            fDatosPerfil f = new fDatosPerfil(usuario);
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForo f = new PantallaPrincipalForo(this.usuario);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bEnviarDebate_Click(object sender, EventArgs e)
        {
            try
            {
                asunto = tAsuntoDebate.Text;
                mensaje = tMensajeDebate.Text;

                if (asunto.Equals("") || mensaje.Equals(""))
                {
                    MessageBox.Show("Faltan campos obligatorios por rellenar.");
                }
                else if (!asunto.Equals("") && !mensaje.Equals(""))
                {
                    
                    debateCreado = new Debate(usuario.CorreoUsuario, asunto, mensaje, DateTime.Now.ToString("dd/MM/yyyy"));
                    Respuesta r = new Respuesta (debateCreado, usuario, mensaje, DateTime.Now.ToString("dd/MM/yyyy"));
                    MessageBox.Show("Debate creado con éxito");
                    debateCreado = null;
                    PantallaPrincipalForo f = new PantallaPrincipalForo(this.usuario);
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
        }
    }
}
