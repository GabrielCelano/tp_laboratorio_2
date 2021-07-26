
namespace FrmFabrica
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAltaOperario = new System.Windows.Forms.Button();
            this.btnListaDeOperarios = new System.Windows.Forms.Button();
            this.rtbInformacion = new System.Windows.Forms.RichTextBox();
            this.btnListaDeFabricaciones = new System.Windows.Forms.Button();
            this.btnFabricarAlternador = new System.Windows.Forms.Button();
            this.btnFabricarArranques = new System.Windows.Forms.Button();
            this.btnXmlGuardar = new System.Windows.Forms.Button();
            this.btnXmlLeer = new System.Windows.Forms.Button();
            this.btnGuardarTxt = new System.Windows.Forms.Button();
            this.btnLeerTxt = new System.Windows.Forms.Button();
            this.btnLeerBD = new System.Windows.Forms.Button();
            this.grpAltaOperarios = new System.Windows.Forms.GroupBox();
            this.grpFabricaciones = new System.Windows.Forms.GroupBox();
            this.grpListas = new System.Windows.Forms.GroupBox();
            this.grpArchivos = new System.Windows.Forms.GroupBox();
            this.grpBaseDeDatos = new System.Windows.Forms.GroupBox();
            this.btnInstrucciones = new System.Windows.Forms.Button();
            this.grpAltaOperarios.SuspendLayout();
            this.grpFabricaciones.SuspendLayout();
            this.grpListas.SuspendLayout();
            this.grpArchivos.SuspendLayout();
            this.grpBaseDeDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAltaOperario
            // 
            this.btnAltaOperario.Location = new System.Drawing.Point(17, 19);
            this.btnAltaOperario.Name = "btnAltaOperario";
            this.btnAltaOperario.Size = new System.Drawing.Size(144, 45);
            this.btnAltaOperario.TabIndex = 0;
            this.btnAltaOperario.Text = "Alta";
            this.btnAltaOperario.UseVisualStyleBackColor = true;
            this.btnAltaOperario.Click += new System.EventHandler(this.btnAltaOperario_Click);
            // 
            // btnListaDeOperarios
            // 
            this.btnListaDeOperarios.Location = new System.Drawing.Point(20, 70);
            this.btnListaDeOperarios.Name = "btnListaDeOperarios";
            this.btnListaDeOperarios.Size = new System.Drawing.Size(135, 43);
            this.btnListaDeOperarios.TabIndex = 1;
            this.btnListaDeOperarios.Text = "Operarios";
            this.btnListaDeOperarios.UseVisualStyleBackColor = true;
            this.btnListaDeOperarios.Click += new System.EventHandler(this.btnListaDeOperarios_Click);
            // 
            // rtbInformacion
            // 
            this.rtbInformacion.Location = new System.Drawing.Point(544, 63);
            this.rtbInformacion.Name = "rtbInformacion";
            this.rtbInformacion.ReadOnly = true;
            this.rtbInformacion.Size = new System.Drawing.Size(248, 374);
            this.rtbInformacion.TabIndex = 2;
            this.rtbInformacion.Text = "";
            // 
            // btnListaDeFabricaciones
            // 
            this.btnListaDeFabricaciones.Location = new System.Drawing.Point(20, 19);
            this.btnListaDeFabricaciones.Name = "btnListaDeFabricaciones";
            this.btnListaDeFabricaciones.Size = new System.Drawing.Size(135, 45);
            this.btnListaDeFabricaciones.TabIndex = 3;
            this.btnListaDeFabricaciones.Text = "Fabricaciones";
            this.btnListaDeFabricaciones.UseVisualStyleBackColor = true;
            this.btnListaDeFabricaciones.Click += new System.EventHandler(this.btnListaDeFabricaciones_Click);
            // 
            // btnFabricarAlternador
            // 
            this.btnFabricarAlternador.Location = new System.Drawing.Point(17, 19);
            this.btnFabricarAlternador.Name = "btnFabricarAlternador";
            this.btnFabricarAlternador.Size = new System.Drawing.Size(144, 45);
            this.btnFabricarAlternador.TabIndex = 4;
            this.btnFabricarAlternador.Text = "Alternadores";
            this.btnFabricarAlternador.UseVisualStyleBackColor = true;
            this.btnFabricarAlternador.Click += new System.EventHandler(this.btnFabricarAlternador_Click);
            // 
            // btnFabricarArranques
            // 
            this.btnFabricarArranques.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFabricarArranques.Location = new System.Drawing.Point(17, 83);
            this.btnFabricarArranques.Name = "btnFabricarArranques";
            this.btnFabricarArranques.Size = new System.Drawing.Size(144, 45);
            this.btnFabricarArranques.TabIndex = 5;
            this.btnFabricarArranques.Text = "Arranques";
            this.btnFabricarArranques.UseVisualStyleBackColor = true;
            this.btnFabricarArranques.Click += new System.EventHandler(this.btnFabricarArranques_Click);
            // 
            // btnXmlGuardar
            // 
            this.btnXmlGuardar.Location = new System.Drawing.Point(20, 19);
            this.btnXmlGuardar.Name = "btnXmlGuardar";
            this.btnXmlGuardar.Size = new System.Drawing.Size(135, 45);
            this.btnXmlGuardar.TabIndex = 6;
            this.btnXmlGuardar.Text = "Guardar XML";
            this.btnXmlGuardar.UseVisualStyleBackColor = true;
            this.btnXmlGuardar.Click += new System.EventHandler(this.btnXmlGuardar_Click);
            // 
            // btnXmlLeer
            // 
            this.btnXmlLeer.Location = new System.Drawing.Point(20, 70);
            this.btnXmlLeer.Name = "btnXmlLeer";
            this.btnXmlLeer.Size = new System.Drawing.Size(135, 45);
            this.btnXmlLeer.TabIndex = 7;
            this.btnXmlLeer.Text = "Leer XML";
            this.btnXmlLeer.UseVisualStyleBackColor = true;
            this.btnXmlLeer.Click += new System.EventHandler(this.btnXmlLeer_Click);
            // 
            // btnGuardarTxt
            // 
            this.btnGuardarTxt.Location = new System.Drawing.Point(20, 125);
            this.btnGuardarTxt.Name = "btnGuardarTxt";
            this.btnGuardarTxt.Size = new System.Drawing.Size(135, 45);
            this.btnGuardarTxt.TabIndex = 8;
            this.btnGuardarTxt.Text = "Guardar TXT";
            this.btnGuardarTxt.UseVisualStyleBackColor = true;
            this.btnGuardarTxt.Click += new System.EventHandler(this.btnGuardarTxt_Click);
            // 
            // btnLeerTxt
            // 
            this.btnLeerTxt.Location = new System.Drawing.Point(20, 176);
            this.btnLeerTxt.Name = "btnLeerTxt";
            this.btnLeerTxt.Size = new System.Drawing.Size(135, 45);
            this.btnLeerTxt.TabIndex = 9;
            this.btnLeerTxt.Text = "Leer TXT";
            this.btnLeerTxt.UseVisualStyleBackColor = true;
            this.btnLeerTxt.Click += new System.EventHandler(this.btnLeerTxt_Click);
            // 
            // btnLeerBD
            // 
            this.btnLeerBD.Location = new System.Drawing.Point(17, 29);
            this.btnLeerBD.Name = "btnLeerBD";
            this.btnLeerBD.Size = new System.Drawing.Size(144, 45);
            this.btnLeerBD.TabIndex = 13;
            this.btnLeerBD.Text = "Leer BD";
            this.btnLeerBD.UseVisualStyleBackColor = true;
            this.btnLeerBD.Click += new System.EventHandler(this.btnLeerBD_Click);
            // 
            // grpAltaOperarios
            // 
            this.grpAltaOperarios.BackColor = System.Drawing.Color.Transparent;
            this.grpAltaOperarios.Controls.Add(this.btnAltaOperario);
            this.grpAltaOperarios.Location = new System.Drawing.Point(12, 27);
            this.grpAltaOperarios.Name = "grpAltaOperarios";
            this.grpAltaOperarios.Size = new System.Drawing.Size(176, 76);
            this.grpAltaOperarios.TabIndex = 14;
            this.grpAltaOperarios.TabStop = false;
            this.grpAltaOperarios.Text = "Alta Operarios";
            // 
            // grpFabricaciones
            // 
            this.grpFabricaciones.BackColor = System.Drawing.Color.Transparent;
            this.grpFabricaciones.Controls.Add(this.btnFabricarAlternador);
            this.grpFabricaciones.Controls.Add(this.btnFabricarArranques);
            this.grpFabricaciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpFabricaciones.Location = new System.Drawing.Point(12, 184);
            this.grpFabricaciones.Name = "grpFabricaciones";
            this.grpFabricaciones.Size = new System.Drawing.Size(176, 152);
            this.grpFabricaciones.TabIndex = 15;
            this.grpFabricaciones.TabStop = false;
            this.grpFabricaciones.Text = "Fabricaciones";
            // 
            // grpListas
            // 
            this.grpListas.BackColor = System.Drawing.Color.Transparent;
            this.grpListas.Controls.Add(this.btnListaDeFabricaciones);
            this.grpListas.Controls.Add(this.btnListaDeOperarios);
            this.grpListas.ForeColor = System.Drawing.Color.Black;
            this.grpListas.Location = new System.Drawing.Point(352, 27);
            this.grpListas.Name = "grpListas";
            this.grpListas.Size = new System.Drawing.Size(171, 128);
            this.grpListas.TabIndex = 16;
            this.grpListas.TabStop = false;
            this.grpListas.Text = "Listas";
            // 
            // grpArchivos
            // 
            this.grpArchivos.BackColor = System.Drawing.Color.Transparent;
            this.grpArchivos.Controls.Add(this.btnXmlGuardar);
            this.grpArchivos.Controls.Add(this.btnXmlLeer);
            this.grpArchivos.Controls.Add(this.btnGuardarTxt);
            this.grpArchivos.Controls.Add(this.btnLeerTxt);
            this.grpArchivos.Location = new System.Drawing.Point(352, 221);
            this.grpArchivos.Name = "grpArchivos";
            this.grpArchivos.Size = new System.Drawing.Size(171, 230);
            this.grpArchivos.TabIndex = 17;
            this.grpArchivos.TabStop = false;
            this.grpArchivos.Text = "Archivos";
            // 
            // grpBaseDeDatos
            // 
            this.grpBaseDeDatos.BackColor = System.Drawing.Color.Transparent;
            this.grpBaseDeDatos.Controls.Add(this.btnLeerBD);
            this.grpBaseDeDatos.Location = new System.Drawing.Point(12, 355);
            this.grpBaseDeDatos.Name = "grpBaseDeDatos";
            this.grpBaseDeDatos.Size = new System.Drawing.Size(176, 96);
            this.grpBaseDeDatos.TabIndex = 18;
            this.grpBaseDeDatos.TabStop = false;
            this.grpBaseDeDatos.Text = "Base de datos";
            // 
            // btnInstrucciones
            // 
            this.btnInstrucciones.Location = new System.Drawing.Point(620, 12);
            this.btnInstrucciones.Name = "btnInstrucciones";
            this.btnInstrucciones.Size = new System.Drawing.Size(102, 45);
            this.btnInstrucciones.TabIndex = 1;
            this.btnInstrucciones.Text = "Instrucciones";
            this.btnInstrucciones.UseVisualStyleBackColor = true;
            this.btnInstrucciones.Click += new System.EventHandler(this.btnInstrucciones_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 463);
            this.Controls.Add(this.btnInstrucciones);
            this.Controls.Add(this.grpBaseDeDatos);
            this.Controls.Add(this.grpArchivos);
            this.Controls.Add(this.grpListas);
            this.Controls.Add(this.grpFabricaciones);
            this.Controls.Add(this.grpAltaOperarios);
            this.Controls.Add(this.rtbInformacion);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.grpAltaOperarios.ResumeLayout(false);
            this.grpFabricaciones.ResumeLayout(false);
            this.grpListas.ResumeLayout(false);
            this.grpArchivos.ResumeLayout(false);
            this.grpBaseDeDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaOperario;
        private System.Windows.Forms.Button btnListaDeOperarios;
        private System.Windows.Forms.RichTextBox rtbInformacion;
        private System.Windows.Forms.Button btnListaDeFabricaciones;
        private System.Windows.Forms.Button btnFabricarAlternador;
        private System.Windows.Forms.Button btnFabricarArranques;
        private System.Windows.Forms.Button btnXmlGuardar;
        private System.Windows.Forms.Button btnXmlLeer;
        private System.Windows.Forms.Button btnGuardarTxt;
        private System.Windows.Forms.Button btnLeerTxt;
        private System.Windows.Forms.Button btnLeerBD;
        private System.Windows.Forms.GroupBox grpAltaOperarios;
        private System.Windows.Forms.GroupBox grpFabricaciones;
        private System.Windows.Forms.GroupBox grpListas;
        private System.Windows.Forms.GroupBox grpArchivos;
        private System.Windows.Forms.GroupBox grpBaseDeDatos;
        private System.Windows.Forms.Button btnInstrucciones;
    }
}

