
namespace FrmFabrica
{
    partial class FrmFabricacionArranque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFabricacionArranque));
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnInstrucciones = new System.Windows.Forms.Button();
            this.btnColocarCarcasa = new System.Windows.Forms.Button();
            this.btnColocarPlaqueta = new System.Windows.Forms.Button();
            this.btnColocarHorquilla = new System.Windows.Forms.Button();
            this.btnColocarBendix = new System.Windows.Forms.Button();
            this.btnRectificarBobina = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.btnFinalizarFabricacion = new System.Windows.Forms.Button();
            this.btnAsignarOperador = new System.Windows.Forms.Button();
            this.rtbInformacion = new System.Windows.Forms.RichTextBox();
            this.btnColocarAutomatico = new System.Windows.Forms.Button();
            this.lblOperarioAsignado = new System.Windows.Forms.Label();
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
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(35, 403);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(195, 38);
            this.btnVerificar.TabIndex = 21;
            this.btnVerificar.Text = "Verificar Arranque";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnInstrucciones
            // 
            this.btnInstrucciones.Location = new System.Drawing.Point(501, 447);
            this.btnInstrucciones.Name = "btnInstrucciones";
            this.btnInstrucciones.Size = new System.Drawing.Size(195, 38);
            this.btnInstrucciones.TabIndex = 20;
            this.btnInstrucciones.Text = "Instrucciones para la fabricacion";
            this.btnInstrucciones.UseVisualStyleBackColor = true;
            this.btnInstrucciones.Click += new System.EventHandler(this.btnInstrucciones_Click);
            // 
            // btnColocarCarcasa
            // 
            this.btnColocarCarcasa.Location = new System.Drawing.Point(34, 293);
            this.btnColocarCarcasa.Name = "btnColocarCarcasa";
            this.btnColocarCarcasa.Size = new System.Drawing.Size(195, 38);
            this.btnColocarCarcasa.TabIndex = 19;
            this.btnColocarCarcasa.Text = "Colocar Carcasa";
            this.btnColocarCarcasa.UseVisualStyleBackColor = true;
            this.btnColocarCarcasa.Click += new System.EventHandler(this.btnColocarCarcasa_Click);
            // 
            // btnColocarPlaqueta
            // 
            this.btnColocarPlaqueta.Location = new System.Drawing.Point(34, 249);
            this.btnColocarPlaqueta.Name = "btnColocarPlaqueta";
            this.btnColocarPlaqueta.Size = new System.Drawing.Size(195, 38);
            this.btnColocarPlaqueta.TabIndex = 18;
            this.btnColocarPlaqueta.Text = "Colocar Plaqueta";
            this.btnColocarPlaqueta.UseVisualStyleBackColor = true;
            this.btnColocarPlaqueta.Click += new System.EventHandler(this.btnColocarPlaqueta_Click);
            // 
            // btnColocarHorquilla
            // 
            this.btnColocarHorquilla.Location = new System.Drawing.Point(34, 205);
            this.btnColocarHorquilla.Name = "btnColocarHorquilla";
            this.btnColocarHorquilla.Size = new System.Drawing.Size(195, 38);
            this.btnColocarHorquilla.TabIndex = 17;
            this.btnColocarHorquilla.Text = "Colocar Horquilla";
            this.btnColocarHorquilla.UseVisualStyleBackColor = true;
            this.btnColocarHorquilla.Click += new System.EventHandler(this.btnColocarHorquilla_Click);
            // 
            // btnColocarBendix
            // 
            this.btnColocarBendix.Location = new System.Drawing.Point(34, 161);
            this.btnColocarBendix.Name = "btnColocarBendix";
            this.btnColocarBendix.Size = new System.Drawing.Size(195, 38);
            this.btnColocarBendix.TabIndex = 16;
            this.btnColocarBendix.Text = "Colocar Bendix";
            this.btnColocarBendix.UseVisualStyleBackColor = true;
            this.btnColocarBendix.Click += new System.EventHandler(this.btnColocarBendix_Click);
            // 
            // btnRectificarBobina
            // 
            this.btnRectificarBobina.Location = new System.Drawing.Point(34, 117);
            this.btnRectificarBobina.Name = "btnRectificarBobina";
            this.btnRectificarBobina.Size = new System.Drawing.Size(195, 38);
            this.btnRectificarBobina.TabIndex = 15;
            this.btnRectificarBobina.Text = "Rectificar Bobina";
            this.btnRectificarBobina.UseVisualStyleBackColor = true;
            this.btnRectificarBobina.Click += new System.EventHandler(this.btnRectificarBobina_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(97, 66);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(132, 21);
            this.cmbMarca.TabIndex = 22;
            // 
            // btnFinalizarFabricacion
            // 
            this.btnFinalizarFabricacion.Location = new System.Drawing.Point(35, 447);
            this.btnFinalizarFabricacion.Name = "btnFinalizarFabricacion";
            this.btnFinalizarFabricacion.Size = new System.Drawing.Size(195, 38);
            this.btnFinalizarFabricacion.TabIndex = 24;
            this.btnFinalizarFabricacion.Text = "Finalizar Fabricacion";
            this.btnFinalizarFabricacion.UseVisualStyleBackColor = true;
            this.btnFinalizarFabricacion.Click += new System.EventHandler(this.btnFinalizarFabricacion_Click);
            // 
            // btnAsignarOperador
            // 
            this.btnAsignarOperador.Location = new System.Drawing.Point(501, 16);
            this.btnAsignarOperador.Name = "btnAsignarOperador";
            this.btnAsignarOperador.Size = new System.Drawing.Size(191, 39);
            this.btnAsignarOperador.TabIndex = 25;
            this.btnAsignarOperador.Text = "Asignar Operador";
            this.btnAsignarOperador.UseVisualStyleBackColor = true;
            this.btnAsignarOperador.Click += new System.EventHandler(this.btnAsignarOperador_Click);
            // 
            // rtbInformacion
            // 
            this.rtbInformacion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInformacion.Location = new System.Drawing.Point(439, 65);
            this.rtbInformacion.Name = "rtbInformacion";
            this.rtbInformacion.Size = new System.Drawing.Size(305, 358);
            this.rtbInformacion.TabIndex = 26;
            this.rtbInformacion.Text = "";
            // 
            // btnColocarAutomatico
            // 
            this.btnColocarAutomatico.Location = new System.Drawing.Point(37, 337);
            this.btnColocarAutomatico.Name = "btnColocarAutomatico";
            this.btnColocarAutomatico.Size = new System.Drawing.Size(195, 38);
            this.btnColocarAutomatico.TabIndex = 27;
            this.btnColocarAutomatico.Text = "Colocar Automatico";
            this.btnColocarAutomatico.UseVisualStyleBackColor = true;
            this.btnColocarAutomatico.Click += new System.EventHandler(this.btnColocarAutomatico_Click);
            // 
            // lblOperarioAsignado
            // 
            this.lblOperarioAsignado.AutoSize = true;
            this.lblOperarioAsignado.BackColor = System.Drawing.Color.Transparent;
            this.lblOperarioAsignado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperarioAsignado.Location = new System.Drawing.Point(31, 14);
            this.lblOperarioAsignado.Name = "lblOperarioAsignado";
            this.lblOperarioAsignado.Size = new System.Drawing.Size(157, 19);
            this.lblOperarioAsignado.TabIndex = 28;
            this.lblOperarioAsignado.Text = "Operario Asignado:";
            // 
            // lblNombreOperador
            // 
            this.lblNombreOperador.AutoSize = true;
            this.lblNombreOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreOperador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreOperador.Location = new System.Drawing.Point(204, 16);
            this.lblNombreOperador.Name = "lblNombreOperador";
            this.lblNombreOperador.Size = new System.Drawing.Size(0, 16);
            this.lblNombreOperador.TabIndex = 29;
            // 
            // FrmFabricacionArranque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(770, 519);
            this.Controls.Add(this.lblNombreOperador);
            this.Controls.Add(this.lblOperarioAsignado);
            this.Controls.Add(this.btnColocarAutomatico);
            this.Controls.Add(this.rtbInformacion);
            this.Controls.Add(this.btnAsignarOperador);
            this.Controls.Add(this.btnFinalizarFabricacion);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnInstrucciones);
            this.Controls.Add(this.btnColocarCarcasa);
            this.Controls.Add(this.btnColocarPlaqueta);
            this.Controls.Add(this.btnColocarHorquilla);
            this.Controls.Add(this.btnColocarBendix);
            this.Controls.Add(this.btnRectificarBobina);
            this.Controls.Add(this.lblMarca);
            this.MaximizeBox = false;
            this.Name = "FrmFabricacionArranque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fabricacion Arranque";
            this.Load += new System.EventHandler(this.FrmFabricacionArranque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnInstrucciones;
        private System.Windows.Forms.Button btnColocarCarcasa;
        private System.Windows.Forms.Button btnColocarPlaqueta;
        private System.Windows.Forms.Button btnColocarHorquilla;
        private System.Windows.Forms.Button btnColocarBendix;
        private System.Windows.Forms.Button btnRectificarBobina;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button btnFinalizarFabricacion;
        private System.Windows.Forms.Button btnAsignarOperador;
        private System.Windows.Forms.RichTextBox rtbInformacion;
        private System.Windows.Forms.Button btnColocarAutomatico;
        private System.Windows.Forms.Label lblOperarioAsignado;
        private System.Windows.Forms.Label lblNombreOperador;
    }
}