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
        private string nombreDelCurso, descrip, lugar, fechaIni, fechaFin, horaIni, horaFin, aforo, profesor;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int aforoDelCurso;

        
        private Boolean onlineOPresencial;
        private Curso cursoCreado;
        private Usuario usuarioCreador;
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
            bAniadirArchivosCurso.Enabled = true;
            bGuardarCambiosCurso.Enabled = true;
            

        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bGuardarCambiosCurso_Click(object sender, EventArgs e)
        {
            nombreDelCurso = tNombreCurso.Text;
            descrip = tDescripcionCurso.Text;
            lugar = tLugarCurso.Text;
            fechaIni = dFechaIniCurso.Value.ToString();
            fechaFin = dFechaFinCurso.Value.ToString();
            horaIni = dHoraIniCurso.Value.ToString("HH:mm");
            horaFin = dHoraFinCurso.Value.ToString("HH:mm");
            int comparacion = dFechaFinCurso.Value.CompareTo(dHoraIniCurso.Value);
            
            aforo = tAforoCurso.Text.ToString(); //Pasar el aforo a entero 
            aforoDelCurso = int.Parse(aforo);
            Usuario profesor = null;
            if(!usuarioCreador.RolUsuario.RolName.Equals("ADMIN"))
            {
                profesor = usuarioCreador;
            } else
            {
                profesor = new Usuario((string)listProfesor.SelectedItem);
            }
            
            onlineOPresencial = rOnline.Checked;
            if (nombreDelCurso.Equals("") || descrip.Equals("") || lugar.Equals("") || fechaIni.Equals("") || fechaFin.Equals("") || 
                horaIni.Equals("") || horaFin.Equals("") || profesor.CorreoUsuario.Equals("") || aforoDelCurso < 0)
            {
                MessageBox.Show("Faltan campos obligatorios por rellenar.");
            } else
            {
                if(comparacion >= 0)
                {
                    cursoCreado = new Curso(profesor, nombreDelCurso, descrip, fechaIni,
                        fechaFin, horaIni, horaFin, lugar, aforoDelCurso, onlineOPresencial);
                } else
                {
                    MessageBox.Show("Las fechas no son correctas.");
                }
                
            }
        }
        
    }
}
