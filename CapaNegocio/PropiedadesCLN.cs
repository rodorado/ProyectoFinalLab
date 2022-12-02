using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class PropiedadesCLN
    {
        private DataTable miTabla;
        private PropiedadesCAD objPropiedadDB;



        public PropiedadesCLN()
        {
            objPropiedadDB = new PropiedadesCAD();
            miTabla = new DataTable();
        }


        public DataTable consultarPropiedadesCN()
        {
            miTabla = objPropiedadDB.consultarPropiedadesDB();
            return miTabla;
        }

        //INSERTAR CN
        public void insertarPropiedadesCN(int idPropiedad, double precio, string domicilioP, DateTime antiguedad, string tipo, int idEsp, int idCuit)
        {

            idPropiedad++;
            objPropiedadDB.insertarPropiedadesDB(idPropiedad, precio, domicilioP, antiguedad, tipo, idEsp, idCuit);

        }

        public int getIndiceUltFila(int cantFilas)
        {
            return cantFilas - 2;
        }

        public int getCodigoPropiedad(object a)
        {
            int numero = Convert.ToInt32(a);
            int codigo = numero + 1;
            return codigo;

        }

        //MODIFICAR CN

        public void modificarPropiedadesCN(int idPropiedad, double precio, string domicilioP, DateTime antiguedad, string tipo, int idEsp, int idCuit)
        {
            objPropiedadDB.modificarPropiedadesDB(idPropiedad, precio, domicilioP, antiguedad, tipo, idEsp, idCuit);
        }


    }
}
