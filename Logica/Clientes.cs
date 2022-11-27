using Datos;
using Entidades;
using System.Collections.Generic;

namespace Logica
{
    public class Clientes
    {
        private RepositorioClientes oCliente = new RepositorioClientes();


        public List<Cliente> GetCliente()
        {
            return oCliente.GetCliente();
        }

        public int AddCliente(Cliente pEntidad)
        {
            return oCliente.AddCliente(pEntidad);
        }

        public int UpdateCliente(Cliente pEntidad)
        {
            return oCliente.UpdateCliente(pEntidad);
        }

        public int DeleteCliente(int pId)
        {
            return oCliente.DeleteCliente(pId);
        }

    }
}
