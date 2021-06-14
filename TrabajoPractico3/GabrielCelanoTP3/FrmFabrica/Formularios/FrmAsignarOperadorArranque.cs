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
using Enumerados;

namespace FrmFabrica
{
    public partial class FrmAsignarOperadorArranque : Form
    {
        #region Atributos
        private Fabrica fabrica;
        private Operario operario;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor del formulario con parametros que isntancia el atributo operario y fabrica
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="operario"></param>
        public FrmAsignarOperadorArranque(Fabrica fabrica, Operario operario)
        {
            this.operario = operario;
            this.fabrica = fabrica;
            InitializeComponent();
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Evento que asigna el operador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignarOperador_Click(object sender, EventArgs e)
        {
            if (dgvOperariosArranques.SelectedRows.Count > 0)
            {
                if (this.AsignarOperadorDgv())
                {
                    MessageBox.Show("El operador se asigno correctamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seleccionar un operador del sector arranques!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Evento Load que establece la lista de Operarios en el DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAsignarOperadorArranque_Load(object sender, EventArgs e)
        {
            this.dgvOperariosArranques.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOperariosArranques.DataSource = this.fabrica.Operarios;
        }

        /// <summary>
        /// Evento de cierre del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que asigna los datos del DataGridView al Operario
        /// </summary>
        /// <returns></returns>
        public bool AsignarOperadorDgv()
        {
            int aux;
            aux = dgvOperariosArranques.CurrentRow.Index;
            if (EPuestoDeTrabajo.FabricanteDeArranques == (EPuestoDeTrabajo)Enum.Parse(typeof(EPuestoDeTrabajo), dgvOperariosArranques.Rows[aux].Cells[1].Value.ToString()))
            {
                this.operario.CantidadDeFabricaciones = Convert.ToInt32(dgvOperariosArranques.Rows[aux].Cells[0].Value.ToString());
                this.operario.Puesto = (EPuestoDeTrabajo)Enum.Parse(typeof(EPuestoDeTrabajo), dgvOperariosArranques.Rows[aux].Cells[1].Value.ToString());
                this.operario.Puesto = EPuestoDeTrabajo.FabricanteDeArranques;
                this.operario.ID = Convert.ToInt32(dgvOperariosArranques.Rows[aux].Cells[2].Value.ToString());
                this.operario.Nombre = dgvOperariosArranques.Rows[aux].Cells[3].Value.ToString();
                this.operario.Apellido = dgvOperariosArranques.Rows[aux].Cells[4].Value.ToString();
                this.operario.DNI = Convert.ToInt32(dgvOperariosArranques.Rows[aux].Cells[5].Value.ToString());
                return true;
            }
            return false;
        }
        #endregion

    }
}
