using ClasesInstanciables.Enumerados;
using Excepciones;
using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ClasesInstanciables.Clases
{
    public class Arranque : IFabricar
    {
        public delegate void Fabricar(string mensaje, bool boolean);
        public event Fabricar EventoFabricacion;
        public event Fabricar EventoValidarFabricacion;
        #region Atributos
        private EMarca marca;
        private int cantidad;
        #endregion

        #region Propiedades
        /// <summary>
        /// Devuelve y setea la marca del arranque
        /// </summary>
        public EMarca Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        /// <summary>
        /// Devuelve y setea la cantidad de fabricaciones 
        /// </summary>
        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de Arranque sin parametros
        /// </summary>
        public Arranque() { }

        /// <summary>
        /// Constructor de Arranque con parametros
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="cantidad"></param>
        public Arranque(EMarca marca, int cantidad)
        {
            this.Marca = marca;
            this.Cantidad = cantidad;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Valida si la marca del arranque concuerda con las del enumerado EMarca
        /// </summary>
        /// <returns></returns>
        public bool ValidarFabricacion()
        {
            if (this.Marca == EMarca.Bosch || this.Marca == EMarca.Denso || this.Marca == EMarca.Marelli || this.Marca == EMarca.Valeo && this.Cantidad == 1)
            {
                return true;
            }
            throw new VerificacionInvalidaException();
        }

        /// <summary>
        /// Llama a los metodos InicioFabricacion y FinalFabricacion
        /// </summary>
        public void ComenzarFabricacion()
        {
            this.InicioFabricacion();
            this.FinalFabricacion();
        }

        /// <summary>
        /// Llama a los metodos InicioVerificacion y FinalVerificacion, antes validando el arranque
        /// </summary>
        public void VerificarFabricacion()
        {
            if (ValidarFabricacion())
            {
                this.InicioVerificacion();
                this.FinalVerificacion();
            }
        }

        /// <summary>
        /// Metodo que comienza la fabricacion
        /// </summary>
        private void InicioFabricacion()
        {
            string mensaje = string.Format("Comenzando la fabricacion... \nRectificando bobina y colocandole la horquilla...");
            if (!object.ReferenceEquals(EventoFabricacion, null))
                this.EventoFabricacion.Invoke(mensaje, false);
        }

        /// <summary>
        /// Metodo que finaliza la fabricacion
        /// </summary>
        private void FinalFabricacion()
        {
            string mensaje = string.Format("\nColocando bendix y plaqueta... \nColocando automatico y carcasa...");
            Thread.Sleep(4000);
            if (!object.ReferenceEquals(EventoFabricacion, null))
                this.EventoFabricacion.Invoke(mensaje, true);
        }

        /// <summary>
        /// Metodo que inicia la verificacion
        /// </summary>
        private void InicioVerificacion()
        {
            string mensaje = string.Format($"\n\nComenzando la verificacion del alternador: {this.Marca}");
            if (this.ValidarFabricacion())
            {
                mensaje += string.Format("\nMidiendo bobina...\nAceitando horquilla... ");
                if (!object.ReferenceEquals(EventoValidarFabricacion, null))
                    this.EventoValidarFabricacion.Invoke(mensaje, false);
            }
        }


        /// <summary>
        /// Metodo que finaliza la verificacion
        /// </summary>
        private void FinalVerificacion()
        {
            string mensaje = string.Format("\nComprobando empuje del bendix y midiendo la plaqueta...\nComprobando funcionalidad del automatico... ");
            Thread.Sleep(4000);
            if (!object.ReferenceEquals(EventoValidarFabricacion, null))
                this.EventoValidarFabricacion.Invoke(mensaje, true);
        }
        #endregion
    }
}