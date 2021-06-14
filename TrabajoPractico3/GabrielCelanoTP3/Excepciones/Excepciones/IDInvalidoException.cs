using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class IDInvalidoException:Exception
    {
        public IDInvalidoException() : base("ID invalido.") { }
    }
}