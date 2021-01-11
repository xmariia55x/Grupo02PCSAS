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

        private string enlace;
        private int idCurso;
        private String nombre;

        public MaterialCurso(int idCurso, String nombre)
        {
           
            //Select
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "SELECT * FROM MaterialCurso WHERE  idCurso = " + idCurso + "  AND nombre = '"+ nombre + "';";
            object[] tupla = miBD.Select(sentencia)[0];

            this.idCurso = idCurso;
            this.nombre = nombre;
            this.enlace = (string)tupla[2];

        }

        public MaterialCurso(string enlace, Curso curso, String nombre)
        {
            //Insert
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "INSERT INTO MaterialCurso VALUES ("+ curso.CursoID +", '"+ nombre + "' ,'" + enlace + "');";
            miBD.Insert(sentencia);

           
            this.enlace = enlace;
            this.idCurso = curso.CursoID;
            this.nombre = nombre;
        }

        

        public string Enlace
        {
            get { return enlace; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE MaterialCurso SET enlace = '" + value + "' WHERE idCurso = " + idCurso + " AND nombre = '" + nombre + "';";
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
                string sentencia = "UPDATE MaterialCurso SET idCurso = " + value + " WHERE idCurso = " + idCurso + " AND nombre = '" + nombre + "';";
                miBD.Update(sentencia);

                this.idCurso = value;

            }
        }

        public String Nombre
        {
            get { return nombre; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE MaterialCurso SET nombre = " + value + " WHERE idCurso = " + idCurso + " AND nombre = '" + nombre + "';";
                miBD.Update(sentencia);

                this.nombre = value;

            }
        }

        public void BorrarMaterialCurso()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "DELETE FROM MaterialCurso WHERE idCurso = " + idCurso + " AND nombre = '" + nombre + "';";
            miBD.Delete(sentencia);
            
            idCurso = -1;
            enlace = null;
            nombre = null;
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
