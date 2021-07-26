using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ActualizarBdException : Exception
    {
        public ActualizarBdException(string mensaje, Exception innerException): base(mensaje, innerException) { }
    }
}
