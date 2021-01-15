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
    public partial class fPruebaConocimientoCurso : Form
    {
        private Usuario usuario;
        private Curso curso;
        private PruebaConocimiento prueba;
        private RespuestaPruebaConocimiento respuesta;
        public fPruebaConocimientoCurso(Usuario usuario, Curso curso)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.curso = curso;
            this.prueba = new PruebaConocimiento(curso.CursoID);
        }

        private void fPruebaConocimientoCurso_Load(object sender, EventArgs e)
        {
            lNombreUser.Text = usuario.NombreUsuario;
            lRolUser.Text = usuario.RolUsuario.RolName;

            lNombreCurso.Text = curso.CursoNombre;
            lPregunta1.Text = obtieneEnunciado(prueba.P1);
            lPregunta2.Text = obtieneEnunciado(prueba.P2);
            lPregunta3.Text = obtieneEnunciado(prueba.P3);
            lPregunta4.Text = obtieneEnunciado(prueba.P4);
            lPregunta5.Text = obtieneEnunciado(prueba.P5);

            rellenaCheckBoxList(chlBpregunta1, obtieneOpciones(prueba.P1));
            rellenaCheckBoxList(chlBpregunta2, obtieneOpciones(prueba.P2));
            rellenaCheckBoxList(chlBpregunta3, obtieneOpciones(prueba.P3));
            rellenaCheckBoxList(chlBpregunta4, obtieneOpciones(prueba.P4));
            rellenaCheckBoxList(chlBpregunta5, obtieneOpciones(prueba.P5));
        }

        private void rellenaCheckBoxList(CheckedListBox checkBox, string[] respuestas)
        {
            foreach(string opcion in respuestas)
            {
                checkBox.Items.Add(opcion);
            }
        }

        private string obtieneEnunciado(string preguntaCompleta)
        {
            string[] enunciado = preguntaCompleta.Split(';');
            return enunciado[0];
        }

        private string[] obtieneOpciones(string preguntaCompleta)
        {
            string[] enunciado = preguntaCompleta.Split(';');
            string[] resultado = new string[3];
            for(int i = 0; i <= 2; i++)
            {
                resultado[i] = enunciado[i + 1];

            }
            return resultado;
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (compruebaSeleccionCorrecta(chlBpregunta1) && compruebaSeleccionCorrecta(chlBpregunta2)
                    && compruebaSeleccionCorrecta(chlBpregunta3) && compruebaSeleccionCorrecta(chlBpregunta4)
                    && compruebaSeleccionCorrecta(chlBpregunta5))
                {
                    //Hay una unica opcion seleccionada
                    respuesta = new RespuestaPruebaConocimiento(usuario.CorreoUsuario, curso.CursoID, chlBpregunta1.CheckedItems[0].ToString(), chlBpregunta2.CheckedItems[0].ToString(),
                        chlBpregunta3.CheckedItems[0].ToString(), chlBpregunta4.CheckedItems[0].ToString(), chlBpregunta5.CheckedItems[0].ToString());
                    MessageBox.Show("Prueba de conocimiento guardada correctamente.");
                    cierra();
                } else
                {
                    MessageBox.Show("Faltan campos por rellenar o hay campos que no están bien rellenos.");
                }
                
            } catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void cierra()
        {
            if (usuario.RolUsuario.RolName.Equals("ENTIDAD"))
            {
                fPrincipalOng ong = new fPrincipalOng(usuario);
                this.Hide();
                ong.ShowDialog();
                this.Close();
            }
            else if (usuario.RolUsuario.RolName.Equals("PROFESOR"))
            {
                fPrincipalProfesor profe = new fPrincipalProfesor(usuario);
                this.Hide();
                profe.ShowDialog();
                this.Close();
            }
            else if (usuario.RolUsuario.RolName.Equals("ALUMNO"))
            {
                fPantallaPrincipalAlumno alu = new fPantallaPrincipalAlumno(usuario);
                this.Hide();
                alu.ShowDialog();
                this.Close();
            }
            
        }

        private Boolean compruebaSeleccionCorrecta(CheckedListBox checkbox)
        {
            return checkbox.CheckedItems.Count == 1;
        }

        private string getValorSeleccionado(CheckedListBox checkbox)
        {
            return checkbox.CheckedItems.ToString();
        }

        private void lMiPerfil_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(usuario);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void picturePerfil_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(usuario);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void logoPCSAS_Click(object sender, EventArgs e)
        {

        }
    }
}
