using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enumerados;
using Archivos;

namespace ClasesInstanciables
{
    public class JornadaLaboral
    {
        #region Atributos
        private List<Operario> operarios;
        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna y setea la lista de tipo Operarios, almacena todos los operarios cargados
        /// </summary>
        public List<Operario> Operarios { get { return this.operarios; } set { this.operarios = value; } }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de clase que instancia la lista de operarios 
        /// </summary>
        public JornadaLaboral()
        {
            this.operarios = new List<Operario>();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Cromprueba si el Operario se encuentra en la lista Operadores
        /// </summary>
        /// <param name="j"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public static bool operator ==(JornadaLaboral j, Operario o)
        {
            foreach (Operario item in j.operarios)
            {
                if (item == o)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Comprueba si el Operario no se encuentra en la lista de Operadores
        /// </summary>
        /// <param name="j"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public static bool operator !=(JornadaLaboral j, Operario o)
        {
            return !(j == o);
        }

        /// <summary>
        /// Agrega un Operador nuevo a la lista Operadores
        /// </summary>
        /// <param name="f"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public static JornadaLaboral operator +(JornadaLaboral f, Operario o)
        {
            if (f != o)
            {
                f.Operarios.Add(o);
            }
            return f;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Retorna la jornada laboral
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public string MostrarJornada(Fabrica f)
        {
            StringBuilder jornadaAux = new StringBuilder();
            jornadaAux.AppendLine($"Operarios que trabajaron el dia {DateTime.Now}");
            foreach (Operario item in f.Operarios)
            {
                if (item.CantidadDeFabricaciones > 0)
                {
                    jornadaAux.AppendLine(item.MostrarDatos());
                }
            }


            jornadaAux.AppendLine("\n\nLista de alternadores fabricados: ");
            foreach (FabricacionAlternadores item in f.Alternadores)
            {
                jornadaAux.AppendLine("Marca: " + item.Marca + "/ Cantidad fabricados:" + item.Cantidad);
            }


            jornadaAux.AppendLine("\nLista de arranques fabricados: ");
            foreach (FabricacionArranques item in f.Arranques)
            {
                jornadaAux.AppendLine("Marca: " + item.Marca + "/ Cantidad fabricados:" + item.Cantidad);
            }
            return jornadaAux.ToString();
        }

        /// <summary>
        /// Metodo estatico que guarda la jornada laboral en un archivo txt
        /// </summary>
        /// <param name="f"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool Guardar(Fabrica f, JornadaLaboral j)
        {
            Texto txt = new Texto();
            return txt.Guardar("jornada.log", j.MostrarJornada(f));
        }

        /// <summary>
        /// Metodo estatico que lee una jornada laboral previamente generada
        /// <param name="j"></param>
        /// <returns></returns>
        public static string Leer(JornadaLaboral j)
        {
            Texto txt = new Texto();
            string aux = "";
            txt.Leer("jornada.log", out aux);
            return aux;
        }
        #endregion
    }
}