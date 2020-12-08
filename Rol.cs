using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace Grupo02PCSAS
{
    public class Rol
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private string rolName;
        private string rolDes;
        private bool admin;
       

        public static List<Rol> ListaRoles()
	    {
		    List<Rol> lista = new List<Rol>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (object[] tupla in miBD.Select("SELECT rolName FROM Rol;"))
            {
                string r = (string)tupla[0];
                lista.Add(new Rol(r));
            }
		    return lista;
	    }

        public Rol(string name)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "SELECT * FROM Rol WHERE rolName = '" + name + "';";
            object[] tupla = miBD.Select(sentencia)[0];

            rolName = (string)tupla[0];
            rolDes = (string)tupla[1];
            admin = (int)tupla[2] == 1 ? true : false;
            //admin = (bool)tupla[2];
            

        }
    
        public Rol(string name, string des, bool adm)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "INSERT INTO Rol VALUES("
                + "'" + name + "',"
                + "'" + des + "',"
                + (adm ? 1 : 0) + ");";

            miBD.Insert(sentencia);
            rolName = name;
            rolDes = des;
            admin = adm;
            
        }

        public string RolName
        {
            get { return rolName; }
            set 
            {                    
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Rol SET rolName = '" + value + "' "
                    + "WHERE rolName='" + rolName + "';";
                miBD.Update(sentencia);
                rolName = value;                 
            }
        }

        public string RolDes
        {
            get { return rolDes; }
            set 
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE Rol SET rolDes = '" + value + "' "
                    + "WHERE rolName='" + rolName + "';";
                miBD.Update(sentencia);
                rolDes = value;                 
            }
        }

        public bool Admin
        {
            get { return admin; }
        }

        public void setAdmin(Rol other, bool value)
        {
            if (!admin) throw new Error("Rol sin permiso para establecer administradores.");
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "UPDATE Rol SET admin = " + (value?1:0) + " "
                + "WHERE rolName='" + other.RolName + "';";
            miBD.Update(sentencia);
            other.admin = value;

        }

        public void BorrarRol()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "DELETE FROM Rol "
                + "WHERE rolName='" + rolName + "';";
            miBD.Delete(sentencia);

            rolName = null;
            rolDes = null;
            admin = false;
            
        }

        public override string ToString()
        {
            return rolName;
        }

        public override bool Equals(object obj)
        {
            return (obj is Rol) && (rolName.Equals(((Rol)obj).rolName));
        }

        public override int GetHashCode()
        {
            return rolName.GetHashCode();
        }
    }
}
