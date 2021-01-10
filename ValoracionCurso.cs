using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    class ValoracionCurso
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int id;
        private Curso curso;
        private int satisfaccion;
        private int lugar;
        private int horario;
        private int organizacion;
        private bool repetir;
        private string comentario;
        
        public ValoracionCurso(int id, Curso c)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "SELECT * FROM ValoracionCurso WHERE id = " + id + " AND idCurso = " + curso.CursoID + ";";
            object[] tupla = miBD.Select(sentencia)[0];
            this.id = (int)tupla[0];
            this.curso = new Curso((int)tupla[1]);
            this.satisfaccion = (int)tupla[2];
            this.lugar = (int)tupla[3];
            this.horario = (int)tupla[4];
            this.organizacion = (int)tupla[5];
            this.repetir = ((int)tupla[6] == 1 ? true : false);
            this.comentario = (string)tupla[7];
        }

        public ValoracionCurso(Curso curso, int satisfaccion, int lugar, int horario, int organizacion, bool repetir, string comentario)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "INSERT INTO ValoracionCurso VALUES (" + 0 + "," + curso + "," + satisfaccion + ";" + lugar + "," + horario + ";" + organizacion + ";" + (repetir == true ? 1 : 0) + ";'" + comentario + "');";
            miBD.Insert(sentencia);
            this.id = (int)miBD.SelectScalar("SELECT MAX(id) FROM ValoracionCurso;");
            this.curso = curso;
            this.satisfaccion = satisfaccion;
            this.lugar = lugar;
            this.horario = horario;
            this.organizacion = organizacion;
            this.repetir = repetir;
            this.comentario = comentario;
        }

        public int ID
        {
            get
            {
                return this.id;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE ValoracionCurso SET id = " + value + " WHERE id = " + this.id + " AND idCurso = " + this.curso.CursoID + ";";
                miBD.Update(sentencia);
                this.id = value;
            }
        }

        public Curso Curso
        {
            get
            {
                return this.curso;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE ValoracionCurso SET idCurso = " + value.CursoID + " WHERE id = " + this.id + " AND idCurso = " + this.curso.CursoID + ";";
                miBD.Update(sentencia);
                this.curso = value;
            }
        }

        public int Satisfaccion
        {
            get
            {
                return this.satisfaccion;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE ValoracionCurso SET satisfaccion = " + value + " WHERE id = " + this.id + " AND idCurso = " + this.curso.CursoID + ";";
                miBD.Update(sentencia);
                this.satisfaccion = value;
            }
        }

        public int Lugar
        {
            get
            {
                return this.lugar;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE ValoracionCurso SET lugar = " + value + " WHERE id = " + this.id + " AND idCurso = " + this.curso.CursoID + ";";
                miBD.Update(sentencia);
                this.lugar = value;
            }
        }

        public int Horario
        {
            get
            {
                return this.horario;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE ValoracionCurso SET horario = " + value + " WHERE id = " + this.id + " AND idCurso = " + this.curso.CursoID + ";";
                miBD.Update(sentencia);
                this.horario = value;
            }
        }

        public int Organizacion
        {
            get
            {
                return this.organizacion;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE ValoracionCurso SET organizacion = " + value + " WHERE id = " + this.id + " AND idCurso = " + this.curso.CursoID + ";";
                miBD.Update(sentencia);
                this.organizacion = value;
            }
        }

        public bool Repetir
        {
            get
            {
                return this.repetir;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE ValoracionCurso SET repetir = " + (value ? 1 : 0) + " WHERE id = " + this.id + " AND idCurso = " + this.curso.CursoID + ";";
                miBD.Update(sentencia);
                this.repetir = value;
            }
        }

        public String Comentario
        {
            get
            {
                return this.comentario;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE ValoracionCurso SET comentario = " + value + " WHERE id = " + this.id + " AND idCurso = " + this.curso.CursoID + ";";
                miBD.Update(sentencia);
                this.comentario = value;
            }
        }
    }
}
