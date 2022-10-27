using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface Servicio_Cliente<T> 
    {
        string Add(T cliente);
        string Delete(T cliente);
        string Edit(string tel, T cliente);
        List<T> GetAll();
        
        bool Exists(T cliente);
    }
}
