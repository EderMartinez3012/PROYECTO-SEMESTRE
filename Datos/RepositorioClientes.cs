using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;
using Dapper;
using System.Data;

namespace Datos
{
    public class RepositorioClientes
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["RestauranteCosteño"].ToString();
        

        public List<RepositorioClientes> GetClientes()
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                const string query = @"SELECT Cedula,Nombres,Apellidos,Telefono,Sexo,Menu
                                      FROM Clientes";

                return cn.Query<RepositorioClientes>(query, CommandType.Text).ToList();
            }
        }


        public int AddCliente(RepositorioClientes Entidades)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();

                const string query = @"INSERT INTO Cliente (Cedula,Nombres,Apellidos,Telefono,Sexo,Menu)
                                       VALUES (@Cedula,@Nombres,@Apellidos,@Telefono,@Sexo,@Menu)";

                var parameters = new DynamicParameters();
                parameters.Add("@Cedula", Entidades.Cedula, DbType.Int32);
                parameters.Add("@Nombres", Entidades.Nombres,DbType.String);
                parameters.Add("@Apellidos", Entidades.Apellidos, DbType.String);
                parameters.Add("@Nombres", Entidades.Telefono, DbType.String);
                parameters.Add("@Nombres", Entidades.Sexo, DbType.String);
                parameters.Add("@Nombres", Entidades.Menu, DbType.String);

                return cn.Execute(query, parameters, commandType: CommandType.Text);
            }
            
                
        }
        
        public int UpdateCliente(RepositorioClientes Entidades)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();

                const string query = "@UPDATE Cliente SET Cedula = @Cedula," +
                    "                                     Nombres = @Nombres," +
                    "                                     Apellidos = @Apellidos" +
                    "                                     Telefono = @Telefono" +
                    "                                     Sexo = @Sexo" +
                    "                                     Menu = @Menu " +
                    "                                                            " +
                    "                                 WHERE Cedula = @Cedula";

                var parameters = new DynamicParameters();
                parameters.Add("@Cedula", Entidades.Cedula, DbType.Int32);
                parameters.Add("@Nombres", Entidades.Nombres, DbType.String);
                parameters.Add("@Apellidos", Entidades.Apellidos, DbType.String);
                parameters.Add("@Nombres", Entidades.Telefono, DbType.String);
                parameters.Add("@Nombres", Entidades.Sexo, DbType.String);
                parameters.Add("@Nombres", Entidades.Menu, DbType.String);

                return cn.Execute(query, parameters, commandType: CommandType.Text);
            }
        }

        public int DeleteCliente(int Cedula)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();

                const string query = @"DELETE FROM Clientes WHERE Cedula = @Cedula";

                var parameters = new DynamicParameters();
                parameters.Add("@Cedula", Cedula, DbType.Int32);
                
                return cn.Execute(query, parameters, commandType: CommandType.Text);
            }
        }
    
    }
            
    
}

