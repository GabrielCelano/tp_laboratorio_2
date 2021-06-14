using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excepciones;
using Enumerados;
using Archivos;

namespace ClasesInstanciables
{
    public class Fabrica
    {
        #region Atributos
        private List<FabricacionAlternadores> alternadores;
        private List<FabricacionArranques> arranques;
        private List<Operario> operarios;
        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna y setea la lista de tipo Alternadores, almacena todos alternadores cargados
        /// </summary>
        public List<FabricacionAlternadores> Alternadores { get { return this.alternadores; } set { this.alternadores = value; } }

        /// <summary>
        /// Retorna y setea la lista de Arranques, almacena todos los arranques cargados
        /// </summary>
        public List<FabricacionArranques> Arranques { get { return this.arranques; } set { this.arranques = value; } }

        /// <summary>
        /// Retorna y setea la lista de Operarios, almacena todos los operarios
        /// </summary>
        public List<Operario> Operarios { get { return this.operarios; } set { this.operarios = value; } }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de clase sin parametros que setea las listas de Operarios, Alternadores y Arranques
        /// </summary>
        public Fabrica()
        {
            this.Operarios = new List<Operario>();
            this.Alternadores = new List<FabricacionAlternadores>();
            this.Arranques = new List<FabricacionArranques>();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Valida si un Operario se encuentra en la lista, si se encuentra se lanza una excepcion
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
                    throw new OperarioRepetidoException();
                }
            }
            return false;
        }

        /// <summary>
        /// Valida si el Alternador fabricado se encuentra en la lista filtrado por Marca, si se encuentra aumenta la cantidad en uno
        /// </summary>
        /// <param name="f"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Fabrica f, FabricacionAlternadores a)
        {
            foreach (FabricacionAlternadores item in f.Alternadores)
            {
                if (item.Marca == a.Marca)
                {
                    item.Cantidad++;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Valida si el Arranque fabricado se encuentra en la lista filtrado por Marca, si se encuentra aumenta la cantidad en uno
        /// </summary>
        /// <param name="f"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Fabrica f, FabricacionArranques a)
        {

            foreach (FabricacionArranques item in f.Arranques)
            {
                if (item.Marca == a.Marca)
                {
                    item.Cantidad++;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Valida si el Arranque fabricado no se encuentra en la lista
        /// </summary>
        /// <param name="f"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Fabrica f, FabricacionArranques a)
        {
            return !(f == a);
        }

        /// <summary>
        /// Valida si el Alternador fabricado no se encuentra en la lista
        /// </summary>
        /// <param name="f"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Fabrica f, FabricacionAlternadores a)
        {
            return !(f == a);
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
        /// Agrega un Alternador a la lista si este no se encuentra
        /// </summary>
        /// <param name="f"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Fabrica operator +(Fabrica f, FabricacionAlternadores a)
        {
            if (f != a)
            {
                f.Alternadores.Add(a);
                return f;
            }
            return f;
        }

        /// <summary>
        /// Agrega un Arranque a la lista si este no se encuentra
        /// </summary>
        /// <param name="f"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Fabrica operator +(Fabrica f, FabricacionArranques a)
        {
            if (f != a)
            {
                f.Arranques.Add(a);
                return f;
            }
            return f;
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
                    item.CantidadDeFabricaciones++;
                    return true;
                }
            }
            foreach (Operario item in f.Operarios)
            {
                if (item == e)
                {
                    item.CantidadDeFabricaciones++;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica si la lista de Operadores contiene algo, si no contiene nada lanza una excepcion
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public bool VerificarListaOperadores(Fabrica f)
        {
            if (f.Operarios.Count > 0)
            {
                return true;
            }
            throw new ListaOperariosVaciaException();
        }

        /// <summary>
        /// Verifica si la lista de Alternadores contiene algo, si no contiene nada lanza una excepcion
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public bool VerificarListaAlternadores(Fabrica f)
        {
            if (f.Alternadores.Count > 0)
            {
                return true;
            }
            throw new ListaAlternadoresVaciaException();
        }

        /// <summary>
        /// Verifica si la lista de Arranques contiene algo, si no contiene nada lanza una excepcion
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public bool VerificarListaArranques(Fabrica f)
        {
            if (f.Arranques.Count > 0)
            {
                return true;
            }
            throw new ListaArranquesVaciaException();
        }

        /// <summary>
        /// Retorna los datos de la fabrica
        /// </summary>
        /// <returns></returns>
        public string DatosDeLaFabrica()
        {
            StringBuilder fabricaAux = new StringBuilder();
            fabricaAux.Append(this.MostrarEmpleados());
            fabricaAux.Append(this.MostrarFabricaciones());
            return fabricaAux.ToString();
        }

        /// <summary>
        /// Retorna los datos de los empleados
        /// </summary>
        /// <returns></returns>
        public string MostrarEmpleados()
        {
            StringBuilder fabricaAux = new StringBuilder();
            fabricaAux.AppendLine("Lista de empleados:\n");
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
            foreach(Operario item in this.Operarios)
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
        /// Retorna todas las fabricaciones
        /// </summary>
        /// <returns></returns>
        public string MostrarFabricaciones()
        {
            StringBuilder fabricaAux = new StringBuilder();
            fabricaAux.AppendLine("Lista de fabricaciones: \n");
            fabricaAux.AppendLine(this.MostrarAlternadores());
            fabricaAux.AppendLine(this.MostrarArranques());
            return fabricaAux.ToString();
        }

        /// <summary>
        /// Retorna todos los alternadores fabricados
        /// </summary>
        /// <returns></returns>
        public string MostrarAlternadores()
        {
            StringBuilder fabricaAux = new StringBuilder();
            fabricaAux.AppendLine("Lista de alternadores:");
            foreach (FabricacionAlternadores item in this.Alternadores)
            {
                fabricaAux.AppendLine("Marca: " + item.Marca + " Cantidad fabricados: " + item.Cantidad);
            }
            return fabricaAux.ToString();
        }

        /// <summary>
        /// Retorna todos los arranques fabricados
        /// </summary>
        /// <returns></returns>
        public string MostrarArranques()
        {
            StringBuilder fabricaAux = new StringBuilder();
            fabricaAux.AppendLine("Lista de arranques fabricados:");
            foreach (FabricacionArranques item in this.Arranques)
            {
                fabricaAux.AppendLine("Marca: " + item.Marca + " Cantidad fabricados: " + item.Cantidad);
            }
            return fabricaAux.ToString();
        }


        /// <summary>
        /// Serializa la lista y la guarda
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static bool Guardar(Fabrica f)
        {
            Xml<Fabrica> xml = new Xml<Fabrica>();
            if (xml.Guardar("operarios.log", f))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Lee la lista previamente serializada
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static Fabrica Leer(Fabrica f)
        {
            Xml<Fabrica> xml = new Xml<Fabrica>();
            if (xml.Leer("operarios.log", out Fabrica aux))
            {
                return aux;
            }
            return aux;
        }
        #endregion
    }
}