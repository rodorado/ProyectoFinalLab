using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class PropiedadesCAD
    {
        //miembro y atributos
        private ConexionDB objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        public PropiedadesCAD()
        {
            objConexionCAD = new ConexionDB();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }
        public DataTable consultarPropiedadesDB()
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "consultarPropiedades";
            comando.CommandType = CommandType.StoredProcedure;
            //comando.CommandText = "SELECT * FROM Propiedad";
            //comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return miTabla;
        }

        //INSERTAR
        public void insertarPropiedadesDB(int idPropiedad, double precio, string domicilioP, DateTime antiguedad, string tipo, int idEsp, int idCuit)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "insertarPropiedades";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            //Cargar en sql los parametros que se inserten
            comando.Parameters.AddWithValue("@idPropiedad", idPropiedad);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@domicilioP", domicilioP);
            comando.Parameters.AddWithValue("@antiguedad", antiguedad);
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Parameters.AddWithValue("@idEsp", idEsp);
            comando.Parameters.AddWithValue("@idCuit", idCuit);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        //MODIFICAR
        public void modificarPropiedadesDB(int idPropiedad, double precio, string domicilioP, DateTime antiguedad, string tipo, int idEsp, int idCuit)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "modificarPropiedades";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            //Cargar en sql los parametros que se modifiquen
            comando.Parameters.AddWithValue("@idPropiedad", idPropiedad);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@domicilioP", domicilioP);
            comando.Parameters.AddWithValue("@antiguedad", antiguedad);
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Parameters.AddWithValue("@idEsp", idEsp);
            comando.Parameters.AddWithValue("@idCuit", idCuit);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
    }
}
