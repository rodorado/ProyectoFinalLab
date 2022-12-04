using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class EspecificacionesCLN
    {
        private DataTable miTabla;
        private EspecificacionesCAD objEspecificacionesDB;

        public EspecificacionesCLN()
        {
            miTabla = new DataTable();
            objEspecificacionesDB = new EspecificacionesCAD();
            
        }


        //CONSULTAR ESP
        public DataTable consultarEspecificacionesCN()
        {
            miTabla = objEspecificacionesDB.consultarEspecificacionesDB();
            return miTabla;
        }

        //INSERTAR ESP
        public void insertarEsp(int idEsp, double metros2, int cantAmb, int cantBaños)
        {
            objEspecificacionesDB.insertarEspecificacionesDB(idEsp, metros2, cantAmb, cantBaños);
        }
        //MODIFICAR ESP
        public void modificarEsp(int idEsp, double metros2, int cantAmb, int cantBaños)
        {
            objEspecificacionesDB.modificarEspecificacionesDB(idEsp, metros2, cantAmb, cantBaños);
        }

        //ELIMINAR ESP
        public void eliminarEsp(int idEsp)
        {
            objEspecificacionesDB.eliminarEspecificacionesDB(idEsp);
        }
    }
}
