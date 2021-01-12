using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    class ValoracionActividad
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private Usuario user;
        private Actividad actividad;
        private int satisfaccion;
        private int lugar;
        private int horario;
        private int organizacion;
        private bool repetir;
        private String comentario;

        public ValoracionActividad(Usuario usuario, Actividad act)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM ValoracionActividad WHERE correoUsuario = '" + usuario.CorreoUsuario + "' AND idActividad = "+act.IdActividad+";")[0];
            this.user = new Usuario((string)tupla[0]);
            this.actividad = new Actividad((int)tupla[1]);
            this.satisfaccion = (int)tupla[2];
            this.lugar = (int)tupla[3];
            this.horario = (int)tupla[4];
            this.organizacion = (int)tupla[5];
            this.repetir = (int)tupla[6] == 0 ? false : true;
            this.comentario = (String)tupla[7];
        }

        public ValoracionActividad(Usuario user, Actividad act, int s, int l, int h, int o, bool r, String c) 
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            string sentencia = "INSERT INTO ValoracionActividad VALUES (" + user.CorreoUsuario + "," + act.IdActividad + "," + s + "," + l + ","+ h + "," + o + "," + (r == true ? 1 : 0) + ",'" + c + "');";
            miBD.Insert(sentencia);
            this.user = user;
            this.actividad = act;
            this.satisfaccion = s;
            this.lugar = l;
            this.horario = h;
            this.organizacion = o;
            this.repetir = r;
            this.comentario = c;
        }

        public Usuario UsuarioValoracion
        {
            get { return this.user; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ValoracionActividad SET correoUsuario ='" + value + "' WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idActividad = "+this.actividad.IdActividad+"; ");
                this.user = value;
            }
        }
        public Actividad ActividadValoracion
        {
            get { return this.actividad; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ValoracionActividad SET idActividad ="+ value +" WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idActividad = " + this.actividad.IdActividad + "; ");
                this.actividad = value;
            }
        }


        public int Satisfaccion
        {
            get { return this.satisfaccion; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ValoracionActividad SET satisfaccion =" + value + " WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idActividad = " + this.actividad.IdActividad + "; ");
                this.satisfaccion = value;
            }
        }

        public int Lugar
        {
            get { return this.lugar; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ValoracionActividad SET lugar =" + value + " WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idActividad = " + this.actividad.IdActividad + "; ");
                this.lugar = value;
            }
        }

        public int Horario
        {
            get { return this.horario; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ValoracionActividad SET horario =" + value + " WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idActividad = " + this.actividad.IdActividad + "; ");
                this.horario = value;
            }
        }

        public int Organizacion
        {
            get { return this.organizacion; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ValoracionActividad SET organizacion =" + value + " WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idActividad = " + this.actividad.IdActividad + "; ");
                this.organizacion = value;
            }
        }

        public bool Repetir
        {
            get { return this.repetir; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ValoracionActividad SET repetir =" + (value == true ? 1 : 0 ) + " WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idActividad = " + this.actividad.IdActividad + "; ");
                this.repetir = value;
            }
        }

        public String Comentario
        {
            get { return this.comentario; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ValoracionActividad SET comentario =" + value + " WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idActividad = " + this.actividad.IdActividad + "; ");
                this.comentario = value;
            }
        }


        public void BorrarValoracionActividad()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM ValoracionActividad WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idActividad = "+this.actividad.IdActividad+"; ");
            this.user = null;
            this.actividad = null;
            this.actividad = null;
            this.satisfaccion = -1;
            this.lugar = -1;
            this.horario = -1;
            this.organizacion = -1;
            this.repetir = false;
            this.comentario = null;
        }

        public override bool Equals(object obj)
        {
            return (obj is ValoracionActividad) && (user.Equals(((ValoracionActividad)obj).user)) && (actividad.Equals(((ValoracionActividad)obj).actividad));
        }

        public override int GetHashCode()
        {
            return user.GetHashCode() + actividad.GetHashCode();
        }


    }

}
