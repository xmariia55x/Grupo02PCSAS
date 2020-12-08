using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    class Curso
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int idCurso;
        private string profesorCurso;
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
            Object[] tupla = miBD.Select("SELECT * FROM CURSO WHERE IDCURSO = "+idCurso+"")[0];
            this.idCurso = (int)tupla[0];
            this.profesorCurso = (string)tupla[1];
            this.nombreCurso = (string)tupla[2];
            this.descripcionCurso = (string)tupla[3];
            this.fechaInicioCurso = (string)tupla[4];
            this.fechaFinCurso = (string)tupla[5];
            this.horaInicioCurso = (string)tupla[6];
            this.horaFinCurso = (string)tupla[7];
            this.aforoCurso = (int)tupla[8];
            this.online = (int)tupla[9] == 1 ? true : false;
        }

        public Curso(int idCurso, string profesorCurso, string nombreCurso, string descripcionCurso, string fechaInicioCurso
            , string fechaFinCurso, string horaInicioCurso, string horaFinCurso, int aforoCurso, bool online)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "INSERT INTO CURSO VALUES (" + idCurso+",'"+profesorCurso+"','"+nombreCurso+"','"+descripcionCurso+"','"
                +fechaInicioCurso+"','"+fechaFinCurso+"','"+horaInicioCurso+"','"+horaFinCurso+"',"+aforoCurso+ (online ? 1 : 0) + ");";
            miBD.Insert(sentencia);
            this.idCurso = idCurso;
            this.profesorCurso = profesorCurso;
            this.nombreCurso = nombreCurso;
            this.descripcionCurso = descripcionCurso;
            this.fechaInicioCurso = fechaInicioCurso;
            this.fechaFinCurso = fechaFinCurso;
            this.horaInicioCurso = horaInicioCurso;
            this.horaFinCurso = horaFinCurso;
            this.aforoCurso = aforoCurso;
            this.online = online;

        }

        public int CursoID
        {
            get { return this.idCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE CURSO SET IDCURSO=" + value + "WHERE IDCURSO = " + this.idCurso);
                this.idCurso = value;
            }
        }
        public string CursoProfesor
        {
            get { return this.profesorCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE CURSO SET PROFESORCURSO='" + value + "' WHERE IDCURSO = " + this.idCurso);
                this.profesorCurso = value;

            }
        }
        public string CursoNombre
        {
            get { return this.nombreCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE CURSO SET NOMBRECURSO='" + value + "' WHERE IDCURSO = " + this.idCurso);
                this.nombreCurso= value;

            }
        }
        public string CursoDescripcion
        {
            get { return this.descripcionCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE CURSO SET DESCRIPCIONCURSO='" + value + "' WHERE IDCURSO = " + this.idCurso);
                this.descripcionCurso = value;
            }
        }
        public string CursoFechaInicio
        {
            get { return this.fechaInicioCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE CURSO SET FECHAINICIOCURSO='" + value + "' WHERE IDCURSO = " + this.idCurso);
                this.fechaInicioCurso = value;
            }
        }
        public string CursoFechaFin
        {
            get { return this.fechaFinCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE CURSO SET FECHAFINCURSO='" + value + "' WHERE IDCURSO = " + this.idCurso);
                this.fechaFinCurso = value;
            }
        }

        public string CursoHoraInicio
        {
            get { return this.horaInicioCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE CURSO SET HORAINICIOCURSO='" + value + "' WHERE IDCURSO = " + this.idCurso);
                this.horaInicioCurso = value;
            }
        }
        public string CursoHoraFin
        {
            get { return this.horaFinCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE CURSO SET HORAFINCURSO='" + value + "' WHERE IDCURSO = " + this.idCurso);
                this.horaFinCurso = value;
            }
        }
        public string CursoLugar
        {
            get { return this.lugarCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE CURSO SET LUGARCURSO='" + value + "' WHERE IDCURSO = " + this.idCurso);
                this.lugarCurso= value;
            }
        }
        public int CursoAforo
        {
            get { return this.aforoCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE CURSO SET AFOROCURSO=" + value + " WHERE IDCURSO = " + this.idCurso);
                this.aforoCurso = value;
            }
        }
        public bool CursoOnline
        {
            get { return this.online; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE CURSO SET ONLINE='" + (value ? 1 : 0) + "' WHERE IDCURSO = " + this.idCurso);
                this.online = value;
            }
        }

        public void BorrarCurso()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM CURSO WHERE IDCURSO = " + this.idCurso);
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
