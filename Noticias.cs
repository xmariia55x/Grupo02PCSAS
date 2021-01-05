using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    class Noticias
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private string titulo;
        private Usuario autor;
        private string cuerpo;
        private string fecha;

        public Noticias(string t, Usuario a)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM Noticias WHERE titulo = '" + t + "' and autor = '" + a.CorreoUsuario + "';")[0];
            this.titulo = (string)tupla[0];
            this.autor = new Usuario((string)tupla[1]);
            this.cuerpo = (string)tupla[2];
            this.fecha = (string)tupla[3];
        }

        public Noticias(string t, Usuario a, string c, string f)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Insert("INSERT INTO Noticias VALUES ('" + t + "','" + a.CorreoUsuario + "','" + c + "','" + f + "');");
            this.titulo = t;
            this.autor = a;
            this.cuerpo = c;
            this.fecha = f;
        }

        public string Titulo
        {
            get
            {
                return this.titulo;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Noticias SET titulo = '" + value + "' WHERE titulo = '" + this.titulo + "and autor = '" + this.autor.CorreoUsuario + "';");
                this.titulo = value;
            }
        }

        public Usuario Autor
        {
            get
            {
                return this.autor;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Noticias SET autor = '" + value.CorreoUsuario + "' WHERE titulo = '" + this.titulo + "and autor = '" + this.autor.CorreoUsuario + "';");
                this.autor = value;
            }
        }

        public string Cuerpo
        {
            get
            {
                return this.cuerpo;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Noticias SET cuerpo = '" + value + "' WHERE titulo = '" + this.titulo + "and autor = '" + this.autor.CorreoUsuario + "';");
                this.cuerpo = value;
            }
        }


        public string Fecha
        {
            get
            {
                return this.fecha;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Noticias SET fecha = '" + value + "' WHERE titulo = '" + this.titulo + "and autor = '" + this.autor.CorreoUsuario + "';");
                this.fecha = value;
            }
        }

        public void borrarNoticia()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM Noticias WHERE titulo = '" + this.titulo + "and autor = '" + this.autor.CorreoUsuario + "';");
            this.titulo = null;
            this.autor = null;
            this.cuerpo = null;
            this.fecha = null;
        }

        public override bool Equals(object obj)
        {
            return (obj is Noticias) && (this.titulo.Equals(((Noticias)obj).titulo)) && (this.autor.Equals(((Noticias)obj).autor));
        }

        public override int GetHashCode()
        {
            return this.titulo.GetHashCode() + this.autor.GetHashCode();
        }
    }
}
