using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
   public class InmobiliariaCLN
   {
        private DataTable miTabla;
        private InmobiliariaCAD objInmobiliariaDB;
    
        public InmobiliariaCLN()
        {
            miTabla = new DataTable();
            objInmobiliariaDB = new InmobiliariaCAD();
        }
        //CONSULTAR INMOBILIARIAS
        public DataTable consultarInmobiliariasCN()
        {
            miTabla = objInmobiliariaDB.consultarInmobiliariasDB();
            return miTabla;
        }

        //INSERTAR INMOBILIARIAS (SUCURSALES)
        public void InsertarInmobiliariasCN(int idCuit, string razonSocial, string domicilioP, string telefono, string email)
        {
            objInmobiliariaDB.insertarInmobiliariaDB(idCuit, razonSocial, domicilioP, telefono, email); 
        }

        //MODIFICAR
        public void modificarInmobiliariasCN(int idCuit, string razonSocial, string domicilioP, string telefono, string email)
        {
            objInmobiliariaDB.modificarInmobiliariaDB(idCuit, razonSocial, domicilioP, telefono, email);
        }

        //ELIMINAR
        public void eliminarInmobiliariasCN(int idCuit)
        {
            objInmobiliariaDB.eliminarInmobiliariaDB(idCuit);
        }
    }
}
