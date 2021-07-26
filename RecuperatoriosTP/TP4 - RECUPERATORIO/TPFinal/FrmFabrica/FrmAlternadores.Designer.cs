
namespace FrmFabrica
{
    partial class FrmAlternadores
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
            this.dgvOperadores = new System.Windows.Forms.DataGridView();
            this.btnAsignarOperador = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnFabricar = new System.Windows.Forms.Button();
            this.rtbInformacion = new System.Windows.Forms.RichTextBox();
            this.lblOperadorAsignado = new System.Windows.Forms.Label();
            this.lblNombreDelOperador = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.rtbInstrucciones = new System.Windows.Forms.RichTextBox();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOperadores
            // 
            this.dgvOperadores.AllowUserToAddRows = false;
            this.dgvOperadores.AllowUserToDeleteRows = false;
            this.dgvOperadores.AllowUserToResizeColumns = false;
            this.dgvOperadores.AllowUserToResizeRows = false;
            this.dgvOperadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperadores.Location = new System.Drawing.Point(12, 81);
            this.dgvOperadores.MultiSelect = false;
            this.dgvOperadores.Name = "dgvOperadores";
            this.dgvOperadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperadores.Size = new System.Drawing.Size(350, 204);
            this.dgvOperadores.TabIndex = 0;
            // 
            // btnAsignarOperador
            // 
            this.btnAsignarOperador.Location = new System.Drawing.Point(12, 6);
            this.btnAsignarOperador.Name = "btnAsignarOperador";
            this.btnAsignarOperador.Size = new System.Drawing.Size(113, 45);
            this.btnAsignarOperador.TabIndex = 1;
            this.btnAsignarOperador.Text = "Asignar Operador";
            this.btnAsignarOperador.UseVisualStyleBackColor = true;
            this.btnAsignarOperador.Click += new System.EventHandler(this.btnAsignarOperador_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(453, 10);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(90, 21);
            this.cmbMarca.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(376, 9);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(61, 19);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // btnFabricar
            // 
            this.btnFabricar.Location = new System.Drawing.Point(380, 244);
            this.btnFabricar.Name = "btnFabricar";
            this.btnFabricar.Size = new System.Drawing.Size(122, 43);
            this.btnFabricar.TabIndex = 4;
            this.btnFabricar.Text = "Fabricar Alternador";
            this.btnFabricar.UseVisualStyleBackColor = true;
            this.btnFabricar.Click += new System.EventHandler(this.btnFabricar_Click);
            // 
            // rtbInformacion
            // 
            this.rtbInformacion.Location = new System.Drawing.Point(380, 37);
            this.rtbInformacion.Name = "rtbInformacion";
            this.rtbInformacion.ReadOnly = true;
            this.rtbInformacion.Size = new System.Drawing.Size(350, 201);
            this.rtbInformacion.TabIndex = 6;
            this.rtbInformacion.Text = "";
            // 
            // lblOperadorAsignado
            // 
            this.lblOperadorAsignado.AutoSize = true;
            this.lblOperadorAsignado.BackColor = System.Drawing.Color.Transparent;
            this.lblOperadorAsignado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperadorAsignado.Location = new System.Drawing.Point(146, 6);
            this.lblOperadorAsignado.Name = "lblOperadorAsignado";
            this.lblOperadorAsignado.Size = new System.Drawing.Size(87, 19);
            this.lblOperadorAsignado.TabIndex = 7;
            this.lblOperadorAsignado.Text = "Operador:";
            // 
            // lblNombreDelOperador
            // 
            this.lblNombreDelOperador.AutoSize = true;
            this.lblNombreDelOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreDelOperador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDelOperador.Location = new System.Drawing.Point(172, 32);
            this.lblNombreDelOperador.Name = "lblNombreDelOperador";
            this.lblNombreDelOperador.Size = new System.Drawing.Size(0, 19);
            this.lblNombreDelOperador.TabIndex = 8;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(608, 242);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(122, 43);
            this.btnVerificar.TabIndex = 9;
            this.btnVerificar.Text = "Verificar Fabricacion";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // rtbInstrucciones
            // 
            this.rtbInstrucciones.Location = new System.Drawing.Point(747, 39);
            this.rtbInstrucciones.Name = "rtbInstrucciones";
            this.rtbInstrucciones.ReadOnly = true;
            this.rtbInstrucciones.Size = new System.Drawing.Size(223, 246);
            this.rtbInstrucciones.TabIndex = 22;
            this.rtbInstrucciones.Text = "1. Asignar un operador del sector FabricanteAlternadores\n2. Asignar una marca\n3. " +
    "Fabrique el alternador\n4. Verifique la fabricacion\n5. Repita la misma secuencia " +
    "o cierre la ventana";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.BackColor = System.Drawing.Color.Transparent;
            this.lblInstrucciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.Location = new System.Drawing.Point(743, 9);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(119, 19);
            this.lblInstrucciones.TabIndex = 23;
            this.lblInstrucciones.Text = "Instrucciones:";
            // 
            // FrmAlternadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 297);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.rtbInstrucciones);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblNombreDelOperador);
            this.Controls.Add(this.lblOperadorAsignado);
            this.Controls.Add(this.rtbInformacion);
            this.Controls.Add(this.btnFabricar);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.btnAsignarOperador);
            this.Controls.Add(this.dgvOperadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAlternadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabricacion de alternadores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAlternadores_FormClosing);
            this.Load += new System.EventHandler(this.FrmAlternadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOperadores;
        private System.Windows.Forms.Button btnAsignarOperador;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnFabricar;
        private System.Windows.Forms.RichTextBox rtbInformacion;
        private System.Windows.Forms.Label lblOperadorAsignado;
        private System.Windows.Forms.Label lblNombreDelOperador;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.RichTextBox rtbInstrucciones;
        private System.Windows.Forms.Label lblInstrucciones;
    }
}