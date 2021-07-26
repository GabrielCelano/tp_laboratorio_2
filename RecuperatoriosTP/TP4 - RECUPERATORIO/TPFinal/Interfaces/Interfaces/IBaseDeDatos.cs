using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface IBaseDeDatos<T, U>
    {
        bool Guardar(T lista, U objeto);
        T Leer(T lista);
        void ActualizarDatos(T lista, U objeto);
        bool Verificar(U objeto);
    }
}
