using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    class ActividadesRealizadas
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int idActividad;
        private string correo;

        public ActividadesRealizadas(int numeroActividad, string email)
        { //Constructor del select
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "SELECT * FROM ActividadesRealizadas WHERE idActividad = " + numeroActividad + " AND correo = '" + email + "';";
            object[] tupla = miBD.Select(sentencia)[0];

            if(tupla != null)
            {
                this.idActividad = (int)tupla[0];
                this.correo = (string)tupla[1];
            }
            else
            {
                sentencia = "INSERT INTO ActividadesRealizadas VALUES (" + numeroActividad + ", '" + email + "');";
                miBD.Insert(sentencia);
                this.idActividad = numeroActividad;
                correo = email;
            }
        }

        public int IdActividad
        {
            get { return idActividad; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE ActividadesRealizadas SET idActividad = " + value + " WHERE idActividad = " + idActividad + " AND correo = '" + correo + "';";
                miBD.Update(sentencia);
                this.idActividad = value;
            }
        }

        public string Correo
        {
            get { return correo; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE ActividadesRealizadas SET correo = '" + value + "' WHERE idActividad = " + idActividad + " AND correo = '" + correo + "';";
                miBD.Update(sentencia);
                correo = value;
            }
        }

        public void BorrarActividadRealizada()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "DELETE FROM ActividadesRealizadas "
                + "WHERE idActividad=" + idActividad + " AND correo = '" + correo + "';";
            miBD.Delete(sentencia);

            idActividad = -1;
            correo = null;
        }

        public override bool Equals(object obj)
        {
            return (obj is ActividadesRealizadas) && (idActividad.Equals(((ActividadesRealizadas)obj).idActividad)) && (correo.Equals(((ActividadesRealizadas)obj).correo));
        }

        public override int GetHashCode()
        {
            return idActividad.GetHashCode() + correo.GetHashCode();
        }
    }
}
