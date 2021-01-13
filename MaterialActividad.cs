using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    class MaterialActividad
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int idActividad;
        private string enlace;
        private string nombre;

        public MaterialActividad(string nombre, int idActividad)
        {
            //Select
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "SELECT * FROM MaterialActividad WHERE nombre = '" + nombre + "' AND idActividad = " + idActividad + ";";
            object[] tupla = miBD.Select(sentencia)[0];

            this.idActividad = (int)tupla[0];
            this.nombre = (string)tupla[1];
            this.enlace = (string)tupla[2];
        }

        public MaterialActividad(string nombre, string enlace, Actividad actividad)
        {
            //Insert
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "INSERT INTO MaterialActividad VALUES (" + actividad.IdActividad + ",'" + nombre + "','" + enlace + "');";
            miBD.Insert(sentencia);

            this.nombre = nombre;
            this.enlace = enlace;
            this.idActividad = actividad.IdActividad;
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE MaterialActividad SET nombre = '" + value + "' WHERE nombre = '" + this.nombre + "' AND idActividad = " + this.idActividad + ";";
                miBD.Update(sentencia);

                this.nombre = value;

            }
        }

        public string Enlace
        {
            get { return enlace; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE MaterialActividad SET enlace = '" + value + "' WHERE nombre = '" + this.nombre + "' AND idActividad = " + this.idActividad + ";";
                miBD.Update(sentencia);

                this.enlace = value;

            }
        }

        public int IdActividad
        {
            get { return idActividad; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE MaterialActividad SET idActividad = " + value + " WHERE nombre = '" + this.nombre + "' AND idActividad = " + this.idActividad + ";";
                miBD.Update(sentencia);

                this.idActividad = value;

            }
        }

        public void BorrarMaterialActividad()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "DELETE FROM MaterialActividad WHERE nombre = '" + this.nombre + "' AND idActividad = " + this.idActividad + ";";
            miBD.Delete(sentencia);
            nombre = null;
            idActividad = -1;
            enlace = null;
        }

        public override bool Equals(object obj)
        {
            return (obj is MaterialActividad) && (this.idActividad.Equals(((MaterialActividad)obj).idActividad)) && (nombre.Equals(((MaterialActividad)obj).nombre));
        }

        public override int GetHashCode()
        {
            return this.idActividad.GetHashCode() + this.nombre.GetHashCode();
        }
    }
}
