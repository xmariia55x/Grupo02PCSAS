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
        public fCrearCursoAdmin(Usuario user)
        {
            usuarioCreador = user; 
            InitializeComponent();
        }

        

        private void fCrearCursoAdmin_Load(object sender, EventArgs e)
        {
            if (!usuarioCreador.RolUsuario.RolName.Equals("ADMIN")) this.Close();
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
            horaIni = dHoraIniCurso.Value.ToString();
            horaFin = dHoraFinCurso.Value.ToString();
            aforo = tAforoCurso.Text.ToString(); //Pasar el aforo a entero 
    }

    }
}
