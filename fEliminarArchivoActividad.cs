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
    public partial class fEliminarArchivoActividad : Form
    {
        Usuario usuario;
        Actividad actividad;
        public fEliminarArchivoActividad(Usuario u, Actividad a)
        {
            this.usuario = u;
            this.actividad = a;
            InitializeComponent();
        }

        private void fEliminarArchivoActividad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet1.MaterialActividad' Puede moverla o quitarla según sea necesario.
            this.materialActividadTableAdapter.Fill(this.apsgrupo02DataSet1.MaterialActividad);
            lRol.Text = usuario.RolUsuario.RolName;
            lNombreUser.Text = usuario.NombreUsuario;
            lNombreCurso.Text = actividad.NombreActividad;
        }
    }
}
