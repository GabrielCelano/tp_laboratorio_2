using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion

        #region Constructores
        /// <summary>
        /// Setea los datos en 0
        /// </summary>
        public Numero() { }

        /// <summary>
        /// Setea el parametro "numero" en el atributo "numero" de la clase
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Setea el parametro "strNumero" en el atributo "numero" de la clase
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Recive un string que lo valida y devuelve un double que lo setea en el atributo "numero"
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que solo utilizara la propiedad SetNumero
        /// Valida que el numero ingresado sea numerico y lo retorna en formato double
        /// Caso contrario devuelve 0
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>double</returns>
        private double ValidarNumero(string strNumero)
        {
            double aux = 0;
            if (double.TryParse(strNumero, out aux))
            {
               return aux;
            }
            return aux;
        }

        /// <summary>
        /// Recive un string el cual validara si solo contiene "1" y "0"
        /// Retornara true si esto ocurre, de caso contrario retornara false
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>bool</returns>
        private bool EsBinario(string binario)
        {
            if (!(binario.Contains('1')) || !(binario.Contains('0')))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Recive un string y validara si ese string es un numero binario
        /// En caso de ser un numero binario convertira ese numero en decimal y lo retornara en formato string
        /// En caso de no serlo retornara "Es invalido."
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>string</returns>
        public string BinarioDecimal(string binario)
        {
            double d = 0;
            if (EsBinario(binario))
            {
                foreach (var num in binario)
                {
                    d *= 2;
                    if (num == '1')
                    {
                        d += 1;
                    }
                    else if (num != '0')
                    {
                        d = 0;
                    }                       
                }
            }

            else
            {
                return "Es invalido.";
            }

            return d.ToString();
        }

        /// <summary>
        /// Recive un decimal(double) como parametro el cual es convertido a binario
        /// Retorna ese decimal convertido a binario en formato string
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>string</returns>
        /// 
        public string DecimalBinario(double numero)
        {
            string resultado = "";
            long numIng = Convert.ToInt64(numero);
            numIng = Math.Abs(numIng);

            while (numIng > 1)
            {
                long resto = numIng % 2;
                resultado = Convert.ToString(resto) + resultado;
                numIng /= 2;
            }
            return resultado = Convert.ToString(numIng) + resultado;
        }
        /// <summary>
        /// Recive un decimal(string) como parametro el cual es convertido a binario
        /// Retorna ese decimal convertido a binario en formato string
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>string</returns>
        public string DecimalBinario(string numero)
        {
            string resultado = "";
            long numIng = Convert.ToInt64(numero);
            numIng = Math.Abs(numIng);

            while (numIng > 1)
            {
                long resto = numIng % 2;
                resultado = Convert.ToString(resto) + resultado;
                numIng /= 2;
            }
            return resultado = Convert.ToString(numIng) + resultado;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Recive dos parametros de clase Numero
        /// Retorna la resta
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>double</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Recive dos parametros de clase Numero
        /// Retorna la suma
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>double</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Recive dos parametros de clase Numero
        /// Valida que no se pueda dividir por cero
        /// Retorna la division
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>double</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }

            return double.MinValue;
        }

        /// <summary>
        /// Recive dos parametros de clase Numero
        /// Retorna la multiplicacion
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>double</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        #endregion
    }
}
