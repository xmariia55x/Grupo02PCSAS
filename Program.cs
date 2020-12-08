using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo02PCSAS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new fCrearActividadAdmin());
            //Application.Run(new fCrearCursoAdmin());
            //Application.Run(new fModificarCursos());
            //Application.Run(new fNuevoDebateForo());
            //Application.Run(new PantallaBorrarCurso());
            //Application.Run(new PantallaBorrarCurso());
            //Application.Run(new PantallaBorrarCurso());
            //Application.Run(new fInfoCursoProfesor());
            //Application.Run(new fPrincipalProfesor());
            //Application.Run(new fPantallaAdmin());
            //Application.Run(new fStartAplicacion());
            Application.Run(new fRegistro());
            //Commit de maria
        }
    }


}
