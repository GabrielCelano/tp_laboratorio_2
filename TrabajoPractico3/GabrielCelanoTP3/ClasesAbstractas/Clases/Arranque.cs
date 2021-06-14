using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesInstanciables
{
    public abstract class Arranque
    {
        #region Atributos
        private bool carcasa;
        private bool horquilla;
        private bool bendix;
        private bool bobina;
        private bool automatico;
        private bool plaqueta;
        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna y setea el valor booleano de carcasa
        /// </summary>
        public bool Carcasa { get { return this.carcasa; } set { this.carcasa = value; } }

        /// <summary>
        /// Retorna y setea el valor booleano de horquilla
        /// </summary>
        public bool Horquilla { get { return this.horquilla; } set { this.horquilla = value; } }

        /// <summary>
        /// Retorna y setea el valor booleano de bendix
        /// </summary>
        public bool Bendix { get { return this.bendix; } set { this.bendix = value; } }

        /// <summary>
        /// Retorna y setea el valor booleano de bobina
        /// </summary>
        public bool Bobina { get { return this.bobina; } set { this.bobina = value; } }

        /// <summary>
        /// Retorna y setea el valor booleano de automatico
        /// </summary>
        public bool Automatico { get { return this.automatico; } set { this.automatico = value; } }

        /// <summary>
        /// Retorna y setea el valor booleano de bobina
        /// </summary>
        public bool Plaqueta { get { return this.plaqueta; } set { this.plaqueta = value; } }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de Arranque sin parametros
        /// </summary>
        public Arranque() { }

        /// <summary>
        /// Constructor de Arranque con parametros
        /// </summary>
        /// <param name="carcasa"></param>
        /// <param name="horquilla"></param>
        /// <param name="bendix"></param>
        /// <param name="bobina"></param>
        /// <param name="automatico"></param>
        /// <param name="plaqueta"></param>
        public Arranque(bool carcasa, bool horquilla, bool bendix, bool bobina, bool automatico, bool plaqueta)
        {
            this.Carcasa = carcasa;
            this.Horquilla = horquilla;
            this.Bendix = bendix;
            this.Bobina = bobina;
            this.Automatico = automatico;
            this.Plaqueta = plaqueta;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Retorna los datos del arranque
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder repuestosAux = new StringBuilder();
            repuestosAux.AppendLine($"Bobina: {this.Bobina}");
            repuestosAux.AppendLine($"Bendix: {this.Bendix}");
            repuestosAux.AppendLine($"Horquilla: {this.Horquilla}");
            repuestosAux.AppendLine($"Plaqueta: {this.Plaqueta}");
            repuestosAux.AppendLine($"Carcasa: {this.Carcasa}");
            repuestosAux.AppendLine($"Automatico: {this.Automatico}");
            return repuestosAux.ToString();
        }
        #endregion
    }
}