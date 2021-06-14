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
    public partial class FrmPrincipal : Form
    {
        #region Atributos
        private Fabrica fabrica;
        private JornadaLaboral jornada;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor del Frm que instancia una Fabrica y una JornadaLaboral
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
            this.fabrica = new Fabrica();
            this.jornada = new JornadaLaboral();
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Evento que llama a FrmContratarOperario de forma modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignarOperarios_Click(object sender, EventArgs e)
        {
            FrmContratarOperario frmAsignarOperarios = new FrmContratarOperario(this.fabrica);
            frmAsignarOperarios.ShowDialog();
        }

        /// <summary>
        /// Evento que llama a FrmFabricarAlternador de forma modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFabricarAlternador_Click(object sender, EventArgs e)
        {
            FrmFabricacionAlternador frmFabricacionAlternador = new FrmFabricacionAlternador(this.fabrica);
            frmFabricacionAlternador.ShowDialog();
        }

        /// <summary>
        /// Evento que llama a FrmFabricacionArranque de forma modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFabricarArranque_Click(object sender, EventArgs e)
        {
            FrmFabricacionArranque frmFabricacionArranque = new FrmFabricacionArranque(this.fabrica);
            frmFabricacionArranque.ShowDialog();
        }

        /// <summary>
        /// Evento que llama a FrmInformacion de forma modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            FrmInformacion frmInformacion = new FrmInformacion(this.fabrica);
            frmInformacion.ShowDialog();
        }

        /// <summary>
        /// Evento que llama a FrmArchivos de forma modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArchivos_Click(object sender, EventArgs e)
        {
            FrmArchivos frmArchivos = new FrmArchivos(this.fabrica, this.jornada);
            frmArchivos.ShowDialog();
        }

        /// <summary>
        /// Evendo Load que establece un texto al RichTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.rtbInfoTp.Text = this.MostrarInfoTp();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra la funcion de los botones del formulario
        /// </summary>
        /// <returns></returns>
        public string MostrarInfoTp()
        {
            StringBuilder infoAux = new StringBuilder();
            infoAux.AppendLine("*Fabrica de alternadores y arranques para autos*\n" +
                "Boton contratar empleados: asignas operadores para la fabrica(esencial para poder fabricar)\n" +
                "Boton fabricar alternador/arranque: te lleva al sector fabricacion\n" +
                "Boton informacion: varias listas sobre la fabrica\n" +
                "Boton archivo: guarda/lee documentacion de la fabrica");
            return infoAux.ToString();
        }
        #endregion
    }
}
