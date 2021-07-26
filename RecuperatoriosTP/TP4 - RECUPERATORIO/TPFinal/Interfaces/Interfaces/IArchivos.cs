using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface IArchivos<T>
    {
        bool Guardar(string rutaArchivo, T objeto);
        T Leer(string rutaArchivo);
    }
}
