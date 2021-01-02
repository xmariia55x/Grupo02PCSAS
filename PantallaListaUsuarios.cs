using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Grupo02PCSAS
{
    public partial class PantallaListaUsuarios : Form
    {
        private Curso curso;
        private Usuario user;
        public PantallaListaUsuarios(Curso curso, Usuario user)
        {
            InitializeComponent();
            this.curso = curso;
            this.user = user;
        }

        public void PantallaListaUsuarios_Load(object sender, EventArgs e)
        {
          

            lNombreCurso.Text = curso.CursoNombre;
            lNombreProfesorCurso.Text = curso.CursoProfesor.NombreUsuario;
            lbUsuarios.Items.Clear();
            foreach (Usuario u in CursosRealizados.listaUsuarios(curso.CursoID)) lbUsuarios.Items.Add(u.NombreUsuario + " - " + u.CorreoUsuario);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
