using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_SEMESTRE
{
    public class PresentaciónClientes
    {
        public void EjecutarAgregar(int l, int t)
        {
            Console.Clear();

            Console.SetCursorPosition(l, t - 3);
            Console.WriteLine("Digite su nombre: ");
            Console.SetCursorPosition(l + 28, t - 3);
            string nom = Console.ReadLine();

            Console.SetCursorPosition(l, t - 2);
            Console.WriteLine("Digite su cedula: ");
            Console.SetCursorPosition(l + 31, t - 2);
            string ced = Console.ReadLine();

            Console.SetCursorPosition(l, t - 1);
            Console.WriteLine("Digite su telefono: ");
            Console.SetCursorPosition(l + 34, t - 1);
            string tel = Console.ReadLine();

            //Console.SetCursorPosition(l, t + 0);
            //Console.WriteLine("Digite la fecha de nacimiento: ");
            //Console.SetCursorPosition(l + 31, t + 0);
            //String fechaNacimiento = Console.ReadLine();
            //String fechaN = Console.ReadLine();

            new Logica.AgregarCliente().Agregar(l, t, nom, tel, ced);

            Console.SetCursorPosition(l, t + 5);
            Console.ReadKey();

        }
    }
}
