using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesAbstractas.Clases;
using ClasesInstanciables.Enumerados;
using Excepciones;
using ClasesAbstractas;

namespace ClasesInstanciables.Clases
{
    /// <summary>
    /// Clase que hereda de Persona
    /// </summary>
    [Serializable]
    public class Operario : Persona
    {
        #region Atributos
        private EPuestoDeTrabajo puesto;
        private int fabricaciones;
        #endregion

        #region Propiedades
        /// <summary>
        /// Devuelve y setea la cantidad de fabricaciones del operario
        /// </summary>
        public int Fabricaciones
        {
            get { return this.fabricaciones; }
            set { this.fabricaciones = value; }
        }
        /// <summary>
        /// Devuelve y setea el puesto del operario
        /// </summary>
        public EPuestoDeTrabajo Puesto
        {
            get { return this.puesto; }
            set { this.puesto = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de Operario sin parametros
        /// </summary>
        public Operario() { }

        /// <summary>
        /// Constructor de operario con parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="puesto"></param>
        /// <param name="fabricaciones"></param>
        public Operario(string nombre, string apellido, int dni, EPuestoDeTrabajo puesto, int fabricaciones) : base(nombre, apellido, dni)
        {
            this.Puesto = puesto;
            this.Fabricaciones = fabricaciones;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Valida si un objeto Operador es igual a otro si comparten el mismo DNI, retorna true si es asi, casi contrario retorna false
        /// </summary>
        /// <param name="op1"></param>
        /// <param name="op2"></param>
        /// <returns></returns>
        public static bool operator ==(Operario op1, Operario op2)
        {
            if (op1.Equals(op2))
            {
                if (op1.DNI == op2.DNI)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Valida si un objeto Operador es diferente a otro
        /// </summary>
        /// <param name="op1"></param>
        /// <param name="op2"></param>
        /// <returns></returns>
        public static bool operator !=(Operario op1, Operario op2)
        {
            return !(op1 == op2);
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Retorna true si el objeto es de tipo Operario, retorna false de caso contrario
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Operario)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna los datos del Operario
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder operarioAux = new StringBuilder(base.ToString());
            operarioAux.AppendLine($"Puesto de trabajo: {this.Puesto}");
            operarioAux.AppendLine($"Cantidad de fabricaciones: {this.Fabricaciones}");
            return operarioAux.ToString();
        }
        #endregion
    }
}