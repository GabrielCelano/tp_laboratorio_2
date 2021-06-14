using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class StringInvalidoException : Exception
    {
        public StringInvalidoException() : base("Error en el campo nombre/apellido.") { }
    }
}
