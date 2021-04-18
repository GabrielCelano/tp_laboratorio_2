using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        #region Metodos
        /// <summary>
        /// Recive dos parametros de clase Numero y un string
        /// Realiza la operacion matematica segun el operador que se ingreso por parametro(string)
        /// Retorna el resultado de la operacion
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>double</returns>
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            double total = 0;
            switch (ValidarOperador(operador))
            {
                case "+":
                    total = numero1 + numero2;
                    break;
                case "-":
                    total = numero1 - numero2;
                    break;
                case "/":
                    total = numero1 / numero2;
                    break;
                case "*":
                    total = numero1 * numero2;
                    break;
            }
            return total;
        }

        /// <summary>
        /// Recive como parametro un operador(string)
        /// Valida el operador ingresado(+ ,- ,* ,/) y lo devuelve, de caso contrario devuelve +.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>string</returns>
        private static string ValidarOperador(string operador)
        {
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                return operador;
            }

            return "+";
        }
        #endregion
    }
}
