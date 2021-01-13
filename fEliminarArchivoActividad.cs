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
    public partial class fEliminarArchivoActividad : Form
    {
        Usuario usuario;
        Actividad actividad;
        public fEliminarArchivoActividad(Usuario u, Actividad a)
        {
            this.usuario = u;
            this.actividad = a;
            InitializeComponent();
        }

        private void fEliminarArchivoActividad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet1.MaterialActividad' Puede moverla o quitarla según sea necesario.
            //this.materialActividadTableAdapter.Fill(this.apsgrupo02DataSet1.MaterialActividad);
            lRol.Text = usuario.RolUsuario.RolName;
            lNombreUser.Text = usuario.NombreUsuario;
            lNombreCurso.Text = actividad.NombreActividad;

            cargaGrid();
        }

        private void cargaGrid()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM MaterialActividad WHERE idActividad = '" + actividad.IdActividad + "'", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
    }
}
