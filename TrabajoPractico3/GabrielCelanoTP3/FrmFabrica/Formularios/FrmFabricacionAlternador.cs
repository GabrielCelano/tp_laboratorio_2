using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesInstanciables;

namespace FrmFabrica
{
    public partial class FrmFabricacionAlternador : Form
    {
        #region Atributos
        private Fabrica fabrica;
        private FabricacionAlternadores alternador;
        private Operario operario;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor del formulario con parametros que instancia el atributo fabrica, alternador y operario
        /// </summary>
        /// <param name="fabrica"></param>
        public FrmFabricacionAlternador(Fabrica fabrica)
        {
            this.alternador = new FabricacionAlternadores();
            this.fabrica = fabrica;
            this.operario = new Operario();
            InitializeComponent();
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Evento que asigna las Marcas y deshabilita el evento FinalizarFabricacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFabricacionAlternador_Load(object sender, EventArgs e)
        {
            this.AsignarMarcas();
            this.btnFinalizarFabricacion.Enabled = false;
        }

        /// <summary>
        /// Evento que rectifica el Rotor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRectificarRotor_Click(object sender, EventArgs e)
        {
            if (this.lblNombreOperador.Text.Length > 0 && this.cmbMarca.Text != "")
            {
                MessageBox.Show(this.alternador.RectificarRotor(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero debe realizar el paso 1!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento que coloca el Colector
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColocarColector_Click(object sender, EventArgs e)
        {
            if (this.alternador.Rotor)
            {
                MessageBox.Show(this.alternador.ColocarColector(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero debe realizar el paso 2!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento que coloca la Carcasa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColocarCarcasa_Click(object sender, EventArgs e)
        {
            if (this.alternador.Colector)
            {
                MessageBox.Show(this.alternador.ColocarCarcasa(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero debe realizar el paso 3!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento que coloca el Regulador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColocarRegulador_Click(object sender, EventArgs e)
        {
            if (this.alternador.Carcasa)
            {
                MessageBox.Show(this.alternador.ColocarRegulador(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero debe realizar el paso 4!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento que coloca la Polea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColocarPolea_Click(object sender, EventArgs e)
        {
            if (this.alternador.Regulador)
            {
                MessageBox.Show(this.alternador.ColocarPolea(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero debe realizar el paso 5!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento que establece las instrucciones al RichTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInstrucciones_Click(object sender, EventArgs e)
        {
            this.rtbInformacion.Text = this.Instrucciones();
        }


        /// <summary>
        /// Evento que verifica la fabricacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                this.alternador.Marca = this.cmbMarca.Text;
                this.rtbInformacion.Text = this.alternador.VerificarAlternador();
                if (this.alternador.ValidarFabricacion(this.alternador))
                {
                    this.btnFinalizarFabricacion.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nHay un error en el proceso de la fabricacion!, solucionar antes de poder finalizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento que asigna el operador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignarOperador_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.fabrica.VerificarListaOperadores(this.fabrica))
                {
                    FrmAsignarOperadorAlternador frmAsignarOperadorAlternador = new FrmAsignarOperadorAlternador(this.fabrica, this.operario);
                    frmAsignarOperadorAlternador.ShowDialog();
                    this.lblNombreOperador.Text = String.Format(this.operario.Nombre + " " + this.operario.Apellido);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento que finaliza la fabricacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizarFabricacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.alternador.ValidarFabricacion(this.alternador))
                {
                    this.alternador.Cantidad++;
                    this.fabrica.SumarFabricacion(this.fabrica, this.operario);
                    this.fabrica += this.alternador;
                    MessageBox.Show("Fabricacion finalizada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que asigna las marcas al ComboBox
        /// </summary>
        public void AsignarMarcas()
        {
            this.cmbMarca.Items.Add("Valeo");
            this.cmbMarca.Items.Add("Bosch");
            this.cmbMarca.Items.Add("Denso");
            this.cmbMarca.Items.Add("Marelli");
            this.cmbMarca.Items.Add("Hitachi");
            this.cmbMarca.Items.Add("HELLA");
        }

        /// <summary>
        /// Metodo que retorna las instrucciones de fabricacion
        /// </summary>
        /// <returns></returns>
        public string Instrucciones()
        {
            StringBuilder instruccionesAux = new StringBuilder();
            instruccionesAux.AppendLine("Pasos a seguir para la fabricacion del alternador:\n");
            instruccionesAux.AppendLine("1. Asignar Operador y Marca");
            instruccionesAux.AppendLine("2. Rectificar rotor");
            instruccionesAux.AppendLine("3. Colocar colector");
            instruccionesAux.AppendLine("4. Colocar carcasa");
            instruccionesAux.AppendLine("5. Colocar regulador");
            instruccionesAux.AppendLine("6. Colocar polea");
            instruccionesAux.AppendLine("7. Verificar alternador");
            instruccionesAux.AppendLine("\n\nSeguir los pasos para la correcta fabricacion del alternador.");
            return instruccionesAux.ToString();
        }
        #endregion
    }
}
