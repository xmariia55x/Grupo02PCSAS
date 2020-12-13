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
    public partial class fRegistro : Form
    {
        //0 - alumno ; 1 - profesor; 2 - ong
        private int seleccionado;

        public fRegistro()
        {
            InitializeComponent();
            pAlumno.Visible = true;
            pProfesor.Visible = false;
            pOng.Visible = false;
            seleccionado = 0;
        }

        private void fRegistro_Load(object sender, EventArgs e)
        {
            pAlumno.Visible = true;
            pProfesor.Visible = false;
            pOng.Visible = false;
        }

        private void bAlumno_Click(object sender, EventArgs e)
        {
            seleccionado = 0;

            bAlumno.BackColor = SystemColors.ActiveCaption;
            bProfesor.BackColor = SystemColors.ButtonHighlight;
            bOng.BackColor = SystemColors.ButtonHighlight;

            pAlumno.Visible = true;
            pProfesor.Visible = false;
            pOng.Visible = false;
        }

        private void bProfesor_Click(object sender, EventArgs e)
        {
            seleccionado = 1;

            bAlumno.BackColor = SystemColors.ButtonHighlight;
            bProfesor.BackColor = SystemColors.ActiveCaption;
            bOng.BackColor = SystemColors.ButtonHighlight;

            pProfesor.Visible = true;
            pAlumno.Visible = false;
            pOng.Visible = false;
        }

        private void bOng_Click(object sender, EventArgs e)
        {
            seleccionado = 2;

            bOng.BackColor = SystemColors.ActiveCaption;
            bAlumno.BackColor = SystemColors.ButtonHighlight;
            bProfesor.BackColor = SystemColors.ButtonHighlight;

            pOng.Visible = true;
            pAlumno.Visible = false;
            pProfesor.Visible = false;
        }

        private void pAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado == 0)  //Alumno
                {
                    String nombreA = null, correoA = null, contraseniaA = null, niuA = null, cifA = null, rolA = null;
                    nombreA = tNombreAlumno.Text;
                    correoA = tCorreoAlumno.Text;
                    rolA = "ALUMNO";
                    if (tPwdAlumno.Text.Equals(tConfirmarAlumno.Text))
                    {
                        contraseniaA = tPwdAlumno.Text;
                    }
                    else
                    {
                        throw new Error("Las contraseñas no coinciden");
                    }
                    Usuario user = new Usuario(correoA, nombreA, contraseniaA, cifA, niuA, new Rol(rolA));
                    MessageBox.Show("Usuario con rol Alumno creado con éxito");
                    this.Close();
                }
                else if (seleccionado == 1) //Profesor
                {
                    String nombreP = null, correoP = null, contraseniaP = null, niuP = null, cifP = null, rolP = null;
                    nombreP = tNombreProfesor.Text;
                    correoP = tCorreoProfesor.Text;
                    niuP = tNiuProfesor.Text;
                    rolP = "PROFESOR";
                    if (tPwdProfesor.Text.Equals(tConfirmarPwd.Text))
                    {
                        contraseniaP = tPwdProfesor.Text;
                    }
                    else
                    {
                        throw new Error("Las contraseñas no coinciden");
                    }
                    Usuario user = new Usuario(correoP, nombreP, contraseniaP, cifP, niuP, new Rol(rolP));
                    MessageBox.Show("Usuario con rol Profesor creado con éxito");
                    this.Close();
                }
                else if (seleccionado == 2) //ONG
                {
                    String nombreO = null, correoO = null, contraseniaO = null, niuO = null, cifO = null, rolO = null;
                    nombreO = tNombreOng.Text;
                    correoO = tCorreoOng.Text;
                    cifO = tCifOng.Text;
                    rolO = "ONG";
                    if (tPwdOng.Text.Equals(tConfirmarOng.Text))
                    {
                        contraseniaO = tPwdOng.Text;
                    }
                    else
                    {
                        throw new Error("Las contraseñas no coinciden");
                    }
                    Usuario user = new Usuario(correoO, nombreO, contraseniaO, cifO, niuO, new Rol(rolO));
                    MessageBox.Show("Usuario con rol Profesor creado con éxito");
                    this.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
