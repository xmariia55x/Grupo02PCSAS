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
    public partial class fNoticia : Form
    {
        Usuario user;
        Noticias noticiaSeleccionada;
        public fNoticia(Usuario user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void fNoticia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet1.Noticias' Puede moverla o quitarla según sea necesario.
            cargaGrid();
            if(user != null)
            {
                lNombreUser.Text = user.NombreUsuario;
                lRol.Text = user.RolUsuario.RolName;
            } else
            {
                lNombreUser.Text = "Invitado";
                lRol.Text = "INVITADO";
            }
        }

        private void cargaGrid()
        {
            this.noticiasTableAdapter.Fill(this.apsgrupo02DataSet1.Noticias);
        }


        private void dgvNoticias_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvNoticias.SelectedRows.Count > 0)
            {
                string titSel = (string)dgvNoticias.SelectedRows[0].Cells[0].Value;
                string autSel = (string)dgvNoticias.SelectedRows[0].Cells[1].Value;
                noticiaSeleccionada = new Noticias(titSel,autSel);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (user != null)
                {
                    fDatosPerfil datosPerfil = new fDatosPerfil(user);
                    this.Visible = false;
                    datosPerfil.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    throw new Exception("El usuario no está registrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
  

        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                if (user != null)
                {
                    fDatosPerfil datosPerfil = new fDatosPerfil(user);
                    this.Visible = false;
                    datosPerfil.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    throw new Exception("El usuario no está registrado");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bInfNot_Click(object sender, EventArgs e)
        {
            try
            {
                if(noticiaSeleccionada != null)
                {
                    fInfoNoticia infoNoticia = new fInfoNoticia(user,noticiaSeleccionada);
                    this.Hide();
                    infoNoticia.ShowDialog();
                    this.Close();
                } else
                {
                    throw new Exception("No hay ninguna noticia seleccionada");
                }

            } catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                fInicioInvitado inv = new fInicioInvitado();
                this.Hide();
                inv.ShowDialog();
                this.Close();
            }
            else if (user.RolUsuario.RolName.Equals("ENTIDAD"))
            {
                fPrincipalOng ong = new fPrincipalOng(user);
                this.Hide();
                ong.ShowDialog();
                this.Close();
            }
            else if (user.RolUsuario.RolName.Equals("PROFESOR"))
            {
                fPrincipalProfesor profe = new fPrincipalProfesor(user);
                this.Hide();
                profe.ShowDialog();
                this.Close();
            }
            else if (user.RolUsuario.RolName.Equals("ALUMNO"))
            {
                fPantallaPrincipalAlumno alu = new fPantallaPrincipalAlumno(user);
                this.Hide();
                alu.ShowDialog();
                this.Close();
            }
            else
            {
                fPantallaAdminFinal admin = new fPantallaAdminFinal(user);
                this.Hide();
                admin.ShowDialog();
                this.Close();
            }
        }

        private void bDelNot_Click(object sender, EventArgs e)
        {
            try
            {
                if(user == null)
                {
                    throw new Exception("Funcion solo para administradores");
                }
                else if(user.RolUsuario.Admin)
                {
                    if(noticiaSeleccionada != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Desea borrar la noticia?", "ALERTA", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.noticiaSeleccionada.borrarNoticia();
                            cargaGrid();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else

                        }
                    } else
                    {
                        throw new Exception("No hay ninguna noticia seleccionada");
                    }

                    noticiaSeleccionada = null;

                } else
                {
                    throw new Exception("Funcion solo para administradores");
                }
            } catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bAddNoticia_Click(object sender, EventArgs e)
        {
            try
            {
                if(user == null)
                {
                    throw new Exception("Funcion solo para administradores");
                }
                else if(user.RolUsuario.Admin)
                {
                    fCrearNoticia crearNoticia = new fCrearNoticia(user);
                    this.Hide();
                    crearNoticia.ShowDialog();
                    this.Close();
                    cargaGrid();

                } else
                {
                    throw new Exception("Funcion solo para administradores");
                }
            } catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
