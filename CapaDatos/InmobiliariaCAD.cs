using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
   public class InmobiliariaCAD
    {
        //miembro y atributos
        private ConexionDB objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        public InmobiliariaCAD()
        {
            objConexionCAD = new ConexionDB();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }
        public DataTable consultarInmobiliariasDB()
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "consultarInmobiliarias";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return miTabla;
        }
        //INSERTAR
        public void insertarInmobiliariaDB(int idCuit, string razonSocial, string domicilioP, string telefono, string email)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "insertarInmobiliarias";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idCuit", idCuit);
            comando.Parameters.AddWithValue("@razonSocial", razonSocial);
            comando.Parameters.AddWithValue("@domicilioP", domicilioP);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email", email);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        //MODIFICAR INMOBILIARIAS
        public void modificarInmobiliariaDB(int idCuit, string razonSocial, string domicilioP, string telefono, string email)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "modificarInmobiliarias";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idCuit", idCuit);
            comando.Parameters.AddWithValue("@razonSocial", razonSocial);
            comando.Parameters.AddWithValue("@domicilioP", domicilioP);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email", email);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        //ELIMINAR INMOBILIARIAS
        public void eliminarInmobiliariaDB(int idCuit)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "eliminarInmobiliarias";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idCuit", idCuit);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
    }
}
