using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Resetea los datos del Label, del ComboBox y de los TextBox
        /// Deshabilita los botones de convertir binario y decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "Operador";
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        /// <summary>
        /// Valida que en el ComboBox se haya seleccionado un operador y que en los TextBox tengan datos para poder realizar la operacion
        /// Llama al metodo Operar, pasando por parametro los datos de los TextBox y del ComboBox, luego muestra el resultado por el Label y se habilita el boton ConvertirABinario
        /// Si la primer validacion es falsa da un mensaje de error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOperar_Click(object sender, EventArgs e)
        {
            if (cmbOperador.SelectedIndex != -1 && txtNumero1.TextLength !=0 && txtNumero2.TextLength != 0)
            {
                double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
                lblResultado.Text = resultado.ToString();
                btnConvertirABinario.Enabled = true;
                btnConvertirADecimal.Enabled = false;
            }

            else
            {
                MessageBox.Show("1. Primero ingresar los numeros a operar. \n2. Segundo seleccionar operador.", "Atencion!", MessageBoxButtons.OK);
            }

        }

        /// <summary>
        /// Instancia la calculadora y los dos operadores ingresados por el usuario, valida estos operadores y los operando(por si quiere dividir por cero) y luego hace la operacion y retorna el resultado
        /// En caso de no poder realizar la operacion da un mesaje de error y devuelve 0
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>double</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double aux1;
            double aux2;

            if (double.TryParse(numero1, out aux1) && double.TryParse(numero2, out aux2) && (aux2 != 0 || operador != "/"))
            {
                //double resultado;
                Numero operador1 = new Numero(aux1);
                Numero operador2 = new Numero(aux2);
                //Calculadora calculo = new Calculadora();
                return Calculadora.Operar(operador1, operador2, operador);
            }

            else
            {
                MessageBox.Show("Error en los campos ingresados!\nPosible error: No se puede dividir por cero.", "Atencion!", MessageBoxButtons.OK);
                return 0;
            }          
        }

        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Valida que el resultado que se encuentra en el Label sea entero
        /// Instancia la clase Numero y llama al metodo DecimalBinario de la misma, para realizar la conversion
        /// Muestra el resultado por el label
        /// Deshabilita el boton ConvertirABinario y habilita el boton ConvertirADecimal
        /// Caso contrario a la primer validacion da un mensaje de error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            int aux;
            if (int.TryParse(lblResultado.Text, out aux))
            {
                Numero numeroBinario = new Numero();
                lblResultado.Text = numeroBinario.DecimalBinario(aux);
                btnConvertirABinario.Enabled = false;
                btnConvertirADecimal.Enabled = true;
            }

            else
            {
                MessageBox.Show("Solo se puede convertir a binario numeros enteros!", "Atencion!", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Instancia la clase Numero, y llama al metodo BinarioDecimal de la misma para realizar la conversion
        /// Muestra el resultado por el Label
        /// Habilita el boton ConvertirABinario y deshabilita el boton ConvertirADecimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numDecimal = new Numero();
            lblResultado.Text = numDecimal.BinarioDecimal(lblResultado.Text);
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }

        /// <summary>
        /// Deshabilita los botones ConvertirABinario y ConvertirADecimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }
    }
}
