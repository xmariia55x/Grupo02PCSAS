using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    public class Usuario
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private string correoUsuario;
        private string nombreUsuario;
        private string contraseniaUsuario;
        private string cif;
        private string niu;
        private Rol rol;
        public Usuario(string correo)//constructor SELECT
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
           Object[] tupla =  miBD.Select("SELECT * FROM Usuario WHERE correoUsuario = '" + correo + "';")[0];
            this.correoUsuario = (string) tupla[0];
            this.nombreUsuario = (string) tupla[1];
            this.contraseniaUsuario = (string) tupla[2];
            this.cif = (string) tupla[3];
            this.niu = (string) tupla[4];
            this.rol = new Rol((string)tupla[5]);
        }

        public static List<Usuario> listaColaboradores()
        {
            List<Usuario> lista = new List<Usuario>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (object[] tupla in miBD.Select("SELECT correoUsuario FROM Usuario WHERE rolUsuario = 'ENTIDAD';"))
            {
                string r = (string)tupla[0];
                lista.Add(new Usuario(r));
            }
            return lista;
        }
        public static List<Usuario> listaProfesores()
        {
            List<Usuario> lista = new List<Usuario>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (object[] tupla in miBD.Select("SELECT correoUsuario FROM Usuario WHERE rolUsuario = 'PROFESOR';"))
            {
                string r = (string)tupla[0];
                lista.Add(new Usuario(r));
            }
            return lista;
        }
        public Usuario(string correo, string nombre, string contrasenia, string cif, string niu, Rol rol)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Insert("INSERT INTO Usuario VALUES ('" + correo + "','" + nombre + "','" + contrasenia + "','" + cif + "','" + niu + "','" + rol.RolName + "');");
            this.correoUsuario = correo;
            this.nombreUsuario = nombre;
            this.contraseniaUsuario = contrasenia;
            this.cif = cif;
            this.niu = niu;
            this.rol = rol;
        }

        public string CorreoUsuario
        {
            get { return correoUsuario; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Usuario SET correoUsuario = '" + value + "'WHERE correoUsuario='" + this.correoUsuario + "';");
                this.correoUsuario = value;
            }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Usuario SET nombreUsuario = '" + value + "'WHERE correoUsuario='" + this.correoUsuario + "';");
                this.nombreUsuario = value;
            }
        }

        public string ContraseniaUsuario
        {
            get { return contraseniaUsuario; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Usuario SET contraseniaUsuario = '" + value + "'WHERE correoUsuario='" + this.correoUsuario + "';");
                this.contraseniaUsuario = value;
            }
        }

        public string CifUsuario
        {
            get { return cif; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Usuario SET cif = '" + value + "'WHERE correoUsuario='" + this.correoUsuario + "';");
                this.cif = value;
            }
        }

        public string NiuUsuario
        {
            get { return niu; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Usuario SET niu = '" + value + "'WHERE correoUsuario='" + this.correoUsuario + "';");
                this.niu = value;
            }
        }
        public Rol RolUsuario
        {
            get { return rol; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Usuario SET rolUsuario = '" + value.RolName + "'WHERE correoUsuario='" + this.correoUsuario + "';");
                this.rol = value;
            }
        }
        public void BorrarUsuario()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM Usuario WHERE correoUsuario ='" + this.correoUsuario + "';");
            this.correoUsuario = null;
            this.nombreUsuario = null;
            this.contraseniaUsuario = null;
            this.cif = null;
            this.niu = null;
            this.rol = null;
        }

        public override bool Equals(object obj)
        {
            return (obj is Usuario) && (this.correoUsuario.Equals(((Usuario)obj).correoUsuario));
        }

        public override int GetHashCode()
        {
            return correoUsuario.GetHashCode();
        }


    }
}
