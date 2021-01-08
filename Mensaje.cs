using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    class Mensaje
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private string emisor;
        private string receptor;
        private int idMensaje;
        private string asunto;
        private string cuerpo;
        private string fecha;

        public static List<Mensaje> listaMensajesRecibidos(string correo)
        {
            List<Mensaje> lista = new List<Mensaje>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (object[] tupla in miBD.Select("SELECT idMensaje FROM Mensaje WHERE receptor = '" + correo + "';"))
            {
                int idMensaje = (int)tupla[0];
                lista.Add(new Mensaje(idMensaje));
            }

            return lista;
        }


        //Select
        public Mensaje(int id)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "SELECT * FROM Mensaje WHERE idMensaje = " + id + ";";
            object[] tupla = miBD.Select(sentencia)[0];
            this.emisor = (string)tupla[0];
            this.receptor = (string)tupla[1];
            this.idMensaje = (int)tupla[2];
            this.asunto = (string)tupla[3];
            this.cuerpo= (string)tupla[4];
            this.fecha = (string)tupla[5];
        }
        //Insert
        public Mensaje(string emisor, string receptor,int idMensaje,string asunto, string cuerpo, string fecha)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "INSERT INTO Mensaje VALUES('" + emisor + "','" + receptor + "'," + idMensaje + ",'" + asunto + "','" + cuerpo + "','" + fecha + "');";
            miBD.Insert(sentencia);
            this.emisor = emisor;
            this.receptor = receptor;
            this.idMensaje = idMensaje;
            this.asunto = asunto;
            this.cuerpo = cuerpo;
            this.fecha = fecha;
        }

        public string Emisor
        {
            get
            {
                return this.emisor;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Mensaje SET emisor = " + value + " WHERE idMensaje = " + this.idMensaje + ";";
                miBD.Update(sentencia);
                this.emisor = value;
            }
        }
        public string Receptor
        {
            get { return this.receptor; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Mensaje SET receptor= " + value + " WHERE idMensaje = " + this.idMensaje + ";";
                miBD.Update(sentencia);
                this.receptor= value;
            }
        }
        public int IdMensaje
        {
            get { return this.idMensaje; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Mensaje SET idMensaje= " + value + " WHERE idMensaje = " + this.idMensaje + ";";
                miBD.Update(sentencia);
                this.idMensaje = value;
            }
        }

        public string Asunto
        {
            get { return this.asunto; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Mensaje SET asunto= " + value + " WHERE idMensaje = " + this.idMensaje + ";";
                miBD.Update(sentencia);
                this.asunto = value;
            }
        }
        public string Cuerpo
        {
            get { return this.cuerpo; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Mensaje SET cuerpo= " + value + " WHERE idMensaje = " + this.idMensaje + ";";
                miBD.Update(sentencia);
                this.cuerpo= value;
            }
        }
        public string Fecha
        {
            get { return this.fecha; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Mensaje SET fecha= " + value + " WHERE idMensaje = " + this.idMensaje + ";";
                miBD.Update(sentencia);
                this.fecha = value;
            }
        }

        public void BorrarMensaje()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "DELETE FROM MENSAJE "
                + "WHERE idMensaje=" + this.idMensaje+ ";";
            miBD.Delete(sentencia);

            this.emisor = null;
            this.receptor = null;
            this.idMensaje = -1;
            this.asunto = null;
            this.cuerpo = null;
            this.fecha = null;
        }
    }
}
