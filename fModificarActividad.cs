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
    public partial class fModificarActividad : Form
    {
        Usuario user;
        Actividad act;
        public fModificarActividad(Usuario u, Actividad a)
        {
            this.user = u;
            this.act = a;
            InitializeComponent();
        }

        private void fModificarActividad_Load(object sender, EventArgs e)
        {
            lRol.Text = user.RolUsuario.RolName;
            lNombreUser.Text = user.NombreUsuario;
            lNombreAct.Text = act.NombreActividad;
            lNombreCreador.Text = user.NombreUsuario;
            tNombre.Text = act.NombreActividad;
            tDescripcion.Text = act.DescripcionActividad;
            tAforo.Text = act.AforoActividad.ToString();
            tLugar.Text = act.LugarActividad;

            string horaFin = act.HoraInicioActividad;

            string[] horaF = horaFin.Split(':');
            string horaIni = act.HoraFinActividad;

            string[] horaI = horaIni.Split(':');
            string fechaIni = act.FechaInicioActividad;

            string[] fechaI = fechaIni.Split('/');
            string fechaFin = act.FechaFinActividad;
            string[] fechaF = fechaFin.Split('/');

            int hI, mI;
            int hF, mF;
            if (int.TryParse(horaI[0], out hI) && int.TryParse(horaI[1], out mI))
            {
                dHoraIni.Value = new DateTime(2300, 1, 1, hI, mI, 0);
            }
            else
            {
                Console.WriteLine("No se puede hacer el parse");
            }

            if (int.TryParse(horaF[0], out hF) && int.TryParse(horaF[1], out mF))
            {
                dHoraFin.Value = new DateTime(2300, 1, 1, hF, mF, 0);
            }
            else
            {
                Console.WriteLine("No se puede hacer el parse");
            }


            int dF, dI, mesI, aI, mesF, aF;

            if (int.TryParse(fechaI[0], out dI) && int.TryParse(fechaI[1], out mesI) && int.TryParse(fechaI[2], out aI))
            {
                dFechaIni.Value = new DateTime(aI, mesI, dI, 0, 0, 0);
            }
            else
            {
                Console.WriteLine("No se puede hacer el parse");
            }

            if (int.TryParse(fechaF[0], out dF) && int.TryParse(fechaF[1], out mesF) && int.TryParse(fechaF[2], out aF))
            {
                dFechaFin.Value = new DateTime(aF, mesF, dF, 0, 0, 0);
            }
            else
            {
                Console.WriteLine("No se puede hacer el parse");
            }
        }

        private void bModAniadirArchivosCurso_Click(object sender, EventArgs e)
        {
            fArchivoActividad f = new fArchivoActividad(user, act);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void bEliminarArchivo_Click(object sender, EventArgs e)
        {
            fEliminarArchivoActividad f = new fEliminarArchivoActividad(user, act);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!act.NombreActividad.Equals(tNombre.Text))
                    act.NombreActividad = tNombre.Text;
                if (!act.DescripcionActividad.Equals(tDescripcion.Text))
                    act.DescripcionActividad = tDescripcion.Text;
                if (!act.FechaInicioActividad.Equals(dFechaIni.Value.ToString()))
                    act.FechaInicioActividad = dFechaIni.Value.ToString();
                if (!act.FechaFinActividad.Equals(dFechaFin.Value.ToString()))
                    act.FechaFinActividad = dFechaFin.Value.ToString();
                if (!act.HoraInicioActividad.Equals(dHoraIni.Value.ToString("HH:mm")))
                    act.HoraInicioActividad = dHoraIni.Value.ToString("HH:mm");
                if (!act.HoraFinActividad.Equals(dHoraFin.Value.ToString("HH:mm")))
                    act.HoraFinActividad = dHoraFin.Value.ToString("HH:mm");
                if (!act.LugarActividad.Equals(tLugar.Text))
                    act.LugarActividad = tLugar.Text;
                if (act.AforoActividad != Convert.ToInt32(tAforo.Text))
                    act.AforoActividad = Convert.ToInt32(tAforo.Text);

                MessageBox.Show("Actividad modificada correctamente");
                cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void cerrar()
        {
            fPrincipalOng f = new fPrincipalOng(user);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(user);
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            fDatosPerfil datosPerfil = new fDatosPerfil(user);
            this.Visible = false;
            datosPerfil.ShowDialog();
            this.Visible = true;
        }
    }
}
