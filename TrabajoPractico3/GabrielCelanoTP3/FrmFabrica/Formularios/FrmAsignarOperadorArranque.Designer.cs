
namespace FrmFabrica
{
    partial class FrmAsignarOperadorArranque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignarOperadorArranque));
            this.btnAsignarOperador = new System.Windows.Forms.Button();
            this.dgvOperariosArranques = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperariosArranques)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsignarOperador
            // 
            this.btnAsignarOperador.Location = new System.Drawing.Point(12, 221);
            this.btnAsignarOperador.Name = "btnAsignarOperador";
            this.btnAsignarOperador.Size = new System.Drawing.Size(156, 39);
            this.btnAsignarOperador.TabIndex = 1;
            this.btnAsignarOperador.Text = "Asignar Operador";
            this.btnAsignarOperador.UseVisualStyleBackColor = true;
            this.btnAsignarOperador.Click += new System.EventHandler(this.btnAsignarOperador_Click);
            // 
            // dgvOperariosArranques
            // 
            this.dgvOperariosArranques.AllowUserToAddRows = false;
            this.dgvOperariosArranques.AllowUserToDeleteRows = false;
            this.dgvOperariosArranques.AllowUserToOrderColumns = true;
            this.dgvOperariosArranques.Location = new System.Drawing.Point(12, 13);
            this.dgvOperariosArranques.Name = "dgvOperariosArranques";
            this.dgvOperariosArranques.ReadOnly = true;
            this.dgvOperariosArranques.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvOperariosArranques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperariosArranques.Size = new System.Drawing.Size(510, 187);
            this.dgvOperariosArranques.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(366, 221);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(156, 39);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmAsignarOperadorArranque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(534, 272);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvOperariosArranques);
            this.Controls.Add(this.btnAsignarOperador);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAsignarOperadorArranque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asignar Operador";
            this.Load += new System.EventHandler(this.FrmAsignarOperadorArranque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperariosArranques)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAsignarOperador;
        private System.Windows.Forms.DataGridView dgvOperariosArranques;
        private System.Windows.Forms.Button btnSalir;
    }
}