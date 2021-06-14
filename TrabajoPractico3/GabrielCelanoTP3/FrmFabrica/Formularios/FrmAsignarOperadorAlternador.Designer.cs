
namespace FrmFabrica
{
    partial class FrmAsignarOperadorAlternador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignarOperadorAlternador));
            this.dgvOperariosAlternadores = new System.Windows.Forms.DataGridView();
            this.btnAsignarOperador = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperariosAlternadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOperariosAlternadores
            // 
            this.dgvOperariosAlternadores.AllowUserToAddRows = false;
            this.dgvOperariosAlternadores.AllowUserToDeleteRows = false;
            this.dgvOperariosAlternadores.AllowUserToOrderColumns = true;
            this.dgvOperariosAlternadores.Location = new System.Drawing.Point(12, 12);
            this.dgvOperariosAlternadores.Name = "dgvOperariosAlternadores";
            this.dgvOperariosAlternadores.ReadOnly = true;
            this.dgvOperariosAlternadores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvOperariosAlternadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperariosAlternadores.Size = new System.Drawing.Size(510, 187);
            this.dgvOperariosAlternadores.TabIndex = 4;
            // 
            // btnAsignarOperador
            // 
            this.btnAsignarOperador.Location = new System.Drawing.Point(12, 216);
            this.btnAsignarOperador.Name = "btnAsignarOperador";
            this.btnAsignarOperador.Size = new System.Drawing.Size(156, 39);
            this.btnAsignarOperador.TabIndex = 4;
            this.btnAsignarOperador.Text = "Asignar Operador";
            this.btnAsignarOperador.UseVisualStyleBackColor = true;
            this.btnAsignarOperador.Click += new System.EventHandler(this.btnAsignarOperador_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(350, 216);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(172, 39);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmAsignarOperadorAlternador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(536, 264);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsignarOperador);
            this.Controls.Add(this.dgvOperariosAlternadores);
            this.MaximizeBox = false;
            this.Name = "FrmAsignarOperadorAlternador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asignar Operador";
            this.Load += new System.EventHandler(this.FrmAsignarOperadorAlternador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperariosAlternadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOperariosAlternadores;
        private System.Windows.Forms.Button btnAsignarOperador;
        private System.Windows.Forms.Button btnSalir;
    }
}