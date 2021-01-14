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
    public partial class fEditarPruebaConocimiento : Form
    {
        private Usuario usuario;
        private Curso curso;
        private PruebaConocimiento prueba;
        private string[] p1;
        private string[] p2;
        private string[] p3;
        private string[] p4;
        private string[] p5;


        public fEditarPruebaConocimiento(Usuario u, Curso c, PruebaConocimiento p)
        {
            this.usuario = u;
            this.curso = c;
            this.prueba = p;

            this.p1 = p.P1.Split(';');
            this.p2 = p.P2.Split(';');
            this.p3 = p.P3.Split(';');
            this.p4 = p.P4.Split(';');
            this.p5 = p.P5.Split(';');
            InitializeComponent();
        }

        private void fEditarPruebaConocimiento_Load(object sender, EventArgs e)
        {
            lNombreUser.Text = usuario.NombreUsuario;
            lRolUser.Text = usuario.RolUsuario.RolName;
            lNombreCurso.Text = curso.CursoNombre;

            rellenar();
        }

        private void rellenar()
        {
            //PREGUNTA 1
            tP1.Text = p1[0];
            tR1_1.Text = p1[1];
            tR1_2.Text = p1[2];
            tR1_3.Text = p1[3];
            n1.Value = Decimal.Parse(p1[4]);

            //PREGUNTA 2
            p2 = prueba.P2.Split(';');
            tP2.Text = p2[0];
            tR2_1.Text = p2[1];
            tR2_2.Text = p2[2];
            tR2_3.Text = p2[3];
            n2.Value = Decimal.Parse(p2[4]);

            //PREGUNTA 3
            p3 = prueba.P3.Split(';');
            tP3.Text = p3[0];
            tR3_1.Text = p3[1];
            tR3_2.Text = p3[2];
            tR3_3.Text = p3[3];
            n3.Value = Decimal.Parse(p3[4]);

            //PREGUNTA 4
            p4 = prueba.P4.Split(';');
            tP4.Text = p4[0];
            tR4_1.Text = p4[1];
            tR4_2.Text = p4[2];
            tR4_3.Text = p4[3];
            n4.Value = Decimal.Parse(p4[4]);

            //PREGUNTA 5
            p5 = prueba.P5.Split(';');
            tP5.Text = p5[0];
            tR5_1.Text = p5[1];
            tR5_2.Text = p5[2];
            tR5_3.Text = p5[3];
            n5.Value = Decimal.Parse(p5[4]);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void cerrar()
        {
            fInfoCursoProfesor f = new fInfoCursoProfesor(usuario, curso);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            if (!tP1.Text.Equals(p1[0]) || !tR1_1.Text.Equals(p1[1]) || !tR1_2.Text.Equals(p1[2]) || !tR1_3.Text.Equals(p1[3]) || !n1.Value.ToString().Equals(p1[4]))
            {
                prueba.P1 = tP1.Text + ";" + tR1_1.Text + ";" + tR1_2.Text + ";" + tR1_3.Text + ";" + n1.Value;
            }

            if (!tP2.Text.Equals(p2[0]) || !tR2_1.Text.Equals(p2[1]) || !tR2_2.Text.Equals(p2[2]) || !tR2_3.Text.Equals(p2[3]) || !n2.Value.ToString().Equals(p2[4]))
            {
                prueba.P2 = tP2.Text + ";" + tR2_1.Text + ";" + tR2_2.Text + ";" + tR2_3.Text + ";" + n2.Value;
            }

            if (!tP3.Text.Equals(p3[0]) || !tR3_1.Text.Equals(p3[1]) || !tR3_2.Text.Equals(p3[2]) || !tR3_3.Text.Equals(p3[3]) || !n3.Value.ToString().Equals(p3[4]))
            {
                prueba.P3 = tP3.Text + ";" + tR3_1.Text + ";" + tR3_2.Text + ";" + tR3_3.Text + ";" + n3.Value;
            }

            if (!tP4.Text.Equals(p4[0]) || !tR4_1.Text.Equals(p4[1]) || !tR4_2.Text.Equals(p4[2]) || !tR4_3.Text.Equals(p4[3]) || !n4.Value.ToString().Equals(p4[4]))
            {
                prueba.P4 = tP4.Text + ";" + tR4_1.Text + ";" + tR4_2.Text + ";" + tR4_3.Text + ";" + n4.Value;
            }

            if (!tP5.Text.Equals(p5[0]) || !tR5_1.Text.Equals(p5[1]) || !tR5_2.Text.Equals(p5[2]) || !tR5_3.Text.Equals(p5[3]) || !n5.Value.ToString().Equals(p5[4]))
            {
                prueba.P5 = tP5.Text + ";" + tR5_1.Text + ";" + tR5_2.Text + ";" + tR5_3.Text + ";" + n5.Value;
            }

            MessageBox.Show("Se ha actualizado la prueba de conocimiento con éxito");
            cerrar();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            cerrar(); 
        }

        private void picturePerfil_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(usuario);
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = true;
        }

        private void lMiPerfil_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(usuario);
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = true;
        }
    }
}
