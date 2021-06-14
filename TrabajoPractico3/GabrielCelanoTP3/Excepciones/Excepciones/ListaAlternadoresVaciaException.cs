using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ListaAlternadoresVaciaException : Exception
    {
        public ListaAlternadoresVaciaException() : base("Lista de alternadores vacia.") { }
    }
}
