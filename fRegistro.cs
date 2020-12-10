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
            String nombre = null, correo = null, contrasenia = null, niu = null, cif = null, rol = null;
            Usuario user;

            try
            {
                if (seleccionado == 0)  //Alumno
                {
                    nombre = tNombreAlumno.Text;
                    correo = tCorreoAlumno.Text;
                    cif = null;
                    niu = null;
                    rol = "ALUMNO";
                    if (tPwdAlumno.Equals(tConfirmarAlumno))
                    {
                        contrasenia = tPwdAlumno.Text;
                    }
                    else
                    {
                        throw new Error("Las contraseñas no coinciden");
                    }
                }
                else if (seleccionado == 1)
                {
                    nombre = tNombreProfesor.Text;
                    correo = tCorreoProfesor.Text;
                    niu = tNiuProfesor.Text;
                    cif = null;
                    rol = "PROFESOR";
                    if (tPwdProfesor.Equals(tConfirmarPwd))
                    {
                        contrasenia = tPwdProfesor.Text;
                    }
                    else
                    {
                        throw new Error("Las contraseñas no coinciden");
                    }
                }
                else if (seleccionado == 2)
                {
                    nombre = tNombreOng.Text;
                    correo = tCorreoOng.Text;
                    cif = tCifOng.Text;
                    niu = null;
                    rol = "ONG";
                    if (tPwdOng.Equals(tConfirmarOng))
                    {
                        contrasenia = tPwdOng.Text;
                    }
                    else
                    {
                        throw new Error("Las contraseñas no coinciden");
                    }
                }

                user = new Usuario(correo, nombre, contrasenia, cif, niu, new Rol(rol));
                MessageBox.Show("Usuario creado con éxito");
                this.Close();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
