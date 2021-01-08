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
    public partial class fPantallaAdminFinal : Form
    {
        int seleccionado = 0;
        object elementoSeleccionado = null;
        Usuario user;
        public fPantallaAdminFinal(Usuario user)
        {
            this.user = user;
            InitializeComponent();
        }

        
        private void bActividades_Click(object sender, EventArgs e)
        {
            seleccionado = 0;
            elementoSeleccionado = null;

            bActividades.BackColor = SystemColors.ActiveCaption;
            bCurso.BackColor = SystemColors.ButtonHighlight;
            bUsuarios.BackColor = SystemColors.ButtonHighlight;
            bForos.BackColor = SystemColors.ButtonHighlight;

            dgvActividades.Visible = true;
            dgvCursos.Visible = false;
            dgvUsuarios.Visible = false;
            dgvForos.Visible = false;
            bCrear.Visible = true;
        }

        private void bCursos_Click(object sender, EventArgs e)
        {
            seleccionado = 1;
            elementoSeleccionado = null;

            bActividades.BackColor = SystemColors.ButtonHighlight;
            bCurso.BackColor = SystemColors.ActiveCaption;
            bUsuarios.BackColor = SystemColors.ButtonHighlight;
            bForos.BackColor = SystemColors.ButtonHighlight;

            dgvActividades.Visible = false;
            dgvCursos.Visible = true;
            dgvUsuarios.Visible = false;
            dgvForos.Visible = false; 
            bCrear.Visible = true;

        }

        private void bUsuarios_Click(object sender, EventArgs e)
        {
            seleccionado = 2;
            elementoSeleccionado = null;

            bUsuarios.BackColor = SystemColors.ActiveCaption;
            bActividades.BackColor = SystemColors.ButtonHighlight;
            bCurso.BackColor = SystemColors.ButtonHighlight;
            bForos.BackColor = SystemColors.ButtonHighlight;

            dgvActividades.Visible = false;
            dgvCursos.Visible = false;
            dgvUsuarios.Visible = true;
            dgvForos.Visible = false;
            bCrear.Visible = false;
        }

        private void bForos_Click(object sender, EventArgs e)
        {
            seleccionado = 3;
            elementoSeleccionado = null;

            bActividades.BackColor = SystemColors.ButtonHighlight;
            bCurso.BackColor = SystemColors.ButtonHighlight;
            bUsuarios.BackColor = SystemColors.ButtonHighlight;
            bForos.BackColor = SystemColors.ActiveCaption;

            dgvActividades.Visible = false;
            dgvCursos.Visible = false;
            dgvUsuarios.Visible = false;
            dgvForos.Visible = true;
            bCrear.Visible = true;
        }

        private void fpantallaAdminFinal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet1.Debate' Puede moverla o quitarla según sea necesario.
            this.debateTableAdapter1.Fill(this.apsgrupo02DataSet1.Debate);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Debate' Puede moverla o quitarla según sea necesario.
            this.debateTableAdapter.Fill(this.apsgrupo02DataSet.Debate);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.apsgrupo02DataSet.Usuario);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Curso' Puede moverla o quitarla según sea necesario.
            this.cursoTableAdapter.Fill(this.apsgrupo02DataSet.Curso);
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet.Actividad' Puede moverla o quitarla según sea necesario.
            this.actividadTableAdapter.Fill(this.apsgrupo02DataSet.Actividad);


            dgvActividades.Visible = true;
            dgvCursos.Visible = false;
            dgvUsuarios.Visible = false;
            dgvForos.Visible = false;
            bCrear.Visible = true;
        }

        private void bNoticias_Click(object sender, EventArgs e)
        {

        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            if(elementoSeleccionado is Actividad)
            {
                fCrearActividadAdmin acti = new fCrearActividadAdmin(user);
                this.Visible = false;
                acti.ShowDialog();
                this.actividadTableAdapter.Fill(this.apsgrupo02DataSet.Actividad);
                this.Visible = true;
            }else if (elementoSeleccionado is Curso)
            {
                fCrearCursoAdmin curso = new fCrearCursoAdmin(user);
                this.Visible = false;
                curso.ShowDialog();
                this.cursoTableAdapter.Fill(this.apsgrupo02DataSet.Curso);
                this.Visible = true;
            }
            else if (elementoSeleccionado is Debate)
            {
                fNuevoDebateForo foro = new fNuevoDebateForo(user);
                this.Visible = false;
                foro.ShowDialog();
                this.debateTableAdapter.Fill(this.apsgrupo02DataSet.Debate);
                this.Visible = true;
            }
        }


        private void dgvActividades_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvActividades.SelectedRows.Count > 0)
            {
                try
                {
                    int u = (int)dgvActividades.SelectedRows[0].Cells[0].Value;

                    elementoSeleccionado = new Actividad(u);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }

        private void dgvCursos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCursos.SelectedRows.Count > 0)
            {
                try
                {
                    int u = (int)dgvCursos.SelectedRows[0].Cells[0].Value;

                    elementoSeleccionado = new Curso(u);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                try
                {
                    String u = (String)dgvUsuarios.SelectedRows[0].Cells[0].Value;

                    elementoSeleccionado = new Usuario(u);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }
        private void dgvForos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvForos.SelectedRows.Count > 0)
            {
                try
                {
                    int id = (int)dgvForos.SelectedRows[0].Cells[0].Value;
                    elementoSeleccionado = new Debate(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }

        private void bBorrar_Click(object sender, EventArgs e)


        {
            if (elementoSeleccionado != null)
            {
                if (MessageBox.Show("¿Quieres borrar el elemento definitivamente?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                  
                        if (elementoSeleccionado is Actividad)
                        {
                            Actividad a = (Actividad)elementoSeleccionado;
                            a.BorrarActividad();
                            this.actividadTableAdapter.Fill(this.apsgrupo02DataSet.Actividad);
                        }
                        else if (elementoSeleccionado is Curso)
                        {
                            Curso c = (Curso)elementoSeleccionado;
                            c.BorrarCurso();
                            this.cursoTableAdapter.Fill(this.apsgrupo02DataSet.Curso);
                        }
                        else if (elementoSeleccionado is Usuario)
                        {
                            Usuario u = (Usuario)elementoSeleccionado;
                            u.BorrarUsuario();
                            this.usuarioTableAdapter.Fill(this.apsgrupo02DataSet.Usuario);
                        }
                        else if (elementoSeleccionado is Debate)
                        {
                            Debate d = (Debate)elementoSeleccionado;
                            d.BorrarDebate();
                            this.debateTableAdapter.Fill(this.apsgrupo02DataSet.Debate);
                        }
                    
                }
            }
            else
            {
                MessageBox.Show("ERROR: Ningun elemento seleccionado");
            }

        }


       
    }
}
