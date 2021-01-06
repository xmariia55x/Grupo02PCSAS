using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    class MaterialCurso
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private string nombre;
        private string enlace;
        private int idCurso;

        public MaterialCurso(string nombre, int idCurso)
        {
            //Select
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "SELECT * FROM MaterialCurso WHERE nombre = '" + nombre + "' AND idCurso = " + idCurso + ";";
            object[] tupla = miBD.Select(sentencia)[0];

            this.nombre = nombre;
            this.enlace = (string)tupla[1];
            this.idCurso = idCurso;
        }

        public MaterialCurso(string nombre, string enlace, Curso curso)
        {
            //Insert
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "INSERT INTO MaterialCurso VALUES ('" + nombre + "','" + enlace + "'," + curso.CursoID + ");";
            miBD.Insert(sentencia);

            this.nombre = nombre;
            this.enlace = enlace;
            this.idCurso = curso.CursoID;
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE MaterialCurso SET nombre = '" + value + "' WHERE nombre = '" + nombre + "' AND idCurso = " + idCurso + ";";
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
                string sentencia = "UPDATE MaterialCurso SET enlace = '" + value + "' WHERE nombre = '" + nombre + "' AND idCurso = " + idCurso + ";";
                miBD.Update(sentencia);

                this.enlace = value;

            }
        }

        public int IdCurso
        {
            get { return idCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE MaterialCurso SET idCurso = " + value + " WHERE nombre = '" + nombre + "' AND idCurso = " + idCurso + ";";
                miBD.Update(sentencia);

                this.idCurso = value;

            }
        }

        public void BorrarMaterialCurso()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "DELETE FROM MaterialCurso WHERE nombre = '" + nombre + "' AND idCurso = " + idCurso + ";";
            miBD.Delete(sentencia);
            nombre = null;
            idCurso = -1;
            enlace = null;
        }

        public override bool Equals(object obj)
        {
            return (obj is MaterialCurso) && (idCurso.Equals(((MaterialCurso)obj).idCurso)) && (nombre.Equals(((MaterialCurso)obj).nombre));
        }

        public override int GetHashCode()
        {
            return idCurso.GetHashCode() + nombre.GetHashCode();
        }
    }
}
