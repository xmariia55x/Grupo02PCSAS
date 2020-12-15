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
        public PantallaListaUsuarios( Curso curso)
        {
            InitializeComponent();
            this.curso = curso;
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
    }
}
