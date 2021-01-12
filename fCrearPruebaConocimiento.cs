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
    public partial class fCrearPruebaConocimiento : Form
    {
        private Usuario usuario;
        private Curso curso;
        public fCrearPruebaConocimiento(Usuario u, Curso c)
        {
            this.usuario = u;
            this.curso = c;
            InitializeComponent();
        }

        private void fCrearPruebaConocimiento_Load(object sender, EventArgs e)
        {
            lNombreUser.Text = usuario.NombreUsuario;
            lRolUser.Text = usuario.RolUsuario.RolName;
            lNombreCurso.Text = curso.CursoNombre;
        }
    }
}
