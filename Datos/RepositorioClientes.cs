using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioClientes : Archivos, ICrudArchivos<Cliente>
    {
        public RepositorioClientes(string Filename) : base(Filename)
        {

        }

        public List<Cliente> GetAll()
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    clientes.Add(Mapper(sr.ReadLine()));
                }
                sr.Close();
                return clientes;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Cliente Mapper(string linea)
        {
            try
            {
                var contacto = new Cliente();
                cliente.Cedula = int.Parse(linea.Split(';')[0]);
                cliente.Nombres = (linea.Split(';')[1]);
                cliente.Apellidos = (linea.Split(';')[2]);
                cliente.Telefono = (linea.Split(';')[3]);
                contacto.FechaNacimiento = DateTime.Parse(linea.Split(';')[3]);
                return cliente;

            }
            catch (Exception)
            {
                return null;
            }

        }

        public bool Update(List<Cliente> clientes)
        {
            try
            {
                var sw = new StreamWriter(ruta, false);
                foreach (var item in clientes)
                {
                    sw.WriteLine(item.ToString());
                }

                sw.Close();

                return true;
            }
            catch (Exception)
            {
                return false;

            }

        }
    }
}
