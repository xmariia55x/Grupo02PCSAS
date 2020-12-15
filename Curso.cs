using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    public class Curso
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int idCurso;
        private Usuario profesorCurso;
        private string nombreCurso;
        private string descripcionCurso;
        private string fechaInicioCurso;
        private string fechaFinCurso;
        private string horaInicioCurso;
        private string horaFinCurso;
        private string lugarCurso;
        private int aforoCurso;
        private bool online;

        public Curso(int idCurso)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM Curso WHERE idCurso = " + idCurso+";")[0];
            this.idCurso = (int)tupla[0];
            this.profesorCurso = new Usuario((string)tupla[1]);
            this.nombreCurso = (string)tupla[2];
            this.descripcionCurso = (string)tupla[3];
            this.fechaInicioCurso = (string)tupla[4];
            this.fechaFinCurso = (string)tupla[5];
            this.horaInicioCurso = (string)tupla[6];
            this.horaFinCurso = (string)tupla[7];
            this.lugarCurso = (string)tupla[8];
            this.aforoCurso = (int)tupla[9];
            this.online = (int)tupla[10] == 1 ? true : false;
        }

        public Curso(Usuario profesorCurso, string nombreCurso, string descripcionCurso, string fechaInicioCurso
            , string fechaFinCurso, string horaInicioCurso, string horaFinCurso, string lugarCurso, int aforoCurso, bool online)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
           
            string sentencia = "INSERT INTO Curso VALUES (" + 0 + ",'" + profesorCurso.CorreoUsuario+"','"+nombreCurso+"','"+descripcionCurso+"','"
                +fechaInicioCurso+"','"+fechaFinCurso+"','"+horaInicioCurso+"','"+horaFinCurso+ "','" + lugarCurso + "',"+aforoCurso+ "," + (online ? 1 : 0) + ");";
            miBD.Insert(sentencia);
            this.idCurso = (int)miBD.SelectScalar("SELECT MAX(idCurso) FROM Curso;");
            this.profesorCurso = profesorCurso;
            this.nombreCurso = nombreCurso;
            this.descripcionCurso = descripcionCurso;
            this.fechaInicioCurso = fechaInicioCurso;
            this.fechaFinCurso = fechaFinCurso;
            this.horaInicioCurso = horaInicioCurso;
            this.horaFinCurso = horaFinCurso;
            this.lugarCurso = lugarCurso;
            this.aforoCurso = aforoCurso;
            this.online = online;

        }
        public Curso(int idCurso)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM Curso WHERE idCurso = " + idCurso + ";")[0];
            this.idCurso = (int)tupla[0];
            this.profesorCurso = new Usuario((string)tupla[1]);
            this.nombreCurso = (string)tupla[2];
            this.descripcionCurso = (string)tupla[3];
            this.fechaInicioCurso = (string)tupla[4];
            this.fechaFinCurso = (string)tupla[5];
            this.horaInicioCurso = (string)tupla[6];
            this.horaFinCurso = (string)tupla[7];
            this.lugarCurso = (string)tupla[8];
            this.aforoCurso = (int)tupla[9];
            this.online = (int)tupla[10] == 1 ? true : false;
        }

        public int CursoID
        {
            get { return this.idCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Curso SET idCurso =" + value + "WHERE idCurso = " + this.idCurso);
                this.idCurso = value;
            }
        }
        public Usuario CursoProfesor
        {
            get { return this.profesorCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Curso SET profesorCurso='" + value.CorreoUsuario + "' WHERE idCurso = " + this.idCurso);
                this.profesorCurso = value;

            }
        }
        public string CursoNombre
        {
            get { return this.nombreCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Curso SET nombreCurso='" + value + "' WHERE idCurso = " + this.idCurso);
                this.nombreCurso= value;

            }
        }
        public string CursoDescripcion
        {
            get { return this.descripcionCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Curso SET descripcionCurso='" + value + "' WHERE idCurso = " + this.idCurso);
                this.descripcionCurso = value;
            }
        }
        public string CursoFechaInicio
        {
            get { return this.fechaInicioCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Curso SET fechaInicioCurso='" + value + "' WHERE idCurso = " + this.idCurso);
                this.fechaInicioCurso = value;
            }
        }
        public string CursoFechaFin
        {
            get { return this.fechaFinCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Curso SET fechaFinCurso='" + value + "' WHERE idCurso = " + this.idCurso);
                this.fechaFinCurso = value;
            }
        }

        public string CursoHoraInicio
        {
            get { return this.horaInicioCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Curso SET horaInicioCurso ='" + value + "' WHERE idCurso = " + this.idCurso);
                this.horaInicioCurso = value;
            }
        }
        public string CursoHoraFin
        {
            get { return this.horaFinCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Curso SET horaFinCurso='" + value + "' WHERE idCurso = " + this.idCurso);
                this.horaFinCurso = value;
            }
        }
        public string CursoLugar
        {
            get { return this.lugarCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Curso SET lugarCurso ='" + value + "' WHERE idCurso = " + this.idCurso);
                this.lugarCurso= value;
            }
        }
        public int CursoAforo
        {
            get { return this.aforoCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Curso SET aforoCurso =" + value + " WHERE idCurso = " + this.idCurso);
                this.aforoCurso = value;
            }
        }
        public bool CursoOnline
        {
            get { return this.online; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Curso SET onlineCurso ='" + (value ? 1 : 0) + "' WHERE idCurso = " + this.idCurso);
                this.online = value;
            }
        }

        public void BorrarCurso()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM Curso WHERE idCurso = " + this.idCurso);
            this.idCurso = -1;
            this.profesorCurso = null;
            this.nombreCurso = null;
            this.descripcionCurso = null;
            this.fechaInicioCurso = null;
            this.fechaFinCurso = null;
            this.horaInicioCurso = null;
            this.horaFinCurso = null;
            this.lugarCurso = null;
            this.aforoCurso = -1;
            this.online = false;

        }

        public override bool Equals(object obj)
        {
            return (obj is Curso) && (idCurso.Equals(((Curso)obj).idCurso));
        }

        public override int GetHashCode()
        {
            return idCurso.GetHashCode();
        }


    }
    






}
