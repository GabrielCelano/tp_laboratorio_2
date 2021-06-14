using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public abstract class Persona
    {
        public enum EPuesto { FabricanteDeArranque, FabricanteDeAlternador }
        private string nombre;
        private string apellido;
        private int dni;
        private short edad;
        private EPuesto puesto;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public short Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        public EPuesto Puesto
        {
            get { return this.puesto; }
            set { this.puesto = value; }
        }
        public Persona(string nombre, string apellido, int dni, short edad, EPuesto puesto)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.Edad = edad;
            this.Puesto = puesto;
        }
        private int ValidarDni(int dni)
        {
            if
        }
    }
}
