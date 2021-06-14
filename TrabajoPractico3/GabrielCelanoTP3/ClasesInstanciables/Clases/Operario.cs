using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enumerados;
using Excepciones;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    /// <summary>
    /// Clase que hereda de Persona
    /// </summary>
    public class Operario : Persona
    {
        #region Atributos
        private EPuestoDeTrabajo puesto;
        private int cantidadDeFabricaciones;
        private int id;
        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna y setea el valor entero de CantidadDeFabricaciones
        /// </summary>
        public int CantidadDeFabricaciones
        {
            get { return this.cantidadDeFabricaciones; }
            set { this.cantidadDeFabricaciones = value; }
        }
        /// <summary>
        /// Retorna y setea el valor de tipo enumerado de Puesto
        /// </summary>
        public EPuestoDeTrabajo Puesto
        {
            get { return this.puesto; }
            set { this.puesto = value; }
        }
        /// <summary>
        /// Retorna y setea el valor entero de ID
        /// </summary>
        public int ID
        {
            get { return this.id; }
            set { this.id = this.ValidarID(value); }
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
        /// <param name="id"></param>
        /// <param name="puesto"></param>
        /// <param name="cantidad"></param>
        public Operario(string nombre, string apellido, int dni, int id, EPuestoDeTrabajo puesto, int cantidad) : base(nombre, apellido, dni)
        {
            this.ID = id;
            this.Puesto = puesto;
            this.CantidadDeFabricaciones = cantidad;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Valida si un objeto Operador es igual a otro si comparten el mismo DNI o ID
        /// </summary>
        /// <param name="op1"></param>
        /// <param name="op2"></param>
        /// <returns></returns>
        public static bool operator ==(Operario op1, Operario op2)
        {
            if (op1.Equals(op2))
            {
                if (op1.ID == op2.ID || op1.DNI == op2.DNI)
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
        /// Metodo que valida el ID, si es true retorna el ID, si no lanza una excepcion
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private int ValidarID(int id)
        {
            if (id >= 1000 && id < 9999)
            {
                return id;
            }
            else
            {
                throw new IDInvalidoException();
            }
        }

        /// <summary>
        /// Retorna los datos del Operario
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder operarioAux = new StringBuilder(base.ToString());
            operarioAux.AppendLine($"Puesto de trabajo: {this.Puesto}");
            operarioAux.AppendLine($"Cantidad de fabricaciones: {this.CantidadDeFabricaciones}");
            return operarioAux.ToString();
        }
        #endregion
    }
}