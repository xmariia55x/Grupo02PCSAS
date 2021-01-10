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

        public MaterialCurso(int idCurso)
        {
            //Select
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "SELECT * FROM MaterialCurso WHERE  idCurso = " + idCurso + ";";
            object[] tupla = miBD.Select(sentencia)[0];

            this.enlace = (string)tupla[1];
            this.idCurso = idCurso;
        }

        public MaterialCurso(string enlace, Curso curso)
        {
            //Insert
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "INSERT INTO MaterialCurso VALUES ('" + enlace + "'," + curso.CursoID + ");";
            miBD.Insert(sentencia);

           
            this.enlace = enlace;
            this.idCurso = curso.CursoID;
        }

        

        public string Enlace
        {
            get { return enlace; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE MaterialCurso SET enlace = '" + value + "' WHERE idCurso = " + idCurso + ";";
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
                string sentencia = "UPDATE MaterialCurso SET idCurso = " + value + " WHERE idCurso = " + idCurso + ";";
                miBD.Update(sentencia);

                this.idCurso = value;

            }
        }

        public void BorrarMaterialCurso()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "DELETE FROM MaterialCurso WHERE idCurso = " + idCurso + ";";
            miBD.Delete(sentencia);
            
            idCurso = -1;
            enlace = null;
        }

        public override bool Equals(object obj)
        {
            return (obj is MaterialCurso) && (idCurso.Equals(((MaterialCurso)obj).idCurso));
        }

        public override int GetHashCode()
        {
            return idCurso.GetHashCode();
        }
    }
}
