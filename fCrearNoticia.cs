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
    public partial class fCrearNoticia : Form
    {

        string titulo;
        string autor;
        string cuerpo;
        string fecha;
        Noticias noticiaCreada;

        Usuario user;

        public fCrearNoticia(Usuario u)
        {
            user = u;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fNoticia noticia = new fNoticia(user);
            this.Hide();
            noticia.ShowDialog();
            this.Close();
        }

        private void bAddNot_Click(object sender, EventArgs e)
        {
            try
            {
                this.titulo = tbTitulo.Text;
                this.autor = tbAutor.Text;
                this.cuerpo = tbCuerpo.Text;
                this.fecha = DateTime.Now.ToShortDateString();

                if(titulo.Equals("") || autor.Equals("") || cuerpo.Equals(""))
                {
                    throw new Exception("Campos vacíos");
                } else
                {
                    noticiaCreada = new Noticias(titulo,autor,cuerpo,fecha);
                    MessageBox.Show("Noticia creada correctamente");
                }
                this.Close();

            } catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }


        }
    }
}
