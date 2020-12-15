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
    public partial class fModificarCursos : Form
    {
        private Usuario user;
        private Curso cursoRealizado;
        
        public fModificarCursos(Usuario u, Curso c)
        {
            InitializeComponent();
            user = u;
            cursoRealizado = c;
        }

        private void fModificarCursos_Load(object sender, EventArgs e)
        {
            bModAniadirArchivosCurso.Enabled = true;
            bModGuardarCambiosCurso.Enabled = true;
            if (!user.RolUsuario.RolName.Equals("ADMIN"))
            {
                panel1.Visible = false;

            }
            else
            {
                foreach (Usuario u in Usuario.listaProfesores()) listProfesor.Items.Add(u.CorreoUsuario);
            }
            mostrarSeleccionado();
        }

        private void mostrarSeleccionado()
        {
            if (cursoRealizado == null)
            {
                tModNombreCurso.Text = "";
                tModDescripcionCurso.Text = "";
                tModLugarCurso.Text = "";
                tModAforoCurso.Text = "";
                rModOnline.Checked = false;
                rModPresencial.Checked = false;
                listProfesor.SelectedItem = null;
            }
            else
            {
                tModNombreCurso.Text = cursoRealizado.CursoNombre;
                tModDescripcionCurso.Text = cursoRealizado.CursoDescripcion;
                tModLugarCurso.Text = cursoRealizado.CursoLugar;
                tModAforoCurso.Text = cursoRealizado.CursoAforo.ToString();
                if(cursoRealizado.CursoOnline)
                {
                    rModPresencial.Checked = false;
                    rModOnline.Checked = true;
                } else
                {
                    rModPresencial.Checked = true;
                    rModOnline.Checked = false;
                }
                string horaFin = cursoRealizado.CursoHoraFin;
                
                string[] horaF = horaFin.Split(':');
                string horaIni = cursoRealizado.CursoHoraInicio;
                
                string[] horaI = horaIni.Split(':');
                string fechaIni = cursoRealizado.CursoFechaInicio;
                
                string[] fechaI = fechaIni.Split('/');
                string fechaFin = cursoRealizado.CursoFechaFin;
                string[] fechaF = fechaFin.Split('/');
                
                int hI, mI; 
                int hF, mF;
                if(int.TryParse(horaI[0], out hI) && int.TryParse(horaI[1], out mI))
                {
                    dModiHoraIniCurso.Value = new DateTime(2300, 1, 1, hI, mI, 0);
                } else
                {
                    Console.WriteLine("No se puede hacer el parse");
                }
                
                if(int.TryParse(horaF[0], out hF) && int.TryParse(horaF[1], out mF))
                {
                    dModiHoraFinCurso.Value = new DateTime(2300, 1, 1, hF, mF, 0);
                }
                else
                {
                    Console.WriteLine("No se puede hacer el parse");
                }

                
                int dF, dI, mesI, aI, mesF, aF;

                if(int.TryParse(fechaI[0], out dI) && int.TryParse(fechaI[1], out mesI) && int.TryParse(fechaI[2], out aI))
                {
                    dModiFechaIniCurso.Value = new DateTime(aI, mesI, dI, 0, 0, 0);
                }
                else
                {
                    Console.WriteLine("No se puede hacer el parse");
                }

                //dModiFechaFinCurso = new DateTimePicker();
                if (int.TryParse(fechaF[0], out dF) && int.TryParse(fechaF[1], out mesF) && int.TryParse(fechaF[2], out aF))
                {
                    dModiFechaFinCurso.Value = new DateTime(aF, mesF, dF, 0, 0, 0);
                }
                else
                {
                    Console.WriteLine("No se puede hacer el parse");
                }


                listProfesor.SelectedItem = cursoRealizado.CursoProfesor;
            }

        }

        private void bModGuardarCambiosCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cursoRealizado.CursoNombre.Equals(tModNombreCurso.Text))
                    cursoRealizado.CursoNombre = tModNombreCurso.Text;
                if (!cursoRealizado.CursoDescripcion.Equals(tModDescripcionCurso.Text))
                    cursoRealizado.CursoDescripcion = tModDescripcionCurso.Text;
                if (!cursoRealizado.CursoFechaInicio.Equals(dModiFechaIniCurso.Value.ToString()))
                    cursoRealizado.CursoFechaInicio = dModiFechaIniCurso.Value.ToString();
                if (!cursoRealizado.CursoFechaFin.Equals(dModiFechaFinCurso.Value.ToString()))
                    cursoRealizado.CursoFechaFin = dModiFechaFinCurso.Value.ToString();
                if (!cursoRealizado.CursoHoraInicio.Equals(dModiHoraIniCurso.Value.ToString("HH:mm")))
                    cursoRealizado.CursoHoraInicio = dModiHoraIniCurso.Value.ToString("HH:mm");
                if (!cursoRealizado.CursoHoraFin.Equals(dModiHoraFinCurso.Value.ToString("HH:mm")))
                    cursoRealizado.CursoHoraFin = dModiHoraFinCurso.Value.ToString("HH:mm");
                if (!cursoRealizado.CursoLugar.Equals(tModLugarCurso.Text))
                    cursoRealizado.CursoLugar = tModLugarCurso.Text;
                if (cursoRealizado.CursoOnline != rModOnline.Checked)
                    cursoRealizado.CursoOnline = rModOnline.Checked;
                if (cursoRealizado.CursoAforo != Convert.ToInt32(tModAforoCurso.Text))
                    cursoRealizado.CursoAforo = Convert.ToInt32(tModAforoCurso.Text);
                  
                if (user.RolUsuario.RolName.Equals("ADMIN"))
                {
                    cursoRealizado.CursoProfesor = new Usuario((string)listProfesor.SelectedItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        
    }
}
