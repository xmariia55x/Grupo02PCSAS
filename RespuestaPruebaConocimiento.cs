using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    
    class RespuestaPruebaConocimiento
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private string correoUsuario;
        private int idPrueba;
        private string respuestaPregunta1, respuestaPregunta2, respuestaPregunta3, respuestaPregunta4, respuestaPregunta5;


        public static List<string> usuariosQueHanRellenadoPrueba(Curso curso)
        {
            List<string> lista = new List<string>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (object[] tupla in miBD.Select("SELECT correoUsuario FROM RespuestaPrueba WHERE idPrueba = " + curso.CursoID + ";")) 
            {
                string correo = (string)tupla[0];
                lista.Add(correo);
            }

            return lista;
        }
        public RespuestaPruebaConocimiento (string correo, int id)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "SELECT * FROM RespuestaPrueba WHERE correoUsuario = '" + correo + "' AND idPrueba = " + id + ";";
            Object[] tupla = miBD.Select(sentencia)[0];
            this.correoUsuario = correo;
            this.idPrueba = id;
            this.respuestaPregunta1 = (string)tupla[2];
            this.respuestaPregunta2 = (string)tupla[3];
            this.respuestaPregunta3 = (string)tupla[4];
            this.respuestaPregunta4 = (string)tupla[5];
            this.respuestaPregunta5 = (string)tupla[6];
        }

        public RespuestaPruebaConocimiento (string correo, int id, string rp1, string rp2, string rp3, string rp4, string rp5)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "INSERT INTO RespuestaPrueba VALUES ('" + correo + "'," + id + ", '" + rp1 + "','" + rp2 + "','" + rp3 + "','" + rp4 + "','" + rp5 + "');";
            miBD.Insert(sentencia);
            this.correoUsuario = correo;
            this.idPrueba = id;
            this.respuestaPregunta1 = rp1;
            this.respuestaPregunta2 = rp2;
            this.respuestaPregunta3 = rp3;
            this.respuestaPregunta4 = rp4;
            this.respuestaPregunta5 = rp5;
        }

        public int IDPrueba
        {
            get { return this.idPrueba; }
            /*set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE RespuestaPrueba SET idPrueba = " + value + " WHERE idPrueba = " + this.idPrueba + " AND correoUsuario = '" + this.correoUsuario + "';");
                this.idPrueba = value;
            } --> LOS DEJO POR SI HICIERAN FALTA PERO NO TIENE SENTIDO EN LA APP*/
        }

        public string CorreoUsuario
        {
            get
            {
                return this.correoUsuario;
            }
            /*set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE RespuestaPrueba SET correoUsuario = '" + value + "' WHERE idPrueba = " + this.idPrueba + " AND correoUsuario = '" + this.correoUsuario + "';");
                this.correoUsuario = value;
            }*/
        }

        public string RespuestaPreguntaUno
        {
            get
            {
                return this.respuestaPregunta1;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE RespuestaPrueba SET res1 = '" + value + "' WHERE idPrueba = " + this.idPrueba + " AND correoUsuario = '" + this.correoUsuario + "';");
                this.respuestaPregunta1 = value;
            }
        }

        public string RespuestaPreguntaDos
        {
            get
            {
                return this.respuestaPregunta2;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE RespuestaPrueba SET res2 = '" + value + "' WHERE idPrueba = " + this.idPrueba + " AND correoUsuario = '" + this.correoUsuario + "';");
                this.respuestaPregunta2 = value;
            }
        }

        public string RespuestaPreguntaTres
        {
            get
            {
                return this.respuestaPregunta3;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE RespuestaPrueba SET res3 = '" + value + "' WHERE idPrueba = " + this.idPrueba + " AND correoUsuario = '" + this.correoUsuario + "';");
                this.respuestaPregunta3 = value;
            }
        }

        public string RespuestaPreguntaCuatro
        {
            get
            {
                return this.respuestaPregunta4;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE RespuestaPrueba SET res4 = '" + value + "' WHERE idPrueba = " + this.idPrueba + " AND correoUsuario = '" + this.correoUsuario + "';");
                this.respuestaPregunta4 = value;
            }
        }

        public string RespuestaPreguntaCinco
        {
            get
            {
                return this.respuestaPregunta5;
            }

            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE RespuestaPrueba SET res5 = '" + value + "' WHERE idPrueba = " + this.idPrueba + " AND correoUsuario = '" + this.correoUsuario + "';");
                this.respuestaPregunta5 = value;
            }
        }

        public void BorrarRespuestaPruebaConocimiento()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "DELETE FROM RespuestaPrueba WHERE idPrueba = " + this.idPrueba + " AND correoUsuario = '" + this.correoUsuario + "';";
            miBD.Delete(sentencia);
            this.idPrueba = -1;
            this.correoUsuario = null;
            this.respuestaPregunta1 = null;
            this.respuestaPregunta2 = null;
            this.respuestaPregunta3 = null;
            this.respuestaPregunta4 = null;
            this.respuestaPregunta5 = null;
        }
    }
}
