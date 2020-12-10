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
            this.Close();
        }

        private void fNuevoDebateForo_Load(object sender, EventArgs e)
        {
            bEnviarDebate.Enabled = true;
            bCancelarDebate.Enabled = true;
            lNombreApellidosUsuario.Text = usuario.NombreUsuario;
            lRolUsuario.Text = usuario.RolUsuario.RolName;
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bEnviarDebate_Click(object sender, EventArgs e)
        {
            try
            {
                asunto = tAsuntoDebate.Text;
                mensaje = tMensajeDebate.Text;

                if (asunto.Equals("") || mensaje.Equals(""))
                {
                    MessageBox.Show("Faltan campos obligatorios por rellenar");
                }
                else if (!asunto.Equals("") && !mensaje.Equals(""))
                {
                    debateCreado = new Debate(usuario.NombreUsuario, asunto, mensaje, DateTime.Now.ToShortDateString());
                    debateCreado = null;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
        }
    }
}
