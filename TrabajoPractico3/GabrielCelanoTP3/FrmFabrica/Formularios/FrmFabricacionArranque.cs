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
    public partial class FrmFabricacionArranque : Form
    {
        #region Atributos
        private Fabrica fabrica;
        private FabricacionArranques arranque;
        private Operario operario;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor del formulario con parametros que instancia el atributo fabrica, arranque y operario
        /// </summary>
        /// <param name="fabrica"></param>
        public FrmFabricacionArranque(Fabrica fabrica)
        {
            this.arranque = new FabricacionArranques();
            this.fabrica = fabrica;
            this.operario = new Operario();
            InitializeComponent();
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Evento Load que asigna las marcas y deshabilita el evento FinalizarFabricacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFabricacionArranque_Load(object sender, EventArgs e)
        {
            this.AsignarMarcas();
            this.btnFinalizarFabricacion.Enabled = false;
        }

        /// <summary>
        /// Evento que rectifica la Bobina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRectificarBobina_Click(object sender, EventArgs e)
        {
            if (this.lblNombreOperador.Text.Length > 0 && this.cmbMarca.Text != "")
            {
                MessageBox.Show(this.arranque.RectificarBobina(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero debe realizar el paso 1!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento que coloca el Bendix
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColocarBendix_Click(object sender, EventArgs e)
        {
            if (this.arranque.Bobina)
            {
                MessageBox.Show(this.arranque.ColocarBendix(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero debe realizar el paso 2!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento que coloca la Horquilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColocarHorquilla_Click(object sender, EventArgs e)
        {
            if (this.arranque.Bendix)
            {
                MessageBox.Show(this.arranque.ColocarHorquilla(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero debe realizar el paso 3!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento que coloca la Plaqueta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColocarPlaqueta_Click(object sender, EventArgs e)
        {
            if (this.arranque.Horquilla)
            {
                MessageBox.Show(this.arranque.ColocarPlaqueta(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero debe realizar el paso 4!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento que coloca la Carcasa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColocarCarcasa_Click(object sender, EventArgs e)
        {
            if (this.arranque.Plaqueta)
            {
                MessageBox.Show(this.arranque.ColocarCarcasa(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero debe realizar el paso 5!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento que coloca el Automatico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColocarAutomatico_Click(object sender, EventArgs e)
        {
            if (this.arranque.Carcasa)
            {
                MessageBox.Show(this.arranque.ColocarAutomatico(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero debe realizar el paso 6!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento que muestra las instrucciones de fabricado
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
                this.arranque.Marca = this.cmbMarca.Text;
                this.rtbInformacion.Text = this.arranque.VerificarArranque();
                if (this.arranque.ValidarFabricacion(this.arranque))
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
                    FrmAsignarOperadorArranque frmAsignarOperadorArranque = new FrmAsignarOperadorArranque(this.fabrica, this.operario);
                    frmAsignarOperadorArranque.ShowDialog();
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
                this.arranque.Cantidad++;
                this.fabrica.SumarFabricacion(this.fabrica, this.operario);
                this.fabrica += this.arranque;
                MessageBox.Show("Fabricacion finalizada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Asigna las marcas al ComboBox
        /// </summary>
        private void AsignarMarcas()
        {
            this.cmbMarca.Items.Add("Valeo");
            this.cmbMarca.Items.Add("Bosch");
            this.cmbMarca.Items.Add("Denso");
            this.cmbMarca.Items.Add("Marelli");
            this.cmbMarca.Items.Add("Indiel");
            this.cmbMarca.Items.Add("HELLA");
        }

        /// <summary>
        /// Asigna las instrucciones al RichTextBox
        /// </summary>
        /// <returns></returns>
        private string Instrucciones()
        {
            StringBuilder instruccionesAux = new StringBuilder();
            instruccionesAux.AppendLine("Pasos a seguir para la fabricacion del arranque:\n");
            instruccionesAux.AppendLine("1. Asignar Operador y Marca");
            instruccionesAux.AppendLine("2. Rectificar bobina");
            instruccionesAux.AppendLine("3. Colocar bendix");
            instruccionesAux.AppendLine("4. Colocar horquilla");
            instruccionesAux.AppendLine("5. Colocar plaqueta");
            instruccionesAux.AppendLine("6. Colocar carcasa");
            instruccionesAux.AppendLine("7. Colocar automatico");
            instruccionesAux.AppendLine("8. Verificar arranque");
            instruccionesAux.AppendLine("\n\nSeguir los pasos para la correcta fabricacion del arranque.");
            return instruccionesAux.ToString();
        }
        #endregion

    }
}
