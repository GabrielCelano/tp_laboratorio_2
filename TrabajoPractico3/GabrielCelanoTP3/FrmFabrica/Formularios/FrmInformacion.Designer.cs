
namespace FrmFabrica
{
    partial class FrmInformacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformacion));
            this.btnListaDeEmpleados = new System.Windows.Forms.Button();
            this.btnListaDeArranques = new System.Windows.Forms.Button();
            this.btnListaDeAlternadores = new System.Windows.Forms.Button();
            this.rtbLista = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnListaDeEmpleados
            // 
            this.btnListaDeEmpleados.Location = new System.Drawing.Point(34, 28);
            this.btnListaDeEmpleados.Name = "btnListaDeEmpleados";
            this.btnListaDeEmpleados.Size = new System.Drawing.Size(127, 49);
            this.btnListaDeEmpleados.TabIndex = 0;
            this.btnListaDeEmpleados.Text = "Lista de empleados";
            this.btnListaDeEmpleados.UseVisualStyleBackColor = true;
            this.btnListaDeEmpleados.Click += new System.EventHandler(this.btnListaDeEmpleados_Click);
            // 
            // btnListaDeArranques
            // 
            this.btnListaDeArranques.Location = new System.Drawing.Point(34, 99);
            this.btnListaDeArranques.Name = "btnListaDeArranques";
            this.btnListaDeArranques.Size = new System.Drawing.Size(127, 45);
            this.btnListaDeArranques.TabIndex = 3;
            this.btnListaDeArranques.Text = "Arranques Fabricados";
            this.btnListaDeArranques.UseVisualStyleBackColor = true;
            this.btnListaDeArranques.Click += new System.EventHandler(this.btnListaDeArranques_Click);
            // 
            // btnListaDeAlternadores
            // 
            this.btnListaDeAlternadores.Location = new System.Drawing.Point(34, 168);
            this.btnListaDeAlternadores.Name = "btnListaDeAlternadores";
            this.btnListaDeAlternadores.Size = new System.Drawing.Size(127, 45);
            this.btnListaDeAlternadores.TabIndex = 4;
            this.btnListaDeAlternadores.Text = "Alternadores Fabricados";
            this.btnListaDeAlternadores.UseVisualStyleBackColor = true;
            this.btnListaDeAlternadores.Click += new System.EventHandler(this.btnListaDeAlternadores_Click);
            // 
            // rtbLista
            // 
            this.rtbLista.Location = new System.Drawing.Point(208, 28);
            this.rtbLista.Name = "rtbLista";
            this.rtbLista.Size = new System.Drawing.Size(301, 405);
            this.rtbLista.TabIndex = 5;
            this.rtbLista.Text = "";
            // 
            // FrmInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(538, 445);
            this.Controls.Add(this.rtbLista);
            this.Controls.Add(this.btnListaDeAlternadores);
            this.Controls.Add(this.btnListaDeArranques);
            this.Controls.Add(this.btnListaDeEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmInformacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Informacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaDeEmpleados;
        private System.Windows.Forms.Button btnListaDeArranques;
        private System.Windows.Forms.Button btnListaDeAlternadores;
        private System.Windows.Forms.RichTextBox rtbLista;
    }
}