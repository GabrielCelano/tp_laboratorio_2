using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesAbstractas;
using Archivos;
using Excepciones;

namespace ClasesInstanciables
{
    /// <summary>
    /// Clase que hereda de Arranque
    /// </summary>
    public class FabricacionArranques : Arranque
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

        #region Constructores
        /// <summary>
        /// Constructor de clase sin parametros
        /// </summary>
        public FabricacionArranques() { }

        /// <summary>
        /// Constructor de clase son parametros
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="marca"></param>
        /// <param name="carcasasArranques"></param>
        /// <param name="horquillas"></param>
        /// <param name="bendix"></param>
        /// <param name="bobina"></param>
        /// <param name="automatico"></param>
        /// <param name="plaquetasDeCarbones"></param>
        public FabricacionArranques(int cantidad,string marca, bool carcasasArranques, bool horquillas, bool bendix, bool bobina, bool automatico, bool plaquetasDeCarbones) : base(carcasasArranques, horquillas, bendix, bobina, automatico, plaquetasDeCarbones)
        {
            this.Marca = marca;
            this.Cantidad = cantidad;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Setea el valor booleano en true
        /// Retorna el valor booleano del metodo
        /// </summary>
        /// <returns></returns>
        public string RectificarBobina()
        {
            if (!base.Bobina)
            {
                base.Bobina = true;
                return String.Format("Bobina rectificada!");
            }
            return String.Format("La bobina ya estaba rectificada!");
        }

        /// <summary>
        /// Setea el valor booleano en true
        /// Retorna el valor booleano del metodo
        /// </summary>
        /// <returns></returns>
        public string ColocarBendix()
        {
            if (!base.Bendix)
            {
                base.Bendix = true;
                return String.Format("Bendix colocado correctamente!");
            }
            return String.Format("El bendix ya estaba colocado!");
        }

        /// <summary>
        /// Setea el valor booleano en true
        /// Retorna el valor booleano del metodo
        /// </summary>
        /// <returns></returns>
        public string ColocarHorquilla()
        {
            if (!base.Horquilla)
            {
                this.Horquilla = true;
                return String.Format("Horquilla colocada correctamente!");
            }
            return String.Format("La horquilla ya estaba colocada");
        }

        /// <summary>
        /// Setea el valor booleano en true
        /// Retorna el valor booleano del metodo
        /// </summary>
        /// <returns></returns>
        public string ColocarPlaqueta()
        {
            if (!base.Plaqueta)
            {
                this.Plaqueta = true;
                return String.Format("Plaqueta colocada correctamente!");
            }
            return String.Format("La plaqueta ya estaba colocada!");
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
        /// Setea el valor booleano en true
        /// Retorna el valor booleano del metodo
        /// </summary>
        /// <returns></returns>
        public string ColocarAutomatico()
        {
            if (!base.Automatico)
            {
                base.Automatico = true;
                return String.Format("Automatico colocado correctamente!");
            }
            return String.Format("El automatico ya estaba colocado!");
        }

        /// <summary>
        /// Retorna los datos del Arranque para verificar su fabricacion
        /// </summary>
        /// <returns></returns>
        public string VerificarArranque()
        {
            StringBuilder arranqueAux = new StringBuilder();
            arranqueAux.AppendLine($"Marca: {this.Marca}");
            arranqueAux.AppendLine(base.ToString());
            return arranqueAux.ToString();
        }

        /// <summary>
        /// Valida si la fabricacion se realizo correctamente
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool ValidarFabricacion(FabricacionArranques a)
        {
            if (a.Automatico && a.Bendix && a.Bobina && a.Horquilla && a.Carcasa && a.Plaqueta && a.Marca != "")
            {
                return true;
            }
            throw new VerificacionInvalidaException();
        }
        #endregion
    }
}