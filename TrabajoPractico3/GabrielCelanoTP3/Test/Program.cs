using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesInstanciables;
using Excepciones;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabrica lista = new Fabrica();
            JornadaLaboral jornada = new JornadaLaboral();
            try
            {
                Operario op1 = new Operario("Gabriel", "Celano", 39958895, 1000, Enumerados.EPuestoDeTrabajo.FabricanteDeAlternadores, 0);
                lista += op1;
            }
            catch (Exception e)
            {
                Console.WriteLine("op1 " + e.Message);
            }

            try
            {
                Operario op2 = new Operario("Yolanda", "23434", 39958895, 1000, Enumerados.EPuestoDeTrabajo.FabricanteDeAlternadores, 0);
                lista += op2;
            }
            catch (StringInvalidoException e)
            {
                Console.WriteLine("op2 " + e.Message);
            }
            try
            {
                Operario op3 = new Operario("Sebastian", "Paez", 0, 1000, Enumerados.EPuestoDeTrabajo.FabricanteDeAlternadores, 0);
                lista += op3;
            }
            catch (DniInvalidoException e)
            {
                Console.WriteLine("op3 " + e.Message);
            }
            try
            {
                Operario op3 = new Operario("Ricardo", "Celano", 1748562, 1000, Enumerados.EPuestoDeTrabajo.FabricanteDeArranques, 0);
                lista = lista + op3;
            }
            catch (OperarioRepetidoException e)
            {
                Console.WriteLine("op3 " + e.Message);
            }

            try
            {
                Operario op4 = new Operario("Ezequiel", "Rivas", 1748562, 9, Enumerados.EPuestoDeTrabajo.FabricanteDeArranques, 0);
                lista = lista + op4;
            }
            catch (IDInvalidoException e)
            {
                Console.WriteLine("op4 " + e.Message);
            }

            FabricacionAlternadores alternador = new FabricacionAlternadores(10, "Valeo", false, false, false, false, false);
            FabricacionArranques arranque = new FabricacionArranques(15, "Bosch", false, false, false, false, false, false);

            Console.WriteLine("Alternador: \n");
            Console.WriteLine(alternador.RectificarRotor());
            Console.WriteLine(alternador.ColocarColector());
            Console.WriteLine(alternador.ColocarCarcasa());
            Console.WriteLine(alternador.ColocarRegulador());
            Console.WriteLine(alternador.ColocarPolea());
            Console.WriteLine(alternador.VerificarAlternador());
            Console.WriteLine("\n\n");
            Console.WriteLine(alternador.RectificarRotor());
            Console.WriteLine(alternador.ColocarColector());
            Console.WriteLine(alternador.ColocarCarcasa());
            Console.WriteLine(alternador.ColocarRegulador());
            Console.WriteLine(alternador.ColocarPolea());
            Console.WriteLine("\n\n");

            Console.WriteLine("Arranque: \n");
            Console.WriteLine(arranque.ColocarAutomatico());
            Console.WriteLine(arranque.ColocarBendix());
            Console.WriteLine(arranque.ColocarHorquilla());
            Console.WriteLine(arranque.ColocarPlaqueta());
            Console.WriteLine(arranque.ColocarAutomatico());
            Console.WriteLine(arranque.RectificarBobina());
            Console.WriteLine(arranque.VerificarArranque());
            Console.WriteLine("\n\n");
            Console.WriteLine(arranque.ColocarAutomatico());
            Console.WriteLine(arranque.ColocarBendix());
            Console.WriteLine(arranque.ColocarHorquilla());
            Console.WriteLine(arranque.ColocarPlaqueta());
            Console.WriteLine(arranque.ColocarAutomatico());
            Console.WriteLine(arranque.RectificarBobina());

            lista.Alternadores.Add(alternador);
            lista.Arranques.Add(arranque);

            Fabrica.Guardar(lista);
            JornadaLaboral.Guardar(lista, jornada);

            //Console.WriteLine(Fabrica.Leer(lista));

            Console.WriteLine(lista.MostrarOperarios());
            Console.ReadKey();
        }
    }
}
