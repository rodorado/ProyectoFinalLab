using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class EspecificacionesCAD
    {
        private ConexionDB objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

    public EspecificacionesCAD()
        {
            objConexionCAD = new ConexionDB();
            miTabla = new DataTable();
            comando = new SqlCommand();
       
        }

        //CONSULTAR ESPECIFICACIONES
       public DataTable consultarEspecificacionesDB()
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "consultarEspecificaciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return miTabla;
        }
        //INSERTAR ESPECIFICACIONES
        public void insertarEspecificacionesDB(int idEsp, double metros2, int cantAmb, int cantBaños)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "insertarEspecificaciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idEsp", idEsp);
            comando.Parameters.AddWithValue("@metros2", metros2);
            comando.Parameters.AddWithValue("@cantAmb", cantAmb);
            comando.Parameters.AddWithValue("@cantBaños", cantBaños);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        //MODIFICAR ESPECIFICACIONES
        public void modificarEspecificacionesDB(int idEsp, double metros2, int cantAmb, int cantBaños)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "modificarEspecificaciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idEsp", idEsp);
            comando.Parameters.AddWithValue("@metros2", metros2);
            comando.Parameters.AddWithValue("@cantAmb", cantAmb);
            comando.Parameters.AddWithValue("@cantBaños", cantBaños);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        //ELIMINAR ALGUNA ESPECIFICACIÓN EN PARTICULAR
        public void eliminarEspecificacionesDB(int idEsp)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "eliminarEspecificaciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idEsp", idEsp);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
    }
}
