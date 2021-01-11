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

        private Usuario user;
        private Curso curso;
        private int satisfaccion;
        private int lugar;
        private int horario;
        private int organizacion;
        private bool repetir;
        private string comentario;

        public static List<Curso> listaCursosValorados(Usuario u)
        {
            List<Curso> lista = new List<Curso>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (object[] tupla in miBD.Select("SELECT idCurso FROM ValoracionCurso WHERE correoUsuario = '" + u.CorreoUsuario + "';"))
            {
                int idCurso = (int)tupla[0];
                lista.Add(new Curso(idCurso));
            }

            return lista;
        }
        
        public ValoracionCurso(Usuario user, Curso c)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "SELECT * FROM ValoracionCurso WHERE correoUsuario = '" + user.CorreoUsuario + "' AND idCurso = " + c.CursoID + ";";
            object[] tupla = miBD.Select(sentencia)[0];
            this.user = new Usuario((string)tupla[0]);
            this.curso = new Curso((int)tupla[1]);
            this.satisfaccion = (int)tupla[2];
            this.lugar = (int)tupla[3];
            this.horario = (int)tupla[4];
            this.organizacion = (int)tupla[5];
            this.repetir = ((int)tupla[6] == 1 ? true : false);
            this.comentario = (string)tupla[7];
        }

        public ValoracionCurso(Usuario usuario, Curso curso, int satisfaccion, int lugar, int horario, int organizacion, bool repetir, string comentario)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "INSERT INTO ValoracionCurso VALUES ('" + usuario.CorreoUsuario + "'," + curso.CursoID + "," + satisfaccion + "," + lugar + "," + horario + "," + organizacion + "," + (repetir == true ? 1 : 0) + ",'" + comentario + "');";
            miBD.Insert(sentencia);
            this.user = usuario;
            this.curso = curso;
            this.satisfaccion = satisfaccion;
            this.lugar = lugar;
            this.horario = horario;
            this.organizacion = organizacion;
            this.repetir = repetir;
            this.comentario = comentario;
        }

        public Usuario UsuarioValoracion
        {
            get
            {
                return this.user;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE ValoracionCurso SET correoUsuario = '" + value + "' WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idCurso = " + this.curso.CursoID + ";";
                miBD.Update(sentencia);
                this.user = value;
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
                string sentencia = "UPDATE ValoracionCurso SET idCurso = " + value.CursoID + " WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idCurso = " + this.curso.CursoID + ";";
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
                string sentencia = "UPDATE ValoracionCurso SET satisfaccion = " + value + " WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idCurso = " + this.curso.CursoID + ";";
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
                string sentencia = "UPDATE ValoracionCurso SET lugar = " + value + " WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idCurso = " + this.curso.CursoID + ";";
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
                string sentencia = "UPDATE ValoracionCurso SET horario = " + value + " WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idCurso = " + this.curso.CursoID + ";";
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
                string sentencia = "UPDATE ValoracionCurso SET organizacion = " + value + " WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idCurso = " + this.curso.CursoID + ";";
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
                string sentencia = "UPDATE ValoracionCurso SET repetir = " + (value ? 1 : 0) + " WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idCurso = " + this.curso.CursoID + ";";
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
                string sentencia = "UPDATE ValoracionCurso SET comentario = " + value + " WHERE correoUsuario = '" + this.user.CorreoUsuario + "' AND idCurso = " + this.curso.CursoID + ";";
                miBD.Update(sentencia);
                this.comentario = value;
            }
        }
    }
}
