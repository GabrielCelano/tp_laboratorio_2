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
    public partial class FrmAsignarOperadorAlternador : Form
    {
        #region Atributos
        private Fabrica fabrica;
        private Operario operario;
        #endregion

        #region Construccion
        /// <summary>
        /// Constructor del formulario con parametros que instancia el atributo fabrica y operario
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="operario"></param>
        public FrmAsignarOperadorAlternador(Fabrica fabrica, Operario operario)
        {
            this.operario = operario;
            this.fabrica = fabrica;
            InitializeComponent();
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Evento que asigna un operador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignarOperador_Click(object sender, EventArgs e)
        {
            if (dgvOperariosAlternadores.SelectedRows.Count > 0)
            {
                if (this.AsignarOperadorDgv())
                {
                    MessageBox.Show("El operador se asigno correctamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seleccionar un operador del sector alternadores!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Evento Load que asigna los Operadores al DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAsignarOperadorAlternador_Load(object sender, EventArgs e)
        {
            this.dgvOperariosAlternadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOperariosAlternadores.DataSource = this.fabrica.Operarios;
        }

        /// <summary>
        /// Evento que cierra el form
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
        /// Metodo que asigna al operario la lines seleccionada al DataGridView
        /// </summary>
        /// <returns></returns>
        public bool AsignarOperadorDgv()
        {
            int aux;
            aux = dgvOperariosAlternadores.CurrentRow.Index;

            if (EPuestoDeTrabajo.FabricanteDeAlternadores == 
                (EPuestoDeTrabajo)Enum.Parse(typeof(EPuestoDeTrabajo)
                , this.dgvOperariosAlternadores.Rows[aux].Cells[1].Value.ToString()))
            {
                this.operario.CantidadDeFabricaciones = Convert.ToInt32(dgvOperariosAlternadores.Rows[aux].Cells[0].Value.ToString());
                this.operario.Puesto = (EPuestoDeTrabajo)Enum.Parse(typeof(EPuestoDeTrabajo), this.dgvOperariosAlternadores.Rows[aux].Cells[1].Value.ToString());
                this.operario.ID = Convert.ToInt32(dgvOperariosAlternadores.Rows[aux].Cells[2].Value.ToString());
                this.operario.Nombre = dgvOperariosAlternadores.Rows[aux].Cells[3].Value.ToString();
                this.operario.Apellido = dgvOperariosAlternadores.Rows[aux].Cells[4].Value.ToString();
                this.operario.DNI = Convert.ToInt32(dgvOperariosAlternadores.Rows[aux].Cells[5].Value.ToString());
                return true;
            }
            return false;
        }
        #endregion

    }
}
