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
   
    public partial class PantallaPrincipalForo : Form
    {
        private Usuario user;
        private Debate debateSeleccionado;
        public PantallaPrincipalForo(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void PantallaBorrarCurso_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("Select asuntoDebate as `Asunto`,id as `ID` from Debate where creadorDebate ='" + user.CorreoUsuario + "' ORDER BY fechaPublicacion DESC", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvMisDebates.DataSource = tabla;

            //where fechaPublicacion <'" + DateTime.Now.AddDays(-10)
            MySqlCommand comando2 = new MySqlCommand("Select creadorDebate as `Creador`, asuntoDebate as `Asunto`, mensajeDebate as `Mensaje`, fechaPublicacion as `Fecha publicacion` from Debate ORDER BY fechaPublicacion DESC", conexion);
            MySqlDataAdapter adaptador2 = new MySqlDataAdapter();
            adaptador2.SelectCommand = comando2;
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dgvDebatesRecientes.DataSource = tabla2;

            lNombreApellidos.Text = user.NombreUsuario;
            lRol.Text = user.RolUsuario.RolName;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bAniadirDebate_Click(object sender, EventArgs e)
        {
            fNuevoDebateForo nuevoDebate = new fNuevoDebateForo(user); 
            this.Visible = false;
            nuevoDebate.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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

        private void bInfoDebate_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (debateSeleccionado != null)
                {
                    fInfoForo f = new fInfoForo(user, debateSeleccionado);
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    throw new Exception("No se ha seleccionado ningun debate");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }    
            
            
        }

        private void dgvDebatesRecientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDebatesRecientes.SelectedRows.Count > 0)
            {
                int id = (int)dgvDebatesRecientes.SelectedRows[0].Cells[1].Value;
                debateSeleccionado = new Debate(id);

            }
            else
            {
                debateSeleccionado = null;
            }
        }
    }
}
