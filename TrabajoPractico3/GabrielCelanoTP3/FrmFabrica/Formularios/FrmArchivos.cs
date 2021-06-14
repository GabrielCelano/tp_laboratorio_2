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
    public partial class FrmArchivos : Form
    {
        #region Atributo
        private Fabrica fabrica;
        private JornadaLaboral jornada;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor del formulario con parametros que instancia el atributo fabrica y jornada
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="jornada"></param>
        public FrmArchivos(Fabrica fabrica, JornadaLaboral jornada)
        {
            this.fabrica = fabrica;
            this.jornada = jornada;
            InitializeComponent();
        }
        #endregion

        #region Evento
        /// <summary>
        /// Evento que guarda la jornada en un archivo txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarJornada_Click(object sender, EventArgs e)
        {
            try
            {
                if (JornadaLaboral.Guardar(this.fabrica, this.jornada))
                {
                    MessageBox.Show("El archivo se guardo correctamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento que lee un archivo txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeerJornada_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbListaArchivos.Text = JornadaLaboral.Leer(this.jornada);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento que serializa las listas de la fabrica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarFabrica_Click(object sender, EventArgs e)
        {
            try
            {
                if (Fabrica.Guardar(this.fabrica))
                {
                    MessageBox.Show("El archivo se guardo correctamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento que lee la serializacion previamente hecha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarFabrica_Click(object sender, EventArgs e)
        {
            try
            {
                this.fabrica = Fabrica.Leer(this.fabrica);
                this.rtbListaArchivos.Text = this.fabrica.DatosDeLaFabrica();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
