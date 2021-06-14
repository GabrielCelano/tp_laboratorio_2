using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ListaArranquesVaciaException : Exception
    {
        public ListaArranquesVaciaException() : base("Lista de alternadres vacia.") { }
    }
}
