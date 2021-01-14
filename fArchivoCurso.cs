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
    public partial class fArchivoCurso : Form
    {
        Usuario user;
        Curso curso;
        public fArchivoCurso(Usuario u, Curso c)
        {
            InitializeComponent();
            this.user = u;
            this.curso = c;
            
        }

        private void bSubirArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNombre.Text.Equals("") || tbEnlace.Text.Equals(""))
                {
                    throw new Exception("Campos vacios");
                }
                else
                {
                    MaterialCurso mc = new MaterialCurso(tbEnlace.Text,this.curso,tbNombre.Text);
                    MessageBox.Show("Material aniadido con exito");
                    fModificarCursos modificarCurso = new fModificarCursos(user, curso);
                    this.Visible = false;
                    modificarCurso.ShowDialog();
                    this.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void lNombreCurso_Click(object sender, EventArgs e)
        {
            
        }

        private void fArchivoCurso_Load(object sender, EventArgs e)
        {
            lNombreCurso.Text = curso.CursoNombre;
            lNombreUser.Text = user.NombreUsuario;
            lRol.Text = user.RolUsuario.RolName;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vuelva a la pagina principal para acceder a sus datos ");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(user);
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fModificarCursos modificarCurso = new fModificarCursos(user, curso);
            this.Visible = false;
            modificarCurso.ShowDialog();
            this.Visible = true;
        }
    }
}
