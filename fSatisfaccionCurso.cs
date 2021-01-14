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
    public partial class fSatisfaccionCurso : Form
    {
        Usuario user;
        Curso curso;

        public fSatisfaccionCurso(Usuario user, Curso curso)
        {
            this.user = user;
            this.curso = curso;
            InitializeComponent();
        }

        private void fSatisfaccionCurso_Load(object sender, EventArgs e)
        {
            lRol.Text = user.RolUsuario.RolName;
            lNombreUser.Text = user.NombreUsuario;
            lNombreCurso.Text = curso.CursoNombre;
            comprobarInscrito();
        }

        private void comprobarInscrito()
        {
            bool inscrito = false;
            foreach (Usuario u in CursosRealizados.listaUsuarios(curso.CursoID))
            {
                if (user.Equals(u)) inscrito = true;
            }

            if (inscrito)
            {
                lInscrito.Text = "Inscrito";
            }
            else
            {
                lInscrito.Text = "No inscrito";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            int satisfaccion = (int)nSatisfaccion.Value;
            int lugar = (int)nLugar.Value;
            int horario = (int)nHora.Value;
            int organizadores = (int)nOrganizadores.Value;
            bool repetir = cRepetir.Checked;
            string comentario = tComentarios.Text;

            new ValoracionCurso(user, curso, satisfaccion, lugar, horario, organizadores, repetir, comentario);
            MessageBox.Show("Se ha enviado la valoracion con éxito");

            cerrar();
        }

        private void cerrar()
        {
            fInfoCurso f = new fInfoCurso(user, curso);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cerrar();
        }
    }
}
