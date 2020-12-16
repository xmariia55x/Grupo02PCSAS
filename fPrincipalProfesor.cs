using MySql.Data.MySqlClient;
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
    public partial class fPrincipalProfesor : Form
    {
        Usuario profesor;
        Curso seleccionado;
        public fPrincipalProfesor(Usuario u)
        {
            InitializeComponent();
            profesor = u;
            seleccionado = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bAccederAlForo_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForo foro = new PantallaPrincipalForo(profesor);
            this.Visible = false;
            foro.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(profesor); 
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = true;
        }

        private void fPrincipalProfesor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Curso' Puede moverla o quitarla según sea necesario.
            this.cursoTableAdapter.Fill(this.apsgrupo02DataSet.Curso);
            lRol.Text = profesor.RolUsuario.RolName;
            lNombreUser.Text = profesor.NombreUsuario;
            cargaGrid();
            
        }

        private void cargaGrid()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; user id=grupo02;database=apsgrupo02;Password=galvezgerena2021";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Curso WHERE profesorCurso = '" + profesor.CorreoUsuario + "'", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            fCrearCursoAdmin crearCurso = new fCrearCursoAdmin(profesor);
            this.Visible = false;
            crearCurso.ShowDialog();
            this.Visible = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int idSel = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                seleccionado = new Curso(idSel);
            }
        }

        private void bModCur_Click(object sender, EventArgs e)
        {
            if(seleccionado != null)
            {
                fModificarCursos modicurso = new fModificarCursos(profesor, seleccionado);
                this.Visible = false;
                modicurso.ShowDialog();
                this.Visible = true;
                cargaGrid();
            } else
            {
                throw new Exception("No hay ningun curso seleccionado");
            }

            //para que no se vuelva a seleccionar el mismo
            seleccionado = null;
        }

        private void bDelCur_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea borrar el curso?", "ALERTA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.seleccionado.BorrarCurso();
                    cargaGrid();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else

                }
            }
            else
            {
                throw new Exception("No hay ningun curso seleccionado");
            }

            //para que no se vuelva a seleccionar el mismo
            seleccionado = null;
        }

        private void bInfCur_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                fInfoCurso infocurso = new fInfoCurso(profesor, seleccionado);
                this.Visible = false;
                infocurso.ShowDialog();
                this.Visible = true;
            }
            else
            {
                throw new Exception("No hay ningun curso seleccionado");
            }

            //para que no se vuelva a seleccionar el mismo
            seleccionado = null;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(profesor);
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = true;
        }

        private void bEventosInscritos_Click(object sender, EventArgs e)
        {
            fPantallaPrincipalAlumno fAlum = new fPantallaPrincipalAlumno(profesor);
            this.Visible = false;
            fAlum.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(profesor);
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = true;
        }
    }
}
