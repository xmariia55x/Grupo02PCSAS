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
        private Usuario seleccionado;

        public PantallaListaUsuarios(Curso curso, Usuario user)
        {
            this.curso = curso;
            this.user = user;
            InitializeComponent();
            
        }

        public void PantallaListaUsuarios_Load(object sender, EventArgs e)
        {
            lRol.Text = user.RolUsuario.RolName;
            lNombreUser.Text = user.NombreUsuario;

            lNombreCurso.Text = curso.CursoNombre;
            lNombreProfesorCurso.Text = curso.CursoProfesor.NombreUsuario;
            cargaLista();
        }

        private void cargaLista()
        {
            lbUsuarios.Items.Clear();
            foreach (Usuario u in CursosRealizados.listaUsuarios(curso.CursoID)) lbUsuarios.Items.Add(u.NombreUsuario + "-" + u.CorreoUsuario);
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
                fPantallaAdminFinal inicio = new fPantallaAdminFinal(user);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bDelUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado != null)
                {
                    if (MessageBox.Show("¿Quieres expulsar al usuario " + seleccionado.NombreUsuario + " del curso?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CursosRealizados c = new CursosRealizados(curso.CursoID, seleccionado.CorreoUsuario);
                        c.BorrarCursoRealizado();
                        cargaLista();
                    }
                }
                else
                {
                    throw new Exception("No hay ningun curso seleccionado");
                }

                //para que no se vuelva a seleccionar el mismo
                seleccionado = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void lbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUsuarios.SelectedItems.Count > 0)
            {
                string aux = (string)lbUsuarios.SelectedItem;
                string[] cadena = aux.Split('-');
                seleccionado = new Usuario(cadena[1]);
            }
        }
    }
}
