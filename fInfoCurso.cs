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
    public partial class fInfoCurso : Form
    {
        Usuario user;
        Curso curso;

        public fInfoCurso(Usuario user, Curso curso)
        {
            this.user = user;
            this.curso = curso;

            InitializeComponent();
        }

        private void fInfoCurso_Load(object sender, EventArgs e)
        {
            mostrarUsuario();
            mostrarCurso();
            if (user.Equals(curso.CursoProfesor))
            {
                label9.Visible = false;
                lInscrito.Visible = false;
            }
            else
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

        private void mostrarUsuario()
        {
            lNombreUser.Text = user.NombreUsuario;
            lRol.Text = user.RolUsuario.RolName;
        }

        private void mostrarCurso()
        {
            lNombreCurso.Text = curso.CursoNombre;
            lDescripcion.Text = curso.CursoDescripcion;
            lNombreProf.Text = curso.CursoProfesor.NombreUsuario;
            lPlazasTotales.Text = curso.CursoAforo.ToString();
            lFechaInicio.Text = curso.CursoFechaInicio;
            lFechaFin.Text = curso.CursoFechaFin;
            lHoraInicio.Text = curso.CursoHoraInicio;
            lHoraF.Text = curso.CursoHoraFin;
            lLugar.Text = curso.CursoOnline ? "Online" : curso.CursoLugar;
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
