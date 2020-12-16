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
    public partial class fCrearActividadAdmin : Form
    {
        private string nombreActividad, descrip, lugar, fechaIni, fechaFin, horaIni, horaFin, aforo, colaborador;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (usuarioCreador.RolUsuario.RolName.Equals("ALUMNO"))
            {
                fPantallaPrincipalAlumno inicio = new fPantallaPrincipalAlumno(usuarioCreador);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
            else if (usuarioCreador.RolUsuario.RolName.Equals("PROFESOR"))
            {
                fPrincipalProfesor inicio = new fPrincipalProfesor(usuarioCreador);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
            else if (usuarioCreador.RolUsuario.RolName.Equals("ENTIDAD"))
            {
                fPrincipalOng inicio = new fPrincipalOng(usuarioCreador);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
            else if (usuarioCreador.RolUsuario.RolName.Equals("ADMIN"))
            {
                fPantallaAdmin inicio = new fPantallaAdmin(usuarioCreador);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
        }

        private int aforoActividad;
        private Actividad actividad;
        
        private Usuario usuarioCreador;
        private void bGuardarCambiosAct_Click(object sender, EventArgs e)
        {
            nombreActividad = tNombreAct.Text;
            descrip = tDescripcionAct.Text;
            lugar = tLugarAct.Text;
            fechaIni = dFechaIniAct.Value.ToString();
            fechaFin = dFechaFinAct.Value.ToString();
            horaIni = dHoraIniAct.Value.ToString("HH:mm");
            horaFin = dHoraFinAct.Value.ToString("HH:mm");

            int comparacion = dFechaFinAct.Value.CompareTo(dHoraIniAct.Value);

            aforo = tAforoAct.Text.ToString(); //Pasar el aforo a entero 
            aforoActividad = int.Parse(aforo);
            colaborador = lColaboradores.SelectedItem.ToString();
            if (nombreActividad.Equals("") || descrip.Equals("") || lugar.Equals("") || fechaIni.Equals("") || fechaFin.Equals("") ||
                horaIni.Equals("") || horaFin.Equals("") || colaborador.Equals("") || aforoActividad < 0)
            {
                MessageBox.Show("Faltan campos obligatorios por rellenar.");
            }
            else
            {
                if (comparacion >= 0)
                {

                    actividad = new Actividad(usuarioCreador, nombreActividad, descrip, fechaIni, fechaFin, horaIni, horaFin, lugar, aforoActividad);
                }
                else
                {
                    MessageBox.Show("Las fechas no son correctas.");
                }

            }
        }

        
        public fCrearActividadAdmin(Usuario user)
        {
            InitializeComponent();
            usuarioCreador = user;
        }

        private void fCrearActividadAdmin_Load(object sender, EventArgs e)
        {
            bGuardarCambiosAct.Enabled = true;
            foreach (Usuario u in Usuario.listaColaboradores()) lColaboradores.Items.Add(u.CorreoUsuario);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
