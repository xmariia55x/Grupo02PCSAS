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
    public partial class fCrearCursoAdmin : Form
    {
        private string nombreDelCurso, descrip, lugar, fechaIni, fechaFin, horaIni, horaFin, aforo;
        private int aforoDelCurso;


        private Boolean onlineOPresencial;
        private Curso cursoCreado;
        private Usuario usuarioCreador;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        
        private void cerrar()
        {
            if (usuarioCreador.RolUsuario.RolName.Equals("PROFESOR"))
            {
                fPrincipalProfesor inicio = new fPrincipalProfesor(usuarioCreador);
                this.Hide();
                inicio.ShowDialog();
                this.Close();

            }
            else if (usuarioCreador.RolUsuario.RolName.Equals("ADMIN"))
            {
                fPantallaAdminFinal inicio = new fPantallaAdminFinal(usuarioCreador);
                this.Hide();
                inicio.ShowDialog();
                
            }
        }
        
        
        public fCrearCursoAdmin(Usuario user)
        {
            InitializeComponent();
            usuarioCreador = user;
        }

        

        private void fCrearCursoAdmin_Load(object sender, EventArgs e)
        {
            if (!usuarioCreador.RolUsuario.RolName.Equals("ADMIN"))
            {
                panel1.Visible = false;

            }
            else
            {
                foreach (Usuario u in Usuario.listaProfesores()) listProfesor.Items.Add(u.CorreoUsuario);
            }
            
            bGuardarCambiosCurso.Enabled = true;
            

        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bGuardarCambiosCurso_Click(object sender, EventArgs e)
        {
            try
            {
                nombreDelCurso = tNombreCurso.Text;
                descrip = tDescripcionCurso.Text;
                lugar = tLugarCurso.Text;
                fechaIni = dFechaIniCurso.Value.ToString();
                fechaFin = dFechaFinCurso.Value.ToString();
                horaIni = dHoraIniCurso.Value.ToString("HH:mm");
                horaFin = dHoraFinCurso.Value.ToString("HH:mm");
                int comparacion = dFechaFinCurso.Value.CompareTo(dHoraIniCurso.Value);


                Usuario profesor = null;
                if (!usuarioCreador.RolUsuario.RolName.Equals("ADMIN"))
                {
                    profesor = usuarioCreador;
                }
                else
                {
                    profesor = new Usuario((string)listProfesor.SelectedItem);
                }

                onlineOPresencial = rOnline.Checked;
                if (nombreDelCurso.Equals("") || descrip.Equals("") || lugar.Equals("") || fechaIni.Equals("") || fechaFin.Equals("") ||
                    horaIni.Equals("") || horaFin.Equals("") || profesor.CorreoUsuario.Equals("") || tAforoCurso.Text == null || tAforoCurso.Text.Equals(""))
                {
                    throw new Exception("Faltan campos obligatorios por rellenar.");
                }
                else
                {
                    if (comparacion >= 0)
                    {
                        aforo = tAforoCurso.Text.ToString(); //Pasar el aforo a entero 
                        aforoDelCurso = int.Parse(aforo);
                        cursoCreado = new Curso(profesor, nombreDelCurso, descrip, fechaIni,
                            fechaFin, horaIni, horaFin, lugar, aforoDelCurso, onlineOPresencial);
                        MessageBox.Show("Curso creado correctamente");
                        cerrar();
                    }
                    else
                    {
                        throw new Exception("Las fechas no son correctas.");
                    }

                }
            } catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            
     
        }
        
    }
}
