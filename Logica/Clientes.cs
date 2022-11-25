using System;
//using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Logica
{
    public class Clientes
    {
        //SqlCommand cmd;
        //public ResponseCliente ValidarDatos(Cliente cliente)
        //{
        //    //Response Respuesta = new Response();

        //    if (cliente.Cedula.ToString().Length < 3)
        //    {
        //        return new ResponseCliente(false, "Ingresar cedula valida", null);
        //    }

        //    if (cliente.Nombres == String.Empty)
        //    {
        //        return new ResponseCliente(false, "Ingresar nombres validos", null);
        //    }

        //    if (cliente.Apellidos == String.Empty)
        //    {
        //        return new ResponseCliente(false, "Ingresar apellidos validos", null);
        //    }

        //    if (cliente.Telefono == String.Empty)
        //    {
        //        return new ResponseCliente(false, "Ingresar telefono valida", null);
        //    }

        //    if (cliente.Menu == String.Empty)
        //    {
        //        return new ResponseCliente(false, "Ingresar menu valido", null);
        //    }

        //    return new ResponseCliente(true, "Ok", cliente);
        //}

        //private Cliente Cliente = new Cliente();

        public List<Cliente> GetCliente()
        {
            return Cliente.GetCliente();
        }

        public int AddCliente(Cliente Entidades)
        {
            return Cliente.AddCliente(Entidades);
        }

        public int UpdateCliente(Cliente Entidades)
        {
            return Cliente.UpdateCliente(Entidades);
        }

        public int DeleteCliente(int Cedula)
        {
            return Cliente.DeleteCliente(Cedula);
        }

    }
}
