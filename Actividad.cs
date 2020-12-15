using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    public class Actividad
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int idActividad;
        private Usuario usuarioCreador;
        private string nombreActividad;
        private string descripcionActividad;
        private string fechaInicioActividad, fechaFinActividad;
        private string horaInicioActividad, horaFinActividad;
        private string lugarActividad;
        private int aforoActividad;

        public Actividad(int numeroActividad)
        { //Constructor del select
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "SELECT * FROM Actividad WHERE idActividad = " + numeroActividad + ";";
            object[] tupla = miBD.Select(sentencia)[0];

            this.idActividad = (int)tupla[0];
            this.usuarioCreador = new Usuario((string)tupla[1]);
            this.nombreActividad = (string)tupla[2];
            this.descripcionActividad = (string)tupla[3];
            this.fechaInicioActividad = (string)tupla[4];
            this.fechaFinActividad = (string)tupla[5];
            this.horaInicioActividad = (string)tupla[6];
            this.horaFinActividad = (string)tupla[7];
            this.lugarActividad = (string)tupla[8];
            this.aforoActividad = (int)tupla[9];
        }

        public Actividad(Usuario user, string nombreAct, string descrAct, string fIniAct, string fFinAct, string hIniAct, string hFinAct, string lugarAct, int aforoPermitido)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "INSERT INTO Actividad VALUES (" + 0 + ",'" + user.CorreoUsuario + "','" + nombreAct + "','"+ descrAct + "','" + fIniAct 
                + "','" + fFinAct + "','" + hIniAct + "','" + hFinAct + "','" + lugarAct + "'," + aforoPermitido + ");";
            miBD.Insert(sentencia);
            this.idActividad = (int) miBD.SelectScalar("SELECT MAX(idActividad) FROM Actividad;");
            this.usuarioCreador = user;
            this.nombreActividad = nombreAct;
            this.descripcionActividad = descrAct;
            this.fechaInicioActividad = fIniAct;
            this.fechaFinActividad = fFinAct;
            this.horaInicioActividad = hIniAct;
            this.horaFinActividad = hFinAct;
            this.lugarActividad = lugarAct;
            this.aforoActividad = aforoPermitido;
        }

        public int IdActividad
        {
            get { return idActividad;  }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Actividad SET idActividad = " + value + " WHERE idActividad = " + idActividad + ";";
                miBD.Update(sentencia);
                this.idActividad = value;
            }
        }
        public Usuario UsuarioCreador
        {
            get { return usuarioCreador; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Actividad SET creadorActividad = '" + value.CorreoUsuario + "' WHERE idActividad = " + idActividad + ";";
                miBD.Update(sentencia);
                usuarioCreador = value;
            }
        }

        public string NombreActividad
        {
            get { return nombreActividad;  }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Actividad SET nombreActividad = '" + value + "' WHERE idActividad = " + idActividad + ";";
                miBD.Update(sentencia);
                nombreActividad = value;
            }
        }

        public string DescripcionActividad
        {
            get { return descripcionActividad; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Actividad SET descripcionActividad = '" + value + "' WHERE idActividad = " + idActividad + ";";
                miBD.Update(sentencia);
                descripcionActividad = value;
            }
        }

        public string FechaInicioActividad
        {
            get { return fechaInicioActividad; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Actividad SET fechaInicioActividad = '" + value + "' WHERE idActividad = " + idActividad + ";";
                miBD.Update(sentencia);
                fechaInicioActividad = value;
            }
        }

        public string FechaFinActividad
        {
            get { return fechaFinActividad; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Actividad SET fechaFinActividad = '" + value + "' WHERE idActividad = " + idActividad + ";";
                miBD.Update(sentencia);
                fechaFinActividad = value;
            }
        }

        public string HoraInicioActividad
        {
            get { return horaInicioActividad; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Actividad SET horaInicioActividad = '" + value + "' WHERE idActividad = " + idActividad + ";";
                miBD.Update(sentencia);
                horaInicioActividad = value;
            }
        }

        public string HoraFinActividad
        {
            get { return horaFinActividad; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Actividad SET horaFinActividad = '" + value + "' WHERE idActividad = " + idActividad + ";";
                miBD.Update(sentencia);
                horaFinActividad = value;
            }
        }

        public string LugarActividad
        {
            get { return lugarActividad; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Actividad SET lugarActividad = '" + value + "' WHERE idActividad = " + idActividad + ";";
                miBD.Update(sentencia);
                lugarActividad = value;
            }
        }

        public int AforoActividad
        {
            get { return aforoActividad; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Actividad SET aforoActividad = '" + value + "' WHERE idActividad = " + idActividad + ";";
                miBD.Update(sentencia);
                aforoActividad = value;
            }
        }

        public void BorrarActividad()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "DELETE FROM Actividad "
                + "WHERE idActividad=" + idActividad + ";";
            miBD.Delete(sentencia);

            idActividad = -1;
            UsuarioCreador = null;
            nombreActividad = null;
            descripcionActividad = null;
            fechaInicioActividad = null;
            fechaFinActividad = null;
            horaInicioActividad = null;
            horaFinActividad = null;
            lugarActividad = null;
            aforoActividad = -1;
        }

        public override bool Equals(object obj)
        {
            return (obj is Actividad) && (idActividad.Equals(((Actividad)obj).idActividad));
        }

        public override int GetHashCode()
        {
            return idActividad.GetHashCode();
        }
    }
}
