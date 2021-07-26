using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ListaDeFabricacionesVaciaException : Exception
    {
        public ListaDeFabricacionesVaciaException() : base("Lista de fabricaciones vacia") { }
        public ListaDeFabricacionesVaciaException(string mensaje, Exception innerException) : base(mensaje, innerException) { }
    }
}
