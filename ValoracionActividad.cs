using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    class ValoracionActividad
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int id;
        private int idActividad;
        private int satisfaccion;
        private int lugar;
        private int horario;
        private int organizacion;
        private bool repetir;
        private String comentario;

        private Actividad actividad;


        public ValoracionActividad(int id)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM ValoracionActividad WHERE id = " + id + ";")[0];
            this.id = (int)tupla[0];
            this.actividad = new Actividad((int)tupla[1]);
            this.idActividad = actividad.IdActividad;
            this.satisfaccion = (int)tupla[2];
            this.lugar = (int)tupla[3];
            this.horario = (int)tupla[4];
            this.organizacion = (int)tupla[5];
            this.repetir = (int)tupla[6] == 0 ? false : true;
            this.comentario = (String)tupla[7];
        }

        public ValoracionActividad(int ia, int s, int l, int h, int o, bool r, String c) 
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            string sentencia = "INSERT INTO ValoracionActividad VALUES (" + 0 + "," + ia + "," + s + "," + l + ","+ h + "," + o + "," + (r == true ? 1 : 0) + ",'" + c + "');";
            miBD.Insert(sentencia);
            this.id = (int)miBD.SelectScalar("SELECT MAX(id) FROM ValoracionActividad;");
            this.actividad = new Actividad(ia);
            this.idActividad = actividad.IdActividad;
            this.satisfaccion = s;
            this.lugar = l;
            this.horario = h;
            this.organizacion = o;
            this.repetir = r;
            this.comentario = c;
        }

        public int IDValoracionActividad
        {
            get { return this.id; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ValoracionActividad SET id =" + value + "WHERE id = " + this.id);
                this.id = value;
            }
        }
        public int IdActividad
        {
            get { return this.idActividad; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ValoracionActividad SET idActividad =" + value + "WHERE id = " + this.id);
                this.idActividad = value;
            }
        }


        public int Satisfaccion
        {
            get { return this.satisfaccion; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ValoracionActividad SET satisfaccion =" + value + "WHERE id = " + this.id);
                this.satisfaccion = value;
            }
        }

        public int Lugar
        {
            get { return this.lugar; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ValoracionActividad SET lugar =" + value + "WHERE id = " + this.id);
                this.lugar = value;
            }
        }

        public int Horario
        {
            get { return this.horario; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ValoracionActividad SET horario =" + value + "WHERE id = " + this.id);
                this.horario = value;
            }
        }

        public int Organizacion
        {
            get { return this.organizacion; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ValoracionActividad SET organizacion =" + value + "WHERE id = " + this.id);
                this.organizacion = value;
            }
        }

        public bool Repetir
        {
            get { return this.repetir; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ValoracionActividad SET repetir =" + (value == true ? 1 : 0 ) + "WHERE id = " + this.id);
                this.repetir = value;
            }
        }

        public String Comentario
        {
            get { return this.comentario; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE ValoracionActividad SET comentario =" + value + "WHERE id = " + this.id);
                this.comentario = value;
            }
        }


        public void BorrarValoracionActividad()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM ValoracionActividad WHERE id = " + this.id);
            this.id = -1;
            this.idActividad = -1;
            this.actividad = null;
            this.satisfaccion = -1;
            this.lugar = -1;
            this.horario = -1;
            this.organizacion = -1;
            this.repetir = false;
            this.comentario = null;
        }

        public override bool Equals(object obj)
        {
            return (obj is ValoracionActividad) && (id.Equals(((ValoracionActividad)obj).id));
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }


    }

}
