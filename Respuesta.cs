using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    class Respuesta
    {

        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int idRespuesta;
        private int idDebate;
        private Debate debate;
        private String correoUsuario;
        private Usuario creador;
        private String mensaje;
        private String fecha;

        public Respuesta(int idRespuesta)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM Respuesta WHERE idRespuesta = " + idRespuesta + ";")[0];
            this.idRespuesta = (int)tupla[0];
            this.debate = new Debate((int)tupla[1]);
            this.creador = new Usuario((string)tupla[2]);
            this.mensaje = (string)tupla[3];
            this.fecha = (string)tupla[4];

        }

        public Respuesta(int idRespuesta, Debate debate, Usuario creador, string mensaje, string fecha)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            string sentencia = "INSERT INTO Respuesta VALUES (" + 0 + "," + debate.ID + ", '" + creador.CorreoUsuario + "', '" + mensaje + "','" + fecha + "');";
            miBD.Insert(sentencia);

            this.idRespuesta = (int)miBD.SelectScalar("SELECT MAX(idRespuesta) FROM Respuesta;"); ;
            this.idDebate = debate.ID;
            this.debate = debate;
            this.correoUsuario = creador.CorreoUsuario;
            this.mensaje = mensaje;
            this.creador = creador;
            this.fecha = fecha;
        }




        public int IDRespuesta
        {
            get { return this.idRespuesta; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Respuesta SET idDebate =" + value + "WHERE idDebate = " + this.idRespuesta);
                this.idRespuesta = value;
            }
        }
        public Debate DebateRespuesta
        {
            get { return this.debate; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Respuesta SET idDebate='" + value.ID + "' WHERE idRespuesta = " + this.idRespuesta);
                this.debate = new Debate(value.ID);
                this.idDebate = value.ID;
            }
        }
        public Usuario CreadorRespuesta
        {
            get { return this.creador; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Respuesta SET correoUsuario='" + value.CorreoUsuario + "' WHERE idRespuesta = " + this.idRespuesta);
                this.creador = new Usuario(value.CorreoUsuario);
                this.correoUsuario = value.CorreoUsuario;
            }
        }
        public string MensajeRespuesta
        {
            get { return this.mensaje; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Respuesta SET mensaje='" + value + "' WHERE idRespuesta = " + this.idRespuesta);
                this.mensaje = value;
            }
        }
        public string FechaRespuesta
        {
            get { return this.fecha; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Respuesta SET fecha='" + value + "' WHERE idRespuesta = " + this.idRespuesta);
                this.fecha = value;
            }
        }





        public void BorrarRespuesta()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE * FROM Recurso WHERE idRespuesta = " + this.idRespuesta);
            this.idRespuesta = -1;
            this.idDebate = -1;
            this.debate = null;
            this.correoUsuario = null;
            this.mensaje = null;
            this.creador = null;
            this.fecha = null;

        }

        public override bool Equals(object obj)
        {
            return (obj is Curso) && (idRespuesta.Equals(((Respuesta)obj).IDRespuesta));
        }

        public override int GetHashCode()
        {
            return idRespuesta.GetHashCode();
        }


    }
}
