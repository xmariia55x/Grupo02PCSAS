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
    public partial class fRedactarMensaje : Form
    {
        private Usuario user;
        public fRedactarMensaje(Usuario u)
        {
            InitializeComponent();
            user = u;
        }

        private void fRedactarMensaje_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsgrupo02DataSet1.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.apsgrupo02DataSet1.Usuario);



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
