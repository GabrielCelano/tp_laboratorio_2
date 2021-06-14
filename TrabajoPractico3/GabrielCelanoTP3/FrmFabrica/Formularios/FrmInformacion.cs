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
    public partial class FrmInformacion : Form
    {
        #region Atributos
        private Fabrica fabrica;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor del formulario con parametros que instancia el atributo fabrica
        /// </summary>
        /// <param name="fabrica"></param>
        public FrmInformacion(Fabrica fabrica)
        {
            this.fabrica = fabrica;
            InitializeComponent();
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Evento que muestra la lista de empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListaDeEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.fabrica.VerificarListaOperadores(this.fabrica))
                {
                    this.rtbLista.Text = this.fabrica.MostrarEmpleados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Muestra la lista de arranques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListaDeArranques_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.fabrica.VerificarListaArranques(this.fabrica))
                {
                    this.rtbLista.Text = this.fabrica.MostrarArranques();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Muestra la lista de alternadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListaDeAlternadores_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.fabrica.VerificarListaAlternadores(this.fabrica))
                {
                    this.rtbLista.Text = this.fabrica.MostrarAlternadores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
