using ClasesInstanciables.Clases;
using ClasesInstanciables.Enumerados;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClasesInstanciables.Extenciones
{
    public static class MiExtension
    {
        public static bool ConversionEMarca(this string str, out EMarca marca)
        {
            EMarca aux;
            if(Enum.TryParse(str, out marca))
            {
                return true;
            }
            return false;
        }
    }
}
