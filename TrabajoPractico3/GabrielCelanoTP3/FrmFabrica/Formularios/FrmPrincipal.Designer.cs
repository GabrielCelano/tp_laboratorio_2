
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnContratarEmpleados = new System.Windows.Forms.Button();
            this.btnFabricarAlternador = new System.Windows.Forms.Button();
            this.btnFabricarArranque = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.grpContratarEmpleados = new System.Windows.Forms.GroupBox();
            this.grpFabricar = new System.Windows.Forms.GroupBox();
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.btnArchivos = new System.Windows.Forms.Button();
            this.grpArchivos = new System.Windows.Forms.GroupBox();
            this.rtbInfoTp = new System.Windows.Forms.RichTextBox();
            this.grpContratarEmpleados.SuspendLayout();
            this.grpFabricar.SuspendLayout();
            this.grpInformacion.SuspendLayout();
            this.grpArchivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContratarEmpleados
            // 
            this.btnContratarEmpleados.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContratarEmpleados.Location = new System.Drawing.Point(12, 29);
            this.btnContratarEmpleados.Name = "btnContratarEmpleados";
            this.btnContratarEmpleados.Size = new System.Drawing.Size(182, 46);
            this.btnContratarEmpleados.TabIndex = 1;
            this.btnContratarEmpleados.Text = "Contratar Empleados";
            this.btnContratarEmpleados.UseVisualStyleBackColor = true;
            this.btnContratarEmpleados.Click += new System.EventHandler(this.btnAsignarOperarios_Click);
            // 
            // btnFabricarAlternador
            // 
            this.btnFabricarAlternador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFabricarAlternador.Location = new System.Drawing.Point(18, 29);
            this.btnFabricarAlternador.Name = "btnFabricarAlternador";
            this.btnFabricarAlternador.Size = new System.Drawing.Size(182, 42);
            this.btnFabricarAlternador.TabIndex = 3;
            this.btnFabricarAlternador.Text = "Fabricar Alternador";
            this.btnFabricarAlternador.UseVisualStyleBackColor = true;
            this.btnFabricarAlternador.Click += new System.EventHandler(this.btnFabricarAlternador_Click);
            // 
            // btnFabricarArranque
            // 
            this.btnFabricarArranque.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFabricarArranque.Location = new System.Drawing.Point(18, 86);
            this.btnFabricarArranque.Name = "btnFabricarArranque";
            this.btnFabricarArranque.Size = new System.Drawing.Size(182, 41);
            this.btnFabricarArranque.TabIndex = 5;
            this.btnFabricarArranque.Text = "Fabricar Arranque";
            this.btnFabricarArranque.UseVisualStyleBackColor = true;
            this.btnFabricarArranque.Click += new System.EventHandler(this.btnFabricarArranque_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.Location = new System.Drawing.Point(6, 37);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(182, 41);
            this.btnInformacion.TabIndex = 12;
            this.btnInformacion.Text = "Informacion";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // grpContratarEmpleados
            // 
            this.grpContratarEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.grpContratarEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpContratarEmpleados.Controls.Add(this.btnContratarEmpleados);
            this.grpContratarEmpleados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContratarEmpleados.ForeColor = System.Drawing.Color.Black;
            this.grpContratarEmpleados.Location = new System.Drawing.Point(28, 12);
            this.grpContratarEmpleados.Name = "grpContratarEmpleados";
            this.grpContratarEmpleados.Size = new System.Drawing.Size(200, 100);
            this.grpContratarEmpleados.TabIndex = 13;
            this.grpContratarEmpleados.TabStop = false;
            this.grpContratarEmpleados.Text = "Contratar:";
            // 
            // grpFabricar
            // 
            this.grpFabricar.BackColor = System.Drawing.Color.Transparent;
            this.grpFabricar.Controls.Add(this.btnFabricarAlternador);
            this.grpFabricar.Controls.Add(this.btnFabricarArranque);
            this.grpFabricar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFabricar.Location = new System.Drawing.Point(28, 128);
            this.grpFabricar.Name = "grpFabricar";
            this.grpFabricar.Size = new System.Drawing.Size(218, 142);
            this.grpFabricar.TabIndex = 14;
            this.grpFabricar.TabStop = false;
            this.grpFabricar.Text = "Fabricar:";
            // 
            // grpInformacion
            // 
            this.grpInformacion.BackColor = System.Drawing.Color.Transparent;
            this.grpInformacion.Controls.Add(this.btnInformacion);
            this.grpInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformacion.Location = new System.Drawing.Point(28, 285);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(200, 100);
            this.grpInformacion.TabIndex = 15;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Informacion:";
            // 
            // btnArchivos
            // 
            this.btnArchivos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivos.Location = new System.Drawing.Point(16, 29);
            this.btnArchivos.Name = "btnArchivos";
            this.btnArchivos.Size = new System.Drawing.Size(162, 42);
            this.btnArchivos.TabIndex = 16;
            this.btnArchivos.Text = "Archivos";
            this.btnArchivos.UseVisualStyleBackColor = true;
            this.btnArchivos.Click += new System.EventHandler(this.btnArchivos_Click);
            // 
            // grpArchivos
            // 
            this.grpArchivos.BackColor = System.Drawing.Color.Transparent;
            this.grpArchivos.Controls.Add(this.btnArchivos);
            this.grpArchivos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpArchivos.Location = new System.Drawing.Point(28, 405);
            this.grpArchivos.Name = "grpArchivos";
            this.grpArchivos.Size = new System.Drawing.Size(200, 84);
            this.grpArchivos.TabIndex = 17;
            this.grpArchivos.TabStop = false;
            this.grpArchivos.Text = "Archivos:";
            // 
            // rtbInfoTp
            // 
            this.rtbInfoTp.Location = new System.Drawing.Point(497, 22);
            this.rtbInfoTp.Name = "rtbInfoTp";
            this.rtbInfoTp.Size = new System.Drawing.Size(365, 100);
            this.rtbInfoTp.TabIndex = 18;
            this.rtbInfoTp.Text = "";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 527);
            this.Controls.Add(this.rtbInfoTp);
            this.Controls.Add(this.grpArchivos);
            this.Controls.Add(this.grpInformacion);
            this.Controls.Add(this.grpFabricar);
            this.Controls.Add(this.grpContratarEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.grpContratarEmpleados.ResumeLayout(false);
            this.grpFabricar.ResumeLayout(false);
            this.grpInformacion.ResumeLayout(false);
            this.grpArchivos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnContratarEmpleados;
        private System.Windows.Forms.Button btnFabricarAlternador;
        private System.Windows.Forms.Button btnFabricarArranque;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.GroupBox grpContratarEmpleados;
        private System.Windows.Forms.GroupBox grpFabricar;
        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.Button btnArchivos;
        private System.Windows.Forms.GroupBox grpArchivos;
        private System.Windows.Forms.RichTextBox rtbInfoTp;
    }
}

