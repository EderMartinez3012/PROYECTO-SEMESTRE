using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class BaseDatos
    {
        string CadenaConexion = 
        SqlConnection conexion;
        public BaseDatos()
        {
            conexion = new SqlConnection(CadenaConexion);
        }
        public SqlConnection ObtenerConexion()
        {
            return conexion;
        }
        public bool Abrir()
        {
            conexion.Open();
            return conexion.State == System.Data.ConnectionState.Open ? true : false;
        }
        public string Cerrar()
        {
            conexion.Close();
            try
            {
                conexion.Close();
                return "conexion cerrada ...";
            }
            catch (Exception ex)
            {
                conexion.Close();
                return ex.Message;
            }
        }
    }
}
