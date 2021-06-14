using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ListaOperariosVaciaException : Exception
    {
        public ListaOperariosVaciaException() : base("Lista de operadores vacia.") { }
    }
}
