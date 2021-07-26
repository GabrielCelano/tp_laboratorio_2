using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace ClasesInstanciables.Clases
{
    public class Fabricacion
    {
        private List<Alternador> alternadores;
        private List<Arranque> arranques;

        #region Propiedades
        /// <summary>
        /// Devuelve y setea la lista de alternadores
        /// </summary>
        public List<Alternador> Alternadores { get { return this.alternadores; } set { this.alternadores = value; } }

        /// <summary>
        /// Devuelve y setea la lista de arranques
        /// </summary>
        public List<Arranque> Arranques { get { return this.arranques; } set { this.arranques = value; } }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de clase sin parametros que setea las listas de Alternadores y Arranques
        /// </summary>
        public Fabricacion()
        {
            this.Alternadores = new List<Alternador>();
            this.Arranques = new List<Arranque>();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Valida si un Alternador se encuentra en la lista, si se encuentra retorna true, caso contrario false
        /// </summary>
        /// <param name="s"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Fabricacion s, Alternador a)
        {
            foreach (Alternador item in s.Alternadores)
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
        /// Valida si el Alternador no se encuentra en la lista
        /// </summary>
        /// <param name="s"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Fabricacion s, Alternador a)
        {
            return !(s == a);
        }

        /// <summary>
        /// Agrega un Alternador a la lista si este no se encuentra
        /// </summary>
        /// <param name="s"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Fabricacion operator +(Fabricacion s, Alternador a)
        {
            if (s != a)
            {
                s.Alternadores.Add(a);
                return s;
            }
            return s;
        }

        /// <summary>
        /// Valida si un Arranque se encuentra en la lista, si se encuentra retorna true, caso contrario false
        /// </summary>
        /// <param name="s"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Fabricacion s, Arranque a)
        {
            foreach (Arranque item in s.Arranques)
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
        /// Valida si el Arranque no se encuentra en la lista
        /// </summary>
        /// <param name="s"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Fabricacion s, Arranque a)
        {
            return !(s == a);
        }

        /// <summary>
        /// Agrega un Arranque a la lista si este no se encuentra
        /// </summary>
        /// <param name="s"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Fabricacion operator +(Fabricacion s, Arranque a)
        {
            if (s != a)
            {
                s.Arranques.Add(a);
                return s;
            }
            return s;
        }

        /// <summary>
        /// Retorna la lista completa de fabricaciones
        /// </summary>
        /// <returns></returns>
        public string ListaDeFabricaciones()
        {
            StringBuilder listaAux = new StringBuilder();
            listaAux.AppendLine($"Lista de fabricaciones el dia {DateTime.Now}");
            listaAux.AppendLine("Lista de alternadores:");
            listaAux.AppendLine(this.ListaDeAlternadores());
            listaAux.AppendLine("\nLista de arranques:");
            listaAux.AppendLine(this.ListaDeArranques());
            return listaAux.ToString();
        }

        /// <summary>
        /// Retorna la lista de alternadores fabricados
        /// </summary>
        /// <returns></returns>
        private string ListaDeAlternadores()
        {
            StringBuilder listaAux = new StringBuilder();
            foreach (Alternador item in this.Alternadores)
            {
                listaAux.AppendLine(item.Marca.ToString() + " " + item.Cantidad.ToString());
            }
            return listaAux.ToString();
        }


        /// <summary>
        /// Retorna la lista de arranques fabricados
        /// </summary>
        /// <returns></returns>
        private string ListaDeArranques()
        {
            StringBuilder listaAux = new StringBuilder();
            foreach (Arranque item in this.Arranques)
            {
                listaAux.AppendLine(item.Marca.ToString() + " " + item.Cantidad.ToString());
            }
            return listaAux.ToString();
        }


        /// <summary>
        /// Comprueba si alguna de las listas contiene algo, retorna true si contiene, caso contrario false
        /// </summary>
        /// <returns></returns>
        public bool VerificarListaDeFabricaciones()
        {
            if (this.Alternadores.Count > 0 || this.Arranques.Count > 0)
            {
                return true;
            }
            throw new ListaDeFabricacionesVaciaException();
        }
        #endregion
    }
}
