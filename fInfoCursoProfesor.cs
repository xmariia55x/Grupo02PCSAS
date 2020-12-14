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
    public partial class fInfoCursoProfesor : Form
    {
        Usuario user;
        Curso curso;

        public fInfoCursoProfesor()
        {
            InitializeComponent();
            InitializeComponent();
            mostrarUsuario();
            mostrarActividad();
            comprobarInscrito();
            calcularPlazasDisponibles();
        }


        private void calcularPlazasDisponibles()
        {
            List<Usuario> lista = CursosRealizados.listaUsuarios(curso.CursoID);
            lPlazasDisp.Text = (curso.CursoAforo - lista.Count).ToString();
        }

        private void comprobarInscrito()
        {
            bool inscrito = false;
            foreach (Usuario u in ActividadesRealizadas.listaUsuarios(curso.CursoID))
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

        private void mostrarUsuario()
        {
            lNombreUser.Text = user.NombreUsuario;
            lRol.Text = user.RolUsuario.RolName;
        }

        private void mostrarActividad()
        {
            lNombreCurso.Text = curso.CursoNombre;
            lDescripcion.Text = curso.CursoDescripcion;
            lProfesor.Text = curso.CursoProfesor.NombreUsuario;
            lPlazasTotales.Text = curso.CursoAforo.ToString();
            lFechaInicio.Text = curso.CursoFechaInicio;
            lFechaFin.Text = curso.CursoFechaFin;
            lHoraInicio.Text = curso.CursoHoraInicio;
            lHoraFin.Text = curso.CursoHoraFin;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }
    }
}
