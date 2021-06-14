
namespace FrmFabrica
{
    partial class FrmFabricacionAlternador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFabricacionAlternador));
            this.lblMarca = new System.Windows.Forms.Label();
            this.rtbInformacion = new System.Windows.Forms.RichTextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.btnRectificarRotor = new System.Windows.Forms.Button();
            this.btnColocarColector = new System.Windows.Forms.Button();
            this.btnColocarCarcasa = new System.Windows.Forms.Button();
            this.btnColocarRegulador = new System.Windows.Forms.Button();
            this.btnColocarPolea = new System.Windows.Forms.Button();
            this.btnInstrucciones = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnFinalizarFabricacion = new System.Windows.Forms.Button();
            this.btnAsignarOperador = new System.Windows.Forms.Button();
            this.lblOperadorAsignado = new System.Windows.Forms.Label();
            this.lblNombreOperador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(30, 65);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(61, 19);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // rtbInformacion
            // 
            this.rtbInformacion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInformacion.Location = new System.Drawing.Point(439, 65);
            this.rtbInformacion.Name = "rtbInformacion";
            this.rtbInformacion.Size = new System.Drawing.Size(305, 358);
            this.rtbInformacion.TabIndex = 2;
            this.rtbInformacion.Text = "";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(97, 66);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(132, 21);
            this.cmbMarca.TabIndex = 3;
            // 
            // btnRectificarRotor
            // 
            this.btnRectificarRotor.Location = new System.Drawing.Point(34, 117);
            this.btnRectificarRotor.Name = "btnRectificarRotor";
            this.btnRectificarRotor.Size = new System.Drawing.Size(195, 38);
            this.btnRectificarRotor.TabIndex = 5;
            this.btnRectificarRotor.Text = "Rectificar Rotor";
            this.btnRectificarRotor.UseVisualStyleBackColor = true;
            this.btnRectificarRotor.Click += new System.EventHandler(this.btnRectificarRotor_Click);
            // 
            // btnColocarColector
            // 
            this.btnColocarColector.Location = new System.Drawing.Point(34, 161);
            this.btnColocarColector.Name = "btnColocarColector";
            this.btnColocarColector.Size = new System.Drawing.Size(195, 38);
            this.btnColocarColector.TabIndex = 6;
            this.btnColocarColector.Text = "Colocar Colector";
            this.btnColocarColector.UseVisualStyleBackColor = true;
            this.btnColocarColector.Click += new System.EventHandler(this.btnColocarColector_Click);
            // 
            // btnColocarCarcasa
            // 
            this.btnColocarCarcasa.Location = new System.Drawing.Point(34, 205);
            this.btnColocarCarcasa.Name = "btnColocarCarcasa";
            this.btnColocarCarcasa.Size = new System.Drawing.Size(195, 38);
            this.btnColocarCarcasa.TabIndex = 7;
            this.btnColocarCarcasa.Text = "Colocar Carcasa";
            this.btnColocarCarcasa.UseVisualStyleBackColor = true;
            this.btnColocarCarcasa.Click += new System.EventHandler(this.btnColocarCarcasa_Click);
            // 
            // btnColocarRegulador
            // 
            this.btnColocarRegulador.Location = new System.Drawing.Point(34, 249);
            this.btnColocarRegulador.Name = "btnColocarRegulador";
            this.btnColocarRegulador.Size = new System.Drawing.Size(195, 38);
            this.btnColocarRegulador.TabIndex = 8;
            this.btnColocarRegulador.Text = "Colocar Regulador";
            this.btnColocarRegulador.UseVisualStyleBackColor = true;
            this.btnColocarRegulador.Click += new System.EventHandler(this.btnColocarRegulador_Click);
            // 
            // btnColocarPolea
            // 
            this.btnColocarPolea.Location = new System.Drawing.Point(34, 293);
            this.btnColocarPolea.Name = "btnColocarPolea";
            this.btnColocarPolea.Size = new System.Drawing.Size(195, 38);
            this.btnColocarPolea.TabIndex = 9;
            this.btnColocarPolea.Text = "Colocar Polea";
            this.btnColocarPolea.UseVisualStyleBackColor = true;
            this.btnColocarPolea.Click += new System.EventHandler(this.btnColocarPolea_Click);
            // 
            // btnInstrucciones
            // 
            this.btnInstrucciones.Location = new System.Drawing.Point(501, 447);
            this.btnInstrucciones.Name = "btnInstrucciones";
            this.btnInstrucciones.Size = new System.Drawing.Size(195, 38);
            this.btnInstrucciones.TabIndex = 10;
            this.btnInstrucciones.Text = "Instrucciones para la fabricacion";
            this.btnInstrucciones.UseVisualStyleBackColor = true;
            this.btnInstrucciones.Click += new System.EventHandler(this.btnInstrucciones_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(35, 403);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(195, 38);
            this.btnVerificar.TabIndex = 11;
            this.btnVerificar.Text = "Verificar Alternador";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnFinalizarFabricacion
            // 
            this.btnFinalizarFabricacion.Location = new System.Drawing.Point(35, 447);
            this.btnFinalizarFabricacion.Name = "btnFinalizarFabricacion";
            this.btnFinalizarFabricacion.Size = new System.Drawing.Size(195, 38);
            this.btnFinalizarFabricacion.TabIndex = 12;
            this.btnFinalizarFabricacion.Text = "Finalizar Fabricacion";
            this.btnFinalizarFabricacion.UseVisualStyleBackColor = true;
            this.btnFinalizarFabricacion.Click += new System.EventHandler(this.btnFinalizarFabricacion_Click);
            // 
            // btnAsignarOperador
            // 
            this.btnAsignarOperador.Location = new System.Drawing.Point(501, 16);
            this.btnAsignarOperador.Name = "btnAsignarOperador";
            this.btnAsignarOperador.Size = new System.Drawing.Size(210, 39);
            this.btnAsignarOperador.TabIndex = 13;
            this.btnAsignarOperador.Text = "Asignar Operador";
            this.btnAsignarOperador.UseVisualStyleBackColor = true;
            this.btnAsignarOperador.Click += new System.EventHandler(this.btnAsignarOperador_Click);
            // 
            // lblOperadorAsignado
            // 
            this.lblOperadorAsignado.AutoSize = true;
            this.lblOperadorAsignado.BackColor = System.Drawing.Color.Transparent;
            this.lblOperadorAsignado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperadorAsignado.Location = new System.Drawing.Point(31, 13);
            this.lblOperadorAsignado.Name = "lblOperadorAsignado";
            this.lblOperadorAsignado.Size = new System.Drawing.Size(163, 19);
            this.lblOperadorAsignado.TabIndex = 14;
            this.lblOperadorAsignado.Text = "Operador Asignado:";
            // 
            // lblNombreOperador
            // 
            this.lblNombreOperador.AutoSize = true;
            this.lblNombreOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreOperador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreOperador.Location = new System.Drawing.Point(204, 16);
            this.lblNombreOperador.Name = "lblNombreOperador";
            this.lblNombreOperador.Size = new System.Drawing.Size(0, 16);
            this.lblNombreOperador.TabIndex = 15;
            // 
            // FrmFabricacionAlternador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(770, 519);
            this.Controls.Add(this.lblNombreOperador);
            this.Controls.Add(this.lblOperadorAsignado);
            this.Controls.Add(this.btnAsignarOperador);
            this.Controls.Add(this.btnFinalizarFabricacion);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnInstrucciones);
            this.Controls.Add(this.btnColocarPolea);
            this.Controls.Add(this.btnColocarRegulador);
            this.Controls.Add(this.btnColocarCarcasa);
            this.Controls.Add(this.btnColocarColector);
            this.Controls.Add(this.btnRectificarRotor);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.rtbInformacion);
            this.Controls.Add(this.lblMarca);
            this.MaximizeBox = false;
            this.Name = "FrmFabricacionAlternador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fabricacion Alternador";
            this.Load += new System.EventHandler(this.FrmFabricacionAlternador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.RichTextBox rtbInformacion;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button btnRectificarRotor;
        private System.Windows.Forms.Button btnColocarColector;
        private System.Windows.Forms.Button btnColocarCarcasa;
        private System.Windows.Forms.Button btnColocarRegulador;
        private System.Windows.Forms.Button btnColocarPolea;
        private System.Windows.Forms.Button btnInstrucciones;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnFinalizarFabricacion;
        private System.Windows.Forms.Button btnAsignarOperador;
        private System.Windows.Forms.Label lblOperadorAsignado;
        private System.Windows.Forms.Label lblNombreOperador;
    }
}