﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    public class CursosRealizados
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int idCurso;
        private string correo;

        public CursosRealizados(int numeroCurso, string email)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "SELECT * FROM CursosRealizados WHERE idCurso = " + idCurso + " AND correo = '" + email + "';";
            object[] tupla = miBD.Select(sentencia)[0];

            if (tupla != null)
            {
                this.idCurso = (int)tupla[0];
                this.correo = (string)tupla[1];
            }
            else
            {
                sentencia = "INSERT INTO CursosRealizados VALUES (" + numeroCurso + ", '" + email + "');";
                miBD.Insert(sentencia);
                this.idCurso = numeroCurso;
                correo = email;
            }
        }

        public int IdCurso
        {
            get { return idCurso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE CursosRealizados SET idCurso = " + value + " WHERE idCurso = " + idCurso + " AND correo = '" + correo + "';";
                miBD.Update(sentencia);
                this.idCurso = value;
            }
        }

        public string Correo
        {
            get { return correo; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE CursosRealizados SET correo = '" + value + "' WHERE idCurso = " + idCurso + " AND correo = '" + correo + "';";
                miBD.Update(sentencia);
                correo = value;
            }
        }

        public void BorrarCursoRealizado()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "DELETE FROM CursosRealizados "
                + "WHERE idCurso = " + idCurso + " AND correo = '" + correo + "';";
            miBD.Delete(sentencia);

            idCurso = -1;
            correo = null;
        }

        public override bool Equals(object obj)
        {
            return (obj is CursosRealizados) && (idCurso.Equals(((CursosRealizados)obj).idCurso)) && (correo.Equals(((CursosRealizados)obj).correo));
        }

        public override int GetHashCode()
        {
            return idCurso.GetHashCode() + correo.GetHashCode();
        }
    }
}
