using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class CLClientes
    {
        public bool ValidarDatos(Cliente cliente)
        {
            bool Resultado = true;

            if (cliente.Cedula == int.Emp)
            {
                MessageBox.Show("Debe ingresar la cedula");
            }

            if (cliente.Nombres == String.Empty)
            { 
                Resultado = false;
                MessageBox.Show("Debe ingresar nombres");
            }

            if (cliente.Apellidos == String.Empty)
            {
                MessageBox.Show("Debe ingresar apellidos");
            }

            if (cliente.Telefono == String.Empty)
            {
                MessageBox.Show("Debe ingresar el telefono");
            }

            if (cliente.Menu == String.Empty)
            {
                MessageBox.Show("Debe ingresar apellidos");
            }

            return Resultado;
        }

            
     
    }
}
