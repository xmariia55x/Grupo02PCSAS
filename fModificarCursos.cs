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
        private Usuario user, profesor;
        private Curso cursoRealizado;
        
        public fModificarCursos(Usuario u, int idCurso)
        {
            InitializeComponent();
            user = u;
            cursoRealizado = new Curso(idCurso);
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
                if (cursoRealizado.CursoAforo != Convert.ToInt32(tModAforoCurso))
                    cursoRealizado.CursoAforo = Convert.ToInt32(tModAforoCurso);
               // if (cursoRealizado.CursoProfesor.CorreoUsuario != new Usuario((string)listProfesor.SelectedItem).CorreoUsuario)  panel1.Visible = true)
                    //cursoRealizado.CursoProfesor = listProfesor.SelectedItem;
                if (user.RolUsuario.RolName.Equals("ADMIN"))
                {
                    profesor = new Usuario((string)listProfesor.SelectedItem);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
