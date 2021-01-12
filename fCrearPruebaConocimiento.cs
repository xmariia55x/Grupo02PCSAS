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
    public partial class fCrearPruebaConocimiento : Form
    {
        private Usuario usuario;
        private Curso curso;
        public fCrearPruebaConocimiento(Usuario u, Curso c)
        {
            this.usuario = u;
            this.curso = c;
            InitializeComponent();
        }

        private void fCrearPruebaConocimiento_Load(object sender, EventArgs e)
        {
            lNombreUser.Text = usuario.NombreUsuario;
            lRolUser.Text = usuario.RolUsuario.RolName;
            lNombreCurso.Text = curso.CursoNombre;
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            string p1, p2, p3, p4, p5;

            if (tP1.Text.Equals("") || tR1_1.Text.Equals("") || tR1_2.Text.Equals("") || tR1_3.Text.Equals("") ||
                tP2.Text.Equals("") || tR2_1.Text.Equals("") || tR2_2.Text.Equals("") || tR2_3.Text.Equals("") ||
                tP3.Text.Equals("") || tR3_1.Text.Equals("") || tR3_2.Text.Equals("") || tR3_3.Text.Equals("") ||
                tP4.Text.Equals("") || tR4_1.Text.Equals("") || tR4_2.Text.Equals("") || tR4_3.Text.Equals("") ||
                tP5.Text.Equals("") || tR5_1.Text.Equals("") || tR5_2.Text.Equals("") || tR5_3.Text.Equals(""))
            {
                MessageBox.Show("Faltan campos por rellenar");
            }
            else
            {
                p1 = tP1.Text + ";" + tR1_1.Text + ";" + tR1_2.Text + ";" + tR1_3.Text + ";" + n1.Value;
                p2 = tP2.Text + ";" + tR2_1.Text + ";" + tR2_2.Text + ";" + tR2_3.Text + ";" + n1.Value;
                p3 = tP3.Text + ";" + tR3_1.Text + ";" + tR3_2.Text + ";" + tR3_3.Text + ";" + n1.Value;
                p4 = tP4.Text + ";" + tR4_1.Text + ";" + tR4_2.Text + ";" + tR4_3.Text + ";" + n1.Value;
                p5 = tP5.Text + ";" + tR5_1.Text + ";" + tR5_2.Text + ";" + tR5_3.Text + ";" + n1.Value;

                new PruebaConocimiento(p1, p2, p3, p4, p5, curso.CursoID);

                MessageBox.Show("Se ha creado la prueba con éxito");
                cerrar();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void cerrar()
        {
            fInfoCurso f = new fInfoCurso(usuario, curso);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
