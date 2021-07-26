using Archivos;
using ClasesInstanciables;
using ClasesInstanciables.Clases;
using ClasesInstanciables.Enumerados;
using ClasesInstanciables.Extenciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmFabrica
{
    public partial class FrmArranques : Form
    {
        #region Atributos
        private Fabricacion fabricacion;
        private Fabrica fabrica;
        private Arranque arranque;
        private Operario operario;
        private Thread threadFabricar;
        private Thread threadVerificar;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor que instancia los atributos fabrica y fabricacion
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="fabricacion"></param>
        public FrmArranques(Fabrica fabrica, Fabricacion fabricacion)
        {
            InitializeComponent();
            this.fabricacion = fabricacion;
            this.fabrica = fabrica;
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Evento Load que setea los botones y el DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmArranques_Load(object sender, EventArgs e)
        {
            this.btnFabricar.Enabled = false;
            this.btnVerificar.Enabled = false;
            this.cmbMarca.DataSource = Enum.GetValues(typeof(EMarca));
            this.dgvOperadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOperadores.DataSource = this.fabrica.Operarios;
            this.AjustarColumnas();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources.alternadorarranque2;
        }

        /// <summary>
        /// Evento Click que asigna un operador de la lista 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignarOperador_Click(object sender, EventArgs e)
        {
            int indice;
            indice = this.dgvOperadores.CurrentRow.Index;
            EPuestoDeTrabajo puesto = (EPuestoDeTrabajo)Enum.Parse(typeof(EPuestoDeTrabajo), this.dgvOperadores.Rows[indice].Cells[1].Value.ToString());
            if (puesto == EPuestoDeTrabajo.FabricanteDeArranques)
            {
                int fabricaciones = Convert.ToInt32(dgvOperadores.Rows[indice].Cells[0].Value);
                string nombre = dgvOperadores.Rows[indice].Cells[2].Value.ToString();
                string apellido = dgvOperadores.Rows[indice].Cells[3].Value.ToString();
                int dni = Convert.ToInt32(dgvOperadores.Rows[indice].Cells[4].Value);
                this.operario = new Operario(nombre, apellido, dni, puesto, fabricaciones);
                lblNombreDelOperador.Text = string.Format($"{this.operario.Apellido}, {this.operario.Nombre}");
                this.btnFabricar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccionar un operador del sector arranques!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento Click que fabrica el arranque
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFabricar_Click(object sender, EventArgs e)
        {
            try
            {
                this.cmbMarca.Enabled = false;
                this.btnFabricar.Enabled = false;
                this.btnAsignarOperador.Enabled = false;
                this.arranque = new Arranque();
                arranque.EventoFabricacion += Fabricacion;
                threadFabricar = new Thread(arranque.ComenzarFabricacion);
                threadFabricar.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento Click que verifica el arranque fabricado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                arranque.EventoValidarFabricacion += VerificarArranque;
                threadVerificar = new Thread(arranque.VerificarFabricacion);
                threadVerificar.Start();
                this.btnVerificar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento Closing que cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmArranques_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.CerrarForm())
                this.Close();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que guarda/actualiza la fabricacion en la base de datos y en un archivo xml
        /// Tambien actualiza el estado del operario asignado
        /// </summary>
        /// <param name="fabricacion"></param>
        /// <param name="fabrica"></param>
        /// <param name="opeario"></param>
        /// <param name="arranque"></param>
        /// <returns></returns>
        private bool Archivos(Fabricacion fabricacion, Fabrica fabrica, Operario opeario, Arranque arranque)
        {
            bool aux = false;
            try
            {
                OperarioDAO<Operario> fabricaDao = new OperarioDAO<Operario>();
                ArranqueDAO<Arranque> arranqueDao = new ArranqueDAO<Arranque>();
                Xml<Fabrica> xmlFabrica = new Xml<Fabrica>();
                Xml<Fabricacion> xmlFabricacion = new Xml<Fabricacion>();

                this.fabricacion += this.arranque;

                if (this.fabrica.SumarFabricacion(fabrica, operario))
                {
                    fabricaDao.ActualizarDatos(this.fabrica, this.operario);
                    xmlFabricacion.Guardar("fabricaciones.xml", this.fabricacion);
                    xmlFabrica.Guardar("operadores.xml", this.fabrica);
                    this.ResetForm();
                    if (arranqueDao.Verificar(this.arranque))
                    {
                        arranqueDao.ActualizarDatos(this.fabricacion, this.arranque);
                    }
                    else
                    {
                        arranqueDao.Guardar(this.fabricacion, this.arranque);
                    }
                    aux = true;
                }
                return aux;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return aux;
            }
        }

        /// <summary>
        /// Metodo que resetea el formulario
        /// </summary>
        private void ResetForm()
        {
            this.btnFabricar.Enabled = false;
            this.btnVerificar.Enabled = false;
            this.cmbMarca.Enabled = true;
            this.btnAsignarOperador.Enabled = true;
            this.lblNombreDelOperador.Text = "";
            this.rtbInformacion.Text = "";
        }

        /// <summary>
        /// Metodo que realiza la fabricacion
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="boolean"></param>
        public void Fabricacion(string mensaje, bool boolean)
        {
            if (this.rtbInformacion.InvokeRequired)
            {
                Alternador.Fabricar recall = new Alternador.Fabricar(this.Fabricacion);
                this.Invoke(recall, new object[] { mensaje, boolean });
            }
            else
            {
                EMarca marca;
                if (cmbMarca.SelectedValue.ToString().ConversionEMarca(out marca))
                {
                    this.arranque.Marca = marca;
                    this.arranque.Cantidad = 1;
                    rtbInformacion.Text += mensaje;
                    this.btnVerificar.Enabled = boolean;
                    rtbInformacion.Text += "\nFinalizado.";
                }
            }
        }

        /// <summary>
        /// Metodo que realiza la verificacion
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="boolean"></param>
        public void VerificarArranque(string mensaje, bool boolean)
        {
            try
            {
                if (this.rtbInformacion.InvokeRequired)
                {
                    Alternador.Fabricar recall = new Alternador.Fabricar(this.VerificarArranque);
                    this.Invoke(recall, new object[] { mensaje, boolean });
                }
                else
                {
                    rtbInformacion.Text += mensaje;
                    rtbInformacion.Text += "\nExito.";
                    if (boolean == true && this.Archivos(this.fabricacion, this.fabrica, this.operario, this.arranque))
                    {
                        MessageBox.Show("Fabricacion exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Metodo que ajusta las columnas del DataGridView
        /// </summary>
        private void AjustarColumnas()
        {
            this.dgvOperadores.Columns["DNI"].DisplayIndex = 0;
            this.dgvOperadores.Columns["Apellido"].DisplayIndex = 1;
            this.dgvOperadores.Columns["Nombre"].DisplayIndex = 2;
            this.dgvOperadores.Columns["Puesto"].DisplayIndex = 3;
            this.dgvOperadores.Columns["Fabricaciones"].Visible = false;
        }

        /// <summary>
        /// Metodo que comprueba los hilos, para abortarlos
        /// </summary>
        /// <returns></returns>
        private bool CerrarForm()
        {
            bool aux = false;
            if (!object.ReferenceEquals(threadFabricar, null))
                if (threadFabricar.IsAlive)
                {
                    threadFabricar.Abort();
                    aux = true;
                    if (!object.ReferenceEquals(threadVerificar, null))
                        if (threadVerificar.IsAlive)
                        {
                            threadVerificar.Abort();
                        }
                }
            return aux;
        }
        #endregion
    }
}
