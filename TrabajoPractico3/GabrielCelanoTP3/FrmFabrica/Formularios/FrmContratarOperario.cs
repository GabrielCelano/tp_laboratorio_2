using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Enumerados;
using ClasesInstanciables;
using Excepciones;

namespace FrmFabrica
{
    public partial class FrmContratarOperario : Form
    {
        #region Atributos
        private Fabrica fabrica;
        private EPuestoDeTrabajo puesto;
        private Operario operario;
        private int count;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor del formulario con parametros que instancia el atributo fabrica
        /// </summary>
        /// <param name="fabrica"></param>
        public FrmContratarOperario(Fabrica fabrica)
        {
            this.fabrica = fabrica;
            this.count = 0;
            InitializeComponent();
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Evento que deshabilita el evento Asignar y establace los enumerados al ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAsignarOperarios_Load(object sender, EventArgs e)
        {
            btnAsignar.Enabled = false;
            this.cmbPuesto.DataSource = Enum.GetValues(typeof(EPuestoDeTrabajo));
        }

        /// <summary>
        /// Evento que verifica si el operario ya existe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                Enum.TryParse(cmbPuesto.SelectedValue.ToString(), out this.puesto);
                this.operario = new Operario(this.txtNombre.Text, this.txtApellido.Text, (int)this.nudDNI.Value, (int)this.nudID.Value, this.puesto, 0);

                if (this.fabrica != this.operario)
                {
                    MessageBox.Show("Empleado aprobado!", "Aviso", MessageBoxButtons.OK);
                    btnAsignar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Evento que asigna el operador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                this.fabrica += this.operario;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
