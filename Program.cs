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
            Rol usuario = new Rol("hola");
            Console.WriteLine(usuario.ToString());
            //Rol usuario2 = new Rol("hola2", "kk", true);
            Rol user3 = new Rol("hola2");
            Console.WriteLine(user3.ToString());
            user3.BorrarRol();
            usuario.RolDes = "cambia";
            Console.WriteLine(usuario.ToString());
            //Application.Run(new fRegistro());
            //Commit de maria
        }
    }


}
