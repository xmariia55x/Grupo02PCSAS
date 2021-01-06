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
    public partial class fInfoActividad : Form
    {
        Usuario user;
        Actividad act;

        public fInfoActividad(Usuario user, Actividad act)
        {
            InitializeComponent();
            this.user = user;
            this.act = act;
        }

        private void fInfoActividad_Load(object sender, EventArgs e)
        {
            if (user == null)
            {
                pictureBox2.Visible = false;
                label5.Visible = false;
                label9.Visible = false;
                lInscrito.Visible = false;
            }
            mostrarUsuario();
            mostrarActividad();
            comprobarInscrito();
            calcularPlazasDisponibles();
        }

        private void calcularPlazasDisponibles()
        {
            List<Usuario> lista = ActividadesRealizadas.listaUsuarios(act.IdActividad);
            List<Usuario> filtro = new List<Usuario>();
            foreach (Usuario u in lista)
                if (u.RolUsuario.RolName.Equals("ALUMNO") || u.RolUsuario.RolName.Equals("PROFESOR")) filtro.Add(u);
            lPlazasDisp.Text = (act.AforoActividad - filtro.Count).ToString();
        }

        private void comprobarInscrito()
        {
            bool inscrito = false;
            if (user != null)
            {


                foreach (Usuario u in ActividadesRealizadas.listaUsuarios(act.IdActividad))
                {
                    if (user.CorreoUsuario.Equals(u.CorreoUsuario)) inscrito = true;
                }

                if (inscrito)
                {
                    lInscrito.Text = "Inscrito";
                }
                else
                {
                    lInscrito.Text = "No inscrito";
                }
            }
        }

        private void mostrarUsuario()
        {
            if (user == null)
            {
                lNombreUser.Text = "INVITADO";
                lRol.Text = "INVITADO";
            } 
            else
            {
                lNombreUser.Text = user.NombreUsuario;
                lRol.Text = user.RolUsuario.RolName;
            }
            
        }

        private void mostrarActividad()
        {
            lNombreAct.Text = act.NombreActividad;
            lDescripcion.Text = act.DescripcionActividad;
            lNombreProf.Text = act.UsuarioCreador.NombreUsuario;
            lPlazasTotales.Text = act.AforoActividad.ToString();
            lLugar.Text = act.LugarActividad;
            lFechaInicio.Text = act.FechaInicioActividad;
            lFechaFin.Text = act.FechaFinActividad;
            lHoraInicio.Text = act.HoraInicioActividad;
            lHoraFin.Text = act.HoraFinActividad;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datos = new fDatosPerfil(user);
            this.Visible = false;
            datos.ShowDialog();
            this.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            fDatosPerfil edicion = new fDatosPerfil(this.user);
            this.Visible = false;
            edicion.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (user.RolUsuario.RolName.Equals("ALUMNO"))
            {
                fPantallaPrincipalAlumno inicio = new fPantallaPrincipalAlumno(user);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
            else if (user.RolUsuario.RolName.Equals("PROFESOR"))
            {
                fPrincipalProfesor inicio = new fPrincipalProfesor(user);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
            else if (user.RolUsuario.RolName.Equals("ENTIDAD"))
            {
                fPrincipalOng inicio = new fPrincipalOng(user);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
            else if (user.RolUsuario.RolName.Equals("ADMIN"))
            {
                fPantallaAdminFinal inicio = new fPantallaAdminFinal(user);
                this.Visible = false;
                inicio.ShowDialog();
                this.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
