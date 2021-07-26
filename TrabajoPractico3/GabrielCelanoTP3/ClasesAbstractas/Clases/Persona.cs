using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Excepciones;
using System.Xml.Serialization;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private int dni;
        #endregion

        #region Propiedades
        /// <summary>
        /// Devuelve el nombre y lo setea
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (this.ValidarString(value))
                {
                    this.nombre = value;
                }
            }
        }
        /// <summary>
        /// Devuelve el apellido y lo setea
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                if (this.ValidarString(value))
                {
                    this.apellido = value;
                }
            }
        }
       
        /// <summary>
        /// Devuelve el dni y lo setea
        /// </summary>
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = this.ValidarDni(value); }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de Persona sin parametros
        /// </summary>
        public Persona() { }

        /// <summary>
        /// Constructor de Persona con parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Persona(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que valida el dni, si la validacion es true lo retorna, si no lanza una excepcion
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        private int ValidarDni(int dni)
        {
            if (dni >= 1 && dni <= 99999999)
            {
                return dni;
            }
            else
            {
                throw new DniInvalidoException();
            }
        }

        /// <summary>
        /// Metodo que valida un string, si es un string retorna true, si no lanza una excepcion
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool ValidarString(string str)
        {
            if (Regex.IsMatch(str, @"^[a-zA-Z]+$"))
            {
                return true;
            }
            throw new StringInvalidoException();
        }

        /// <summary>
        /// Retorno los datos de la persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder personaAux = new StringBuilder();
            personaAux.AppendLine($"Nombre completo: {this.Apellido}, {this.Nombre}");
            personaAux.AppendLine($"DNI: {this.DNI}");
            return personaAux.ToString();
        }
        #endregion
    }
}