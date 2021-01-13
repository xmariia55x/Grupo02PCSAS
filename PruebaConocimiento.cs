using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    public class PruebaConocimiento
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        //Formato de pi
        //pregunta;respuesta1;respuesta2;respuesta3;indexRespuestaCorrecta(1,2,3)

        private string p1;
        private string p2;
        private string p3;
        private string p4;
        private string p5;
        private int idCursoPrueba;

        public PruebaConocimiento(int idCursoPrueba)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "SELECT * FROM PruebaConocimiento WHERE idCursoPrueba = " + idCursoPrueba + ";";
            object[] tupla = miBD.Select(sentencia)[0];

            this.p1 = (string) tupla[0];
            this.p2 = (string) tupla[1];
            this.p3 = (string) tupla[2];
            this.p4 = (string) tupla[3];
            this.p5 = (string) tupla[4];
            this.idCursoPrueba = (int) tupla[5];
        }

        public PruebaConocimiento(string p1, string p2, string p3, string p4, string p5, int idCursoPrueba)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "INSERT INTO PruebaConocimiento VALUES('" + p1 + "','" + p2 + "','" + p3 + "','" + p4 + "','" + p5 + "'," + idCursoPrueba + ");";
            miBD.Insert(sentencia);

            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            this.idCursoPrueba = idCursoPrueba;
        }

        public string P1
        {
            get { return p1; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE PruebaConocimiento SET P1 = '"+value+"' WHERE idCursoPrueba = " +this.idCursoPrueba+ ";";
                miBD.Update(sentencia);

                this.p1 = value;
            }
        }

        public string P2
        {
            get { return p2; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE PruebaConocimiento SET P2 = '" + value + "' WHERE idCursoPrueba = " + this.idCursoPrueba + ";";
                miBD.Update(sentencia);

                this.p2 = value;
            }
        }

        public string P3
        {
            get { return p3; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE PruebaConocimiento SET P3 = '" + value + "' WHERE idCursoPrueba = " + this.idCursoPrueba + ";";
                miBD.Update(sentencia);

                this.p3 = value;
            }
        }

        public string P4
        {
            get { return p4; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE PruebaConocimiento SET P4 = '" + value + "' WHERE idCursoPrueba = " + this.idCursoPrueba + ";";
                miBD.Update(sentencia);

                this.p4 = value;
            }
        }

        public string P5
        {
            get { return p5; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE PruebaConocimiento SET P5 = '" + value + "' WHERE idCursoPrueba = " + this.idCursoPrueba + ";";
                miBD.Update(sentencia);

                this.p1 = value;
            }
        }

        public int IdCursoPrueba
        {
            get
            {
                return this.idCursoPrueba;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE PruebaConocimiento SET idCursoPrueba = '" + value + "' WHERE idCursoPrueba = " + this.idCursoPrueba + ";";
                miBD.Update(sentencia);

                this.idCursoPrueba = value;
            }
        }

        public void BorrarPrueba()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "DELETE FROM PruebaConocimiento WHERE idCursoPrueba = " + this.idCursoPrueba + ";";
            miBD.Delete(sentencia);

            this.p1 = null;
            this.p2 = null;
            this.p3 = null;
            this.p4 = null;
            this.p5 = null;
            this.idCursoPrueba = -1;
        }

        public override bool Equals(object obj)
        {
            return (obj is PruebaConocimiento) && (this.idCursoPrueba.Equals(((PruebaConocimiento)obj).idCursoPrueba));
        }

        public override int GetHashCode()
        {
            return this.idCursoPrueba.GetHashCode();
        }

        public static Boolean hayPruebaConocimiento(Curso curso)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "SELECT * FROM PruebaConocimiento WHERE idCursoPrueba = " + curso.CursoID + ";";
            return miBD.Select(sentencia).Count > 0;
        }
    }
}
