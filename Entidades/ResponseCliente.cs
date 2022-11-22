using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ResponseCliente
    {
        public ResponseCliente(bool estado, string mensaje, Cliente cliente)
        {
            Estado = estado;
            Mensaje = mensaje;
            Cliente = cliente;
        }

        public bool Estado { get; set; }
        public string Mensaje { get; set; }
        public Cliente Cliente { get; set; }

    }
}
