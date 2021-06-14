using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesAbstractas;
using Excepciones;

namespace ClasesInstanciables
{
    /// <summary>
    /// Clase que hereda de Alternador
    /// </summary>
    public class FabricacionAlternadores : Alternador
    {
        #region Atributos
        private string marca;
        private int cantidad;
        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna y setea la Marca
        /// </summary>
        public string Marca { get { return this.marca; } set { this.marca = value; } }

        /// <summary>
        /// Retorna y setea la Cantidad
        /// </summary>
        public int Cantidad { get { return this.cantidad; } set { this.cantidad = value; } }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor de clase sin parametros
        /// </summary>
        public FabricacionAlternadores() { }

        /// <summary>
        /// Constructor de clase con parametros
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="marca"></param>
        /// <param name="carcasaAlternador"></param>
        /// <param name="polea"></param>
        /// <param name="rotor"></param>
        /// <param name="colector"></param>
        /// <param name="regulador"></param>
        public FabricacionAlternadores(int cantidad, string marca, bool carcasaAlternador, bool polea, bool rotor, bool colector, bool regulador) : base(carcasaAlternador, polea, rotor, colector, regulador)
        {
            this.Cantidad = cantidad;
            this.Marca = marca;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Setea el valor booleano en true
        /// Retorna el valor booleano del metodo
        /// </summary>
        /// <returns></returns>
        public string RectificarRotor()
        {
            if (!base.Rotor)
            {
                base.Rotor = true;
                return String.Format("Rotor rectificado!");
            }
            return String.Format("El rotor ya estaba rectificado!");
        }

        /// <summary>
        /// Setea el valor booleano en true
        /// Retorna el valor booleano del metodo
        /// </summary>
        /// <returns></returns>
        public string ColocarColector()
        {
            if (!this.Colector)
            {
                base.Colector = true;
                return String.Format("Colector colocado correctamente!");
            }
            return String.Format("El colector ya estaba colocado!");
        }

        /// <summary>
        /// Setea el valor booleano en true
        /// Retorna el valor booleano del metodo
        /// </summary>
        /// <returns></returns>
        public string ColocarCarcasa()
        {
            if (!base.Carcasa)
            {
                base.Carcasa = true;
                return String.Format("Carcasa colocada correctamente!");
            }
            return String.Format("La carcasa ya estaba colocada!");
        }

        /// <summary>
        /// /// Setea el valor booleano en true
        /// Retorna el valor booleano del metodo
        /// </summary>
        /// <returns></returns>
        public string ColocarRegulador()
        {
            if (!base.Regulador)
            {
                base.Regulador = true;
                return String.Format("Regulador colocado correctamente!");
            }
            return String.Format("El regulador ya estaba colocado!");
        }

        /// <summary>
        /// Setea el valor booleano en true
        /// Retorna el valor booleano del metodo
        /// </summary>
        /// <returns></returns>
        public string ColocarPolea()
        {
            if (!base.Polea)
            {
                base.Polea = true;
                return String.Format("Polea colocada correctamente!");
            }
            return String.Format("La polea ya estaba colocada!");
        }

        /// <summary>
        /// Retorna los datos del Alternador para validar su fabricacion 
        /// </summary>
        /// <returns></returns>
        public string VerificarAlternador()
        {
            StringBuilder alternadorAux = new StringBuilder();
            alternadorAux.AppendLine($"Marca: {this.Marca}");
            alternadorAux.AppendLine(base.ToString());
            return alternadorAux.ToString();
        }

        /// <summary>
        /// Valida si la fabricacion se realizo correctamente
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool ValidarFabricacion(FabricacionAlternadores a)
        {
            if (a.Carcasa && a.Colector && a.Polea && a.Regulador && a.Rotor && a.Marca != "")
            {
                return true;
            }
            throw new VerificacionInvalidaException();
        }
        #endregion
    }
}