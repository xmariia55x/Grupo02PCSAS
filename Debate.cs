using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
     public class Debate
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int id;
        private string creadorDebate;
        private string asuntoDebate;
        private string mensajeDebate;
        private string fechaPublicacion;

        public Debate(int id)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "SELECT * FROM Debate WHERE id = " + id + ";";
            object[] tupla = miBD.Select(sentencia)[0];

            this.creadorDebate = (string)tupla[1];
            this.asuntoDebate = (string)tupla[2];
            this.mensajeDebate = (string)tupla[3];
            this.fechaPublicacion = (string)tupla[4];
        }

        public Debate(string creador, string asunto, string mensaje, string fecha)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "INSERT INTO Debate VALUES ('" + creador + "', '" + asunto + "','" + mensaje + "','" + fecha + "');";
            miBD.Insert(sentencia);
            this.id = (int) miBD.SelectScalar("SELECT MAX(id) FROM Debate");
            this.creadorDebate = creador;
            this.asuntoDebate = asunto;
            this.mensajeDebate = mensaje;
            this.fechaPublicacion = fecha;
        }

        public int ID
        {
            get { return this.id; }
           
        }

        public string CreadorDebate
        {
            get { return creadorDebate; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Debate SET creadorDebate = '" + value + "' WHERE id = " + id + ";";
                miBD.Update(sentencia);
                creadorDebate = value;
            }
        }

        public string AsuntoDebate
        {
            get { return asuntoDebate; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Debate SET asuntoDebate = '" + value + "' WHERE id = " + id + ";";
                miBD.Update(sentencia);
                asuntoDebate = value;
            }
        }

        public string MensajeDebate
        {
            get { return mensajeDebate; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Debate SET mensajeDebate = '" + value + "' WHERE id = " + id + ";";
                miBD.Update(sentencia);
                mensajeDebate = value;
            }
        }

        public string FechaPublicacion
        {
            get { return fechaPublicacion; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Debate SET fechaPublicacion = '" + value + "' WHERE id = " + id + ";";
                miBD.Update(sentencia);
                fechaPublicacion = value;
            }
        }

        public void BorrarDebate()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "DELETE * FROM Debate WHERE id = " + id + ";";
            miBD.Delete(sentencia);
            creadorDebate = null;
            asuntoDebate = null;
            mensajeDebate = null;
            fechaPublicacion = null;
        }

        public override bool Equals(object obj)
        {
            return (obj is Debate) && (id == ((Debate)obj).id);
        }

        public override int GetHashCode()
        {
            return this.id;
        }
    }
}
