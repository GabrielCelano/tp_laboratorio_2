using Archivos;
using ClasesInstanciables.Clases;
using ClasesInstanciables.Enumerados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmFabrica
{
    public partial class FrmAltaOperario : Form
    {
        #region Atributos
        private Fabrica fabrica;
        private Operario operario;
        private OperarioDAO<Operario> fabricaDao;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor que instancia los atributos fabrica y fabricaDao
        /// </summary>
        /// <param name="fabrica"></param>
        public FrmAltaOperario(Fabrica fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            this.fabricaDao = new OperarioDAO<Operario>();
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Evento Load que deshabilita btnAlta y setea el cmbPuestoDeTrabajo con el enumerado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaOperario_Load(object sender, EventArgs e)
        {
            btnAlta.Enabled = false;
            this.cmbPuestoDeTrabajo.DataSource = Enum.GetValues(typeof(EPuestoDeTrabajo));
        }

        /// <summary>
        /// Evento Click que verifica si el Operario ya se encuentra registrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                EPuestoDeTrabajo puesto;
                Enum.TryParse(cmbPuestoDeTrabajo.SelectedValue.ToString(), out puesto);
                this.operario = new Operario(txtNombre.Text, txtApellido.Text, (int)nudDni.Value, puesto, 0);
                if (!this.fabricaDao.Verificar(this.operario))
                {
                    MessageBox.Show("Operario aprobado!", "Aviso", MessageBoxButtons.OK);
                    btnAlta.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El operario ya se encuentra registrado!", "Aviso", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento Click que asigna al operador ingresado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                this.fabrica += this.operario;
                this.fabricaDao.Guardar(this.fabrica, this.operario);
                Xml<Fabrica> xmlFabrica = new Xml<Fabrica>();
                xmlFabrica.Guardar("operadores.xml", this.fabrica);
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
