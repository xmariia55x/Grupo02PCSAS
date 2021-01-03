﻿using System;
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

        public fInfoCursoProfesor(Usuario user, Curso curso)
        {
            this.user = user;
            this.curso = curso;
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
