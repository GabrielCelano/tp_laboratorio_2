using Archivos;
using ClasesInstanciables.Clases;
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
    public partial class FrmPrincipal : Form
    {
        #region Atributos
        private Fabrica fabrica;
        private Fabricacion fabricacion;
        private OperarioDAO<Operario> operarioDao;
        private AlternadorDAO<Alternador> alternadorDao;
        private ArranqueDAO<Arranque> arranqueDao;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor sin parametros que instancia los atributos fabrica, fabricacion, operarioDao, alternadorDao y arranqueDao
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
            this.fabrica = new Fabrica();
            this.fabricacion = new Fabricacion();
            this.operarioDao = new OperarioDAO<Operario>();
            this.alternadorDao = new AlternadorDAO<Alternador>();
            this.arranqueDao = new ArranqueDAO<Arranque>();
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Llama al formulario FrmAltaOperario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaOperario_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAltaOperario frmAltaOperario = new FrmAltaOperario(this.fabrica);
                frmAltaOperario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Llama al formulario FrmAlternadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFabricarAlternador_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.fabrica.VerificarListaOperadores())
                {
                    if (Application.OpenForms["FrmAlternadores"] != null)
                    {
                        Application.OpenForms["FrmAlternadores"].Activate();
                    }
                    else
                    {
                        FrmAlternadores frmAlternadores = new FrmAlternadores(this.fabrica, this.fabricacion);
                        frmAlternadores.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Llama al formulario FrmFabricarArranques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFabricarArranques_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.fabrica.VerificarListaOperadores())
                {
                    if (Application.OpenForms["FrmArranques"] != null)
                    {
                        Application.OpenForms["FrmArranques"].Activate();
                    }
                    else
                    {
                        FrmArranques frmArranques = new FrmArranques(this.fabrica, this.fabricacion);
                        frmArranques.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Guarda listas en un archivo XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXmlGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Xml<Fabrica> xmlOperadores = new Xml<Fabrica>();
                xmlOperadores.Guardar("operadores.xml", this.fabrica);
                Xml<Fabricacion> xmlFabricaciones = new Xml<Fabricacion>();
                xmlFabricaciones.Guardar("fabricaciones.xml", this.fabricacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Lee los archivos XML del escritorio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXmlLeer_Click(object sender, EventArgs e)
        {
            try
            {
                Xml<Fabrica> xmlFabrica = new Xml<Fabrica>();
                this.fabrica = xmlFabrica.Leer("operadores.xml");
                Xml<Fabricacion> xmlFabricacion = new Xml<Fabricacion>();
                this.fabricacion = xmlFabricacion.Leer("fabricaciones.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Guarda un archivo de tipo txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarTxt_Click(object sender, EventArgs e)
        {
            try
            {
                rtbInformacion.Text = this.fabrica.JornadaLaboral();
                rtbInformacion.Text += this.fabricacion.ListaDeFabricaciones();
                Texto txt = new Texto();
                txt.Guardar("jornada.log", rtbInformacion.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n\n" + ex.InnerException.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Lee un archivo de tipo txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeerTxt_Click(object sender, EventArgs e)
        {
            try
            {
                Texto txt = new Texto();
                this.rtbInformacion.Text = txt.Leer("jornada.log");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n\n" + ex.InnerException.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Devuelve los datos de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeerBD_Click(object sender, EventArgs e)
        {
            try
            {
                this.fabrica = new Fabrica();
                this.fabrica = operarioDao.Leer(this.fabrica);
                this.fabricacion = new Fabricacion();
                this.fabricacion = alternadorDao.Leer(this.fabricacion);
                this.fabricacion = arranqueDao.Leer(this.fabricacion);
                if (this.fabrica.Operarios.Count > 0)
                {
                    Xml<Fabrica> xmlFabrica = new Xml<Fabrica>();
                    xmlFabrica.Guardar("operadores.xml", this.fabrica);
                    this.btnLeerBD.Enabled = false;
                }
                if (this.fabricacion.Arranques.Count > 0 || this.fabricacion.Alternadores.Count > 0)
                {
                    Xml<Fabricacion> xmlFabricacion = new Xml<Fabricacion>();
                    xmlFabricacion.Guardar("fabricaciones.xml", this.fabricacion);
                    this.btnLeerBD.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Base de datos vacia!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n\n" + ex.InnerException.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Muestra la lista de operarios en el RichTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListaDeOperarios_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.fabrica.VerificarListaOperadores())
                {
                    this.rtbInformacion.Text = fabrica.MostrarOperarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Muestra la lista de fabricaciones en el RichTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListaDeFabricaciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.fabricacion.VerificarListaDeFabricaciones())
                {
                    this.rtbInformacion.Text = this.fabricacion.ListaDeFabricaciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Muestra las instrucciones en el RichTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInstrucciones_Click(object sender, EventArgs e)
        {
            this.rtbInformacion.Text = string.Format(
                "********Consejos para el manejo de la fabrica********" +
                "\n\n1. Para poder empezar a fabricar debe dar de alta los operarios o levantar los operarios desde la base de datos o archivo xml(en el caso de que estos ya contengan o tengan cargados operarios)." +
                "\n\n2. Una vez que la fabrica tenga operarios activos puede comenzar a fabricar(en la seccion fabricaciones).");
        }
        #endregion

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources.alternadorarranque1;
        }
    }
}
