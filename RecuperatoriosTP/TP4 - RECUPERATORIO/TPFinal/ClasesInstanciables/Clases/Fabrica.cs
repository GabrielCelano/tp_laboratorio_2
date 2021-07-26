using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excepciones;
using ClasesInstanciables.Enumerados;

namespace ClasesInstanciables.Clases
{
    public class Fabrica
    {
        #region Atributos
        private List<Operario> operarios;
        #endregion

        #region Propiedades
        /// <summary>
        /// Devuelve y setea la lista de operarios
        /// </summary>
        public List<Operario> Operarios { get { return this.operarios; } set { this.operarios = value; } }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de clase sin parametros que setea la lista de Operarios
        /// </summary>
        public Fabrica()
        {
            this.Operarios = new List<Operario>();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Valida si un Operario se encuentra en la lista, si se encuentra retorna true, caso contrario false
        /// </summary>
        /// <param name="f"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator ==(Fabrica f, Operario e)
        {
            foreach (Operario item in f.Operarios)
            {
                if (item == e)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Valida si el Operador no se encuentra en la lista
        /// </summary>
        /// <param name="f"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator !=(Fabrica f, Operario e)
        {
            return !(f == e);
        }

        /// <summary>
        /// Agrega un Operador a la lista si este no se encuentra
        /// </summary>
        /// <param name="f"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static Fabrica operator +(Fabrica f, Operario e)
        {
            if (f != e)
            {
                f.Operarios.Add(e);
                return f;
            }
            return f;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Suma una fabricacion al operario
        /// </summary>
        /// <param name="f"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool SumarFabricacion(Fabrica f, Operario e)
        {
            foreach (Operario item in f.Operarios)
            {
                if (item == e)
                {
                    item.Fabricaciones++;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica si la lista de Operadores contiene operarios, si no contiene nada lanza una excepcion
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public bool VerificarListaOperadores()
        {
            if (this.Operarios.Count > 0)
            {
                return true;
            }
            throw new ListaOperariosVaciaException();
        }

        /// <summary>
        /// Retorna los datos de los operarios
        /// </summary>
        /// <returns></returns>
        public string MostrarOperarios()
        {
            StringBuilder fabricaAux = new StringBuilder();
            fabricaAux.AppendLine("Lista de operarios:\n");
            fabricaAux.AppendLine(this.OperadoresArranques());
            fabricaAux.AppendLine(this.OperadoresAlternadores());
            return fabricaAux.ToString();
        }

        /// <summary>
        /// Retorna los datos de los operadores que tienen asignado el puesto de arranques
        /// </summary>
        /// <returns></returns>
        public string OperadoresArranques()
        {
            StringBuilder operadoresAux = new StringBuilder();
            operadoresAux.AppendLine("Sector arranques: ");
            foreach (Operario item in this.Operarios)
            {
                if (item.Puesto == EPuestoDeTrabajo.FabricanteDeArranques)
                {
                    operadoresAux.AppendLine(item.MostrarDatos());
                }
            }
            return operadoresAux.ToString();
        }

        /// <summary>
        /// Retorna los datos de los operadores que tienen asignado el puesto de alternadores
        /// </summary>
        /// <returns></returns>
        public string OperadoresAlternadores()
        {
            StringBuilder operadoresAux = new StringBuilder();
            operadoresAux.AppendLine("Sector alternadores: ");
            foreach (Operario item in this.Operarios)
            {
                if (item.Puesto == EPuestoDeTrabajo.FabricanteDeAlternadores)
                {
                    operadoresAux.AppendLine(item.MostrarDatos());
                }
            }
            return operadoresAux.ToString();
        }

        /// <summary>
        /// Retorna la jornada laboral
        /// </summary>
        /// <returns></returns>
        public string JornadaLaboral()
        {
            StringBuilder jornadaAux = new StringBuilder();
            jornadaAux.AppendLine($"Operarios que trabajaron el dia: {DateTime.Now}");
            jornadaAux.AppendLine(this.MostrarOperarios());
            return jornadaAux.ToString();
        }
        #endregion
    }
}