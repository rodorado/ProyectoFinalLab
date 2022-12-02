using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ConexionDB
    {
        //private string cadena;
        private string caden;
        private SqlConnection conectarDB;

        public ConexionDB()
        {
            caden = "Data Source = ROCIO-DORADO\\SQLEXPRESS; Initial Catalog = InmobiliariaLab; User ID = sa; Password = 102030";
            conectarDB = new SqlConnection();
            conectarDB.ConnectionString = caden;
        }

        public SqlConnection abrirConeccion()
        {
            conectarDB.Open();
            return conectarDB;
        }
        public void cerrarConexion()
        {
            conectarDB.Close();
        }
    }
}
