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
            this.Close();
        }

        private void fNuevoDebateForo_Load(object sender, EventArgs e)
        {
            bEnviarDebate.Enabled = true;
            bCancelarDebate.Enabled = true;
            lNombreUser.Text = usuario.NombreUsuario;
            lRol.Text = usuario.RolUsuario.RolName;
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil ventana = new fDatosPerfil(usuario);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            fDatosPerfil ventana = new fDatosPerfil(usuario);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (user.RolUsuario.RolName.Equals("ALUMNO"))
            {
                fPantallaPrincipalAlumno inicio = new fPantallaPrincipalAlumno(user);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
            else if (user.RolUsuario.RolName.Equals("PROFESOR"))
            {
                fPrincipalProfesor inicio = new fPrincipalProfesor(user);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
            else if (user.RolUsuario.RolName.Equals("ENTIDAD"))
            {
                fPrincipalOng inicio = new fPrincipalOng(user);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
            else if (user.RolUsuario.RolName.Equals("ADMIN"))
            {
                fPantallaAdmin inicio = new fPantallaAdmin(user);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
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
                    
                    debateCreado = new Debate(usuario.CorreoUsuario, asunto, mensaje, DateTime.Now.ToShortDateString());
                    debateCreado = null;
                        
                    
                }
            } catch (MySqlException excp)
            {
                //Ya habia un debate creado por el mismo usuario con igual asunto y hay que lanzar una advertencia
                MessageBox.Show("Ya hay un debate creado con el mismo asunto, cambie el asunto, por favor.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
        }
    }
}
