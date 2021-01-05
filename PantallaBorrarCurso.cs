﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Grupo02PCSAS
{
    public partial class PantallaBorrarCurso : Form
    {
        private Usuario user;
        Curso seleccionado = null;
        public PantallaBorrarCurso(Usuario user)
        {
            InitializeComponent();
            this.user = user;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bBasura_Click(object sender, EventArgs e)
        {
            if(seleccionado != null)
            {
                if (MessageBox.Show("¿Quieres borrar el curso definitivamente?", "Borrar Curso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    seleccionado.BorrarCurso();

                    MySqlConnection conexion = new MySqlConnection();
                    conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
                    conexion.Open();
                    MySqlCommand comando = new MySqlCommand("Select * from Curso where profesorCurso = '" + user.CorreoUsuario + "'", conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter();
                    adaptador.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvMisCursos.DataSource = tabla;
                }
            } else
            {
                throw new Exception("No hay ningun curso seleccionado");
            }
           
        }


        private void PantallaBorrarCurso_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("Select * from Curso where profesorCurso = '" + user.CorreoUsuario + "'", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvMisCursos.DataSource = tabla;

            lRol.Text = user.RolUsuario.RolName;
            lNombreApellidos.Text = user.NombreUsuario;
        }

        private void dgvMisCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            fCrearCursoAdmin curso = new fCrearCursoAdmin(user);
            this.Visible = false;
            curso.ShowDialog();
            this.Visible = true;
        }

        private void bAccesoForo_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForo foro = new PantallaPrincipalForo(user);
            this.Visible = false;
            foro.ShowDialog();
            this.Visible = true;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMisCursos.SelectedRows.Count > 0)
            {
                try
                {
                   int u = (int)dgvMisCursos.SelectedRows[0].Cells[0].Value;

                     seleccionado = new Curso(u);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
    }
}
