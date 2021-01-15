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
        private string nombreActividad, descrip, lugar, fechaIni, fechaFin, horaIni, horaFin, aforo;
        private int aforoActividad;

        
        private Actividad actividad;

        private void fCrearActividadAdmin_Load_1(object sender, EventArgs e)
        {

        }

        private Usuario usuarioCreador;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cerrar();
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void bGuardarCambiosAct_Click(object sender, EventArgs e)
        {
            try
            {
                nombreActividad = tNombreAct.Text;
                descrip = tDescripcionAct.Text;
                lugar = tLugarAct.Text;
                fechaIni = dFechaIniAct.Value.ToString();
                fechaFin = dFechaFinAct.Value.ToString();
                horaIni = dHoraIniAct.Value.ToString("HH:mm");
                horaFin = dHoraFinAct.Value.ToString("HH:mm");

                int comparacion = dFechaFinAct.Value.CompareTo(dFechaIniAct.Value);
                
                   

                    if (nombreActividad.Equals("") || descrip.Equals("") || lugar.Equals("") || fechaIni.Equals("") || fechaFin.Equals("") ||
                        horaIni.Equals("") || horaFin.Equals("") || tAforoAct.Text == null || tAforoAct.Text.Equals(""))
                    {
                        throw new Exception("Faltan campos obligatorios por rellenar.");
                    }
                    else
                    {
                        if (comparacion >= 0)
                        {
                            aforo = tAforoAct.Text.ToString(); //Pasar el aforo a entero 
                            aforoActividad = int.Parse(aforo);
                            actividad = new Actividad(usuarioCreador, nombreActividad, descrip, fechaIni, fechaFin, horaIni, horaFin, lugar, aforoActividad);
                            MessageBox.Show("Actividad creada correctamente");
                            cerrar();
                        }
                        else
                        {
                            MessageBox.Show("Las fechas no son correctas.");
                        }

                    }
                
                
            } catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message);
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
            //foreach (Usuario u in Usuario.listaColaboradores()) lColaboradores.Items.Add(u.CorreoUsuario);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            
        }

        private void cerrar()
        {
            if (usuarioCreador.RolUsuario.RolName.Equals("ENTIDAD"))
            {
                fPrincipalOng inicio = new fPrincipalOng(usuarioCreador);
                this.Hide();
                inicio.ShowDialog();
                this.Close();

            }
            else if (usuarioCreador.RolUsuario.RolName.Equals("ADMIN"))
            {
                fPantallaAdminFinal inicio = new fPantallaAdminFinal(usuarioCreador);
                this.Hide();
                inicio.ShowDialog();
                this.Close();
            }
        }
    }
}
