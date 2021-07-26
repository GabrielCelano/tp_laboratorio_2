using Archivos;
using ClasesInstanciables.Clases;
using ClasesInstanciables.Enumerados;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;

namespace UnitTestFabrica
{
    [TestClass]
    public class Test_Excepciones
    {
        /// <summary>
        /// Testea DniInvalidoException
        /// </summary>
        /// <param name="dni"></param>
        [TestMethod]
        [DataRow(0)]
        [DataRow(999999999)]
        [ExpectedException(typeof(DniInvalidoException))]
        public void DniInvalido(int dni)
        {
            Operario operario = new Operario("Gabriel", "Celano", dni, EPuestoDeTrabajo.FabricanteDeArranques, 1);
        }

        /// <summary>
        /// Testea StringInvalidoException
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        [TestMethod]
        [DataRow("Gabriel", "54564")]
        [DataRow("54564", "Celano")]
        [DataRow("47565", "54564")]
        [ExpectedException(typeof(StringInvalidoException))]
        public void StringInvalido(string nombre, string apellido)
        {
            Operario operario = new Operario(nombre, apellido, 9999, EPuestoDeTrabajo.FabricanteDeArranques, 1);
        }

        /// <summary>
        /// Testea ListaDeFabricacionesVaciaException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ListaDeFabricacionesVaciaException))]
        public void ListaDeFabricacionesVacia()
        {
            Fabricacion fabricacion = new Fabricacion();
            fabricacion.VerificarListaDeFabricaciones();
        }

        /// <summary>
        /// Testa ListaOperariosVaciaException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ListaOperariosVaciaException))]
        public void ListaDeOperariosVacia()
        {
            Fabrica fabrica = new Fabrica();
            fabrica.VerificarListaOperadores();
        }

        /// <summary>
        /// Testea ArchivoException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArchivoException))]
        public void LeerArchivo()
        {
            Xml<Operario> xml = new Xml<Operario>();
            xml.Leer("hola mundo.log");
        }
    }
}
