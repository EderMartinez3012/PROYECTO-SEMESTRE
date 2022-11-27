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


        public List<Cliente> GetCliente()
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                const string query = @"SELECT Id,Nombres,Apellidos,Telefono,Sexo,Menu
                                      FROM Clientes";

                return cn.Query<Cliente>(query, CommandType.Text).ToList();
            }
        }


        public int AddCliente(Cliente Entidades)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();

                const string query = @"INSERT INTO Cliente (Nombres,Apellidos,Telefono,Sexo,Menu)
                                       VALUES (@Nombres,@Apellidos,@Telefono,@Sexo,@Menu)";

                var parameters = new DynamicParameters();
                parameters.Add("@Id", Entidades.Id, DbType.Int32);
                parameters.Add("@Nombres", Entidades.Nombres,DbType.String);
                parameters.Add("@Apellidos", Entidades.Apellidos, DbType.String);
                parameters.Add("@Telefono", Entidades.Telefono, DbType.String);
                parameters.Add("@Sexo", Entidades.Sexo, DbType.String);
                parameters.Add("@Menu", Entidades.Menu, DbType.String);

                return cn.Execute(query, parameters, commandType: CommandType.Text);
            }
            
                
        }
        
        public int UpdateCliente(Cliente Entidades)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();

                const string query = "@UPDATE Cliente SET Nombres = @Nombres," +
                    "                                     Apellidos = @Apellidos" +
                    "                                     Telefono = @Telefono" +
                    "                                     Sexo = @Sexo" +
                    "                                     Menu = @Menu " +
                    "                                                            " +
                    "                                 WHERE Id = @Id";

                var parameters = new DynamicParameters();
                parameters.Add("@Id", Entidades.Id, DbType.Int32);
                parameters.Add("@Nombres", Entidades.Nombres, DbType.String);
                parameters.Add("@Apellidos", Entidades.Apellidos, DbType.String);
                parameters.Add("@Telefono", Entidades.Telefono, DbType.String);
                parameters.Add("@Sexo", Entidades.Sexo, DbType.String);
                parameters.Add("@Menu", Entidades.Menu, DbType.String);

                return cn.Execute(query, parameters, commandType: CommandType.Text);
            }
        }

        public int DeleteCliente(int Id)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();

                const string query = @"DELETE FROM Clientes WHERE Id = @Id";

                var parameters = new DynamicParameters();
                parameters.Add("@Id", Id, DbType.Int32);
                
                return cn.Execute(query, parameters, commandType: CommandType.Text);
            }
        }

        
    }
            
    
}

