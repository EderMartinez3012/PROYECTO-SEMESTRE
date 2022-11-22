using System;
//using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class CLClientes
    {
        public ResponseCliente ValidarDatos(Cliente cliente)
        {
            //Response Respuesta = new Response();

            if (cliente.Cedula.ToString().Length<3)
            {
                return  new ResponseCliente(false,"Ingresar cedula valida",null);
            }

            if (cliente.Nombres == String.Empty)
            {
                return new ResponseCliente(false, "Ingresar nombre valida", null);
            }

            //if (cliente.Apellidos == String.Empty)
            //{
            //    MessageBox.Show("Debe ingresar apellidos");
            //}

            //if (cliente.Telefono == String.Empty)
            //{
            //    MessageBox.Show("Debe ingresar el telefono");
            //}

            //if (cliente.Menu == String.Empty)
            //{
            //    MessageBox.Show("Debe ingresar apellidos");
            //}

            return new ResponseCliente(true, "Ok", cliente);
        }

            
     
    }
}
