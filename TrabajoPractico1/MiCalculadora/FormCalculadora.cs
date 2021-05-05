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
            this.Limpiar();
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

            double resultado = Operar(this.txtNumero1.Text,this.txtNumero2.Text, this.cmbOperador.Text);
            string strResultado = resultado.ToString();
            lblResultado.Text = strResultado;
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;


            //else
            //{
            //    MessageBox.Show("1. Primero ingresar los numeros a operar. \n2. Segundo seleccionar operador.", "Atencion!", MessageBoxButtons.OK);
            //}

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
            Numero numeroBinario = new Numero();
            this.lblResultado.Text = numeroBinario.DecimalBinario(this.lblResultado.Text);
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = true;
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
            this.lblResultado.Text = numDecimal.BinarioDecimal(this.lblResultado.Text);
            this.btnConvertirABinario.Enabled = true;
            this.btnConvertirADecimal.Enabled = false;
        }

        /// <summary>
        /// Deshabilita los botones ConvertirABinario y ConvertirADecimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
        }

        #region Metodos
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
            //double resultado;
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            //Calculadora calculo = new Calculadora();
            return Calculadora.Operar(num1, num2, operador[0]);
        }

        /// <summary>
        /// Restablesco los TextBox, el ComboBov y el Label por defecto
        /// Deshabilita los botones de conversion
        /// </summary>
        private void Limpiar()
        {
            this.lblResultado.Text = "";
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "Operador";
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
        }
        #endregion
    }
}
