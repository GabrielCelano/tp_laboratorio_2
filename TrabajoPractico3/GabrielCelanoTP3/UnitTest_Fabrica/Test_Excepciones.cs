using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClasesInstanciables;
using Excepciones;

namespace UnitTestFabrica
{
    [TestClass]
    public class Test_Excepciones
    {
        /// <summary>
        /// Lanza la excepcion si el dni es menor a 1 o mayor a 99999999
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void DniInvalidon()
        {
            Operario operario = new Operario("Gabriel", "Celano", 999999999, 1000, Enumerados.EPuestoDeTrabajo.FabricanteDeArranques, 0);
        }

        /// <summary>
        /// Lanza la excepcion si el id es menor a 1000
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(IDInvalidoException))]
        public void IDInvalido()
        {
            Operario operario = new Operario("Gabriel", "Celano", 39958895, 99, Enumerados.EPuestoDeTrabajo.FabricanteDeArranques, 0);
        }

        /// <summary>
        /// Lanza una excepcion si el nombre o el apellido no son letras
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(StringInvalidoException))]
        public void StringInvalido()
        {
            Operario operario = new Operario("Gabriel", "888", 39958895, 99, Enumerados.EPuestoDeTrabajo.FabricanteDeArranques, 0);
        }

        /// <summary>
        /// Lanza una excepcion si el dni o id de un usuario se es igual a otro que ya esta cargado en la lista
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(OperarioRepetidoException))]
        public void OperarioRepetido()
        {
            Fabrica lista = new Fabrica();
            Operario operario1 = new Operario("Gabriel", "Celano", 39958895, 1000, Enumerados.EPuestoDeTrabajo.FabricanteDeArranques, 0);
            Operario operario2 = new Operario("Sebastian", "Paez", 39999999, 1000, Enumerados.EPuestoDeTrabajo.FabricanteDeAlternadores, 0);
            lista += operario1;
            lista += operario2;            
        }

        /// <summary>
        /// Lanza una excepcion si la lista de operarios esta vacia
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ListaOperariosVaciaException))]
        public void ListaOperariosVacia()
        {
            Fabrica fabrica = new Fabrica();
            fabrica.VerificarListaOperadores();
        }

        /// <summary>
        /// Lanza una excepcion si la lista de arranques esta vacia
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ListaArranquesVaciaException))]
        public void ListaArranquesVacia()
        {
            Fabrica fabrica = new Fabrica();
            fabrica.VerificarListaArranques();
        }

        /// <summary>
        /// Lanza una excepcion si la lista de alternadores esta vacia
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ListaAlternadoresVaciaException))]
        public void ListaAlternadoreVacia()
        {
            Fabrica fabrica = new Fabrica();
            fabrica.VerificarListaAlternadores();
        }

    }
}
