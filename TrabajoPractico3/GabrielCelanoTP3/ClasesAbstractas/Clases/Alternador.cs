using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesInstanciables
{
    public abstract class Alternador
    {
        #region Atributos
        private bool carcasa;
        private bool polea;
        private bool rotor;
        private bool colector;
        private bool regulador;
        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna y setea el valor booleano de carcasa
        /// </summary>
        public bool Carcasa { get { return this.carcasa; } set { this.carcasa = value; } }

        /// <summary>
        /// Retorna y setea el valor booleano de polea
        /// </summary>
        public bool Polea { get { return this.polea; } set { this.polea = value; } }

        /// <summary>
        /// Retorna y setea el valor booleano de rotor
        /// </summary>
        public bool Rotor { get { return this.rotor; } set { this.rotor = value; } }

        /// <summary>
        /// Retorna y setea el valor booleano de colector
        /// </summary>
        public bool Colector { get { return this.colector; } set { this.colector = value; } }

        /// <summary>
        /// Retorna y setea el valor booleano de regulador
        /// </summary>
        public bool Regulador { get { return this.regulador; } set { this.regulador = value; } }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor de Alternador sin parametros
        /// </summary>
        public Alternador() { }

        /// <summary>
        /// Constructor de Alternador con parametros
        /// </summary>
        /// <param name="carcasa"></param>
        /// <param name="polea"></param>
        /// <param name="rotor"></param>
        /// <param name="colector"></param>
        /// <param name="regulador"></param>
        public Alternador(bool carcasa, bool polea, bool rotor, bool colector, bool regulador)
        {
            this.Carcasa = carcasa;
            this.Polea = polea;
            this.Rotor = rotor;
            this.Colector = colector;
            this.Regulador = regulador;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Retorna los datos del alternador
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder repuestosAux = new StringBuilder();
            repuestosAux.AppendLine($"Rotor: {this.Rotor}");
            repuestosAux.AppendLine($"Colector: {this.Colector}");
            repuestosAux.AppendLine($"Carcasa: {this.Carcasa}");
            repuestosAux.AppendLine($"Regulador: {this.regulador}");
            repuestosAux.AppendLine($"Polea: {this.Polea}");
            return repuestosAux.ToString();
        }
        #endregion
    }
}