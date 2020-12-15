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
            //Rol usuario = new Rol("hola");
            //Console.WriteLine(usuario.ToString());
            //Rol usuario2 = new Rol("hola2", "kk", true);
            //Rol user3 = new Rol("hola2");
            //Console.WriteLine(user3.ToString());
            //user3.BorrarRol();
            //usuario.RolDes = "cambia";
            //Console.WriteLine(usuario.ToString());
            //Application.Run(new fRegistro());
            //Commit de maria
            //Rol alumno = new Rol("ALUMNO");
            //Rol alumno = new Rol("ALUMNO", "al", false);
            //Rol profesor = new Rol("PROFESOR", "prof", false);
            //Rol admin = new Rol("ADMIN", "adm", true);
            //Usuario user = new Usuario("prueba", "prueba", "prueba", "cif", "niu", alumno);
            Usuario user = new Usuario("prueba");
            //Usuario user = new Usuario("prueba", "prueba", "prueba", "cif", "niu", alumno);
            //Rol admin = new Rol("ADMIN", "administrador", true);
            Rol admin = new Rol("ADMIN");
            Rol profesor = new Rol("PROFESOR");
            //Usuario usuario = new Usuario("pepe", "lolo", "lola", null, null, admin);
            //Usuario usuario = new Usuario("pepe");
            //Usuario usuario = new Usuario("anto", "anto2", "prueba", null, "niu", profesor);
            //Usuario usuario = new Usuario("anto2", "anto2", "prueba", "c", "niu", profesor);
            Usuario usuario = new Usuario("anto");
            //Application.Run(new fDatosPerfil(user));
            //Application.Run(new fRegistro());
            //Console.WriteLine(usuario.CorreoUsuario + " "+usuario.NombreUsuario);
            Application.Run(new fCrearActividadAdmin(usuario));
            
            //Curso c = new Curso("anto2", "aps", "aps para ninios", "13/12/2020"
            //, "13/12/2020", "12:00", "14:00", "UMA", 7, false);
            //Actividad a = new Actividad(usuario, "recogida alimentos", "random", "13/12/2020", "13/12/2020", "12:00", "14:00", "UMA", 7);
            Application.Run(new fEditarPerfil(user));
            //Application.Run(new fRegistro());
        }
    }


}
