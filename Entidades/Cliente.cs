using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        public String Menu { get; set; }
        public override string ToString()
        {
            return $"{Cedula};{Nombres};{Apellidos};{Telefono};{Sexo};{Menu}";
        }
    }
}
