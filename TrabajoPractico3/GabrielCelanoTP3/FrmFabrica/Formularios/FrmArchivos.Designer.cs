
namespace FrmFabrica
{
    partial class FrmArchivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArchivos));
            this.btnGuardarFabrica = new System.Windows.Forms.Button();
            this.btnGuardarJornada = new System.Windows.Forms.Button();
            this.rtbListaArchivos = new System.Windows.Forms.RichTextBox();
            this.btnCargarFabrica = new System.Windows.Forms.Button();
            this.btnLeerJornada = new System.Windows.Forms.Button();
            this.grpFabrica = new System.Windows.Forms.GroupBox();
            this.grpJornada = new System.Windows.Forms.GroupBox();
            this.grpFabrica.SuspendLayout();
            this.grpJornada.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardarFabrica
            // 
            this.btnGuardarFabrica.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarFabrica.Location = new System.Drawing.Point(29, 19);
            this.btnGuardarFabrica.Name = "btnGuardarFabrica";
            this.btnGuardarFabrica.Size = new System.Drawing.Size(148, 34);
            this.btnGuardarFabrica.TabIndex = 0;
            this.btnGuardarFabrica.Text = "Guardar datos de la fabrica";
            this.btnGuardarFabrica.UseVisualStyleBackColor = true;
            this.btnGuardarFabrica.Click += new System.EventHandler(this.btnGuardarFabrica_Click);
            // 
            // btnGuardarJornada
            // 
            this.btnGuardarJornada.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarJornada.Location = new System.Drawing.Point(29, 19);
            this.btnGuardarJornada.Name = "btnGuardarJornada";
            this.btnGuardarJornada.Size = new System.Drawing.Size(148, 34);
            this.btnGuardarJornada.TabIndex = 1;
            this.btnGuardarJornada.Text = "Guardar jornada laboral";
            this.btnGuardarJornada.UseVisualStyleBackColor = true;
            this.btnGuardarJornada.Click += new System.EventHandler(this.btnGuardarJornada_Click);
            // 
            // rtbListaArchivos
            // 
            this.rtbListaArchivos.Location = new System.Drawing.Point(235, 32);
            this.rtbListaArchivos.Name = "rtbListaArchivos";
            this.rtbListaArchivos.Size = new System.Drawing.Size(330, 406);
            this.rtbListaArchivos.TabIndex = 3;
            this.rtbListaArchivos.Text = "";
            // 
            // btnCargarFabrica
            // 
            this.btnCargarFabrica.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarFabrica.Location = new System.Drawing.Point(29, 59);
            this.btnCargarFabrica.Name = "btnCargarFabrica";
            this.btnCargarFabrica.Size = new System.Drawing.Size(148, 34);
            this.btnCargarFabrica.TabIndex = 4;
            this.btnCargarFabrica.Text = "Leer datos de la fabrica";
            this.btnCargarFabrica.UseVisualStyleBackColor = true;
            this.btnCargarFabrica.Click += new System.EventHandler(this.btnCargarFabrica_Click);
            // 
            // btnLeerJornada
            // 
            this.btnLeerJornada.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerJornada.Location = new System.Drawing.Point(29, 59);
            this.btnLeerJornada.Name = "btnLeerJornada";
            this.btnLeerJornada.Size = new System.Drawing.Size(148, 34);
            this.btnLeerJornada.TabIndex = 6;
            this.btnLeerJornada.Text = "Leer jornada laboral";
            this.btnLeerJornada.UseVisualStyleBackColor = true;
            this.btnLeerJornada.Click += new System.EventHandler(this.btnLeerJornada_Click);
            // 
            // grpFabrica
            // 
            this.grpFabrica.BackColor = System.Drawing.Color.Transparent;
            this.grpFabrica.Controls.Add(this.btnGuardarFabrica);
            this.grpFabrica.Controls.Add(this.btnCargarFabrica);
            this.grpFabrica.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFabrica.Location = new System.Drawing.Point(12, 63);
            this.grpFabrica.Name = "grpFabrica";
            this.grpFabrica.Size = new System.Drawing.Size(200, 110);
            this.grpFabrica.TabIndex = 7;
            this.grpFabrica.TabStop = false;
            this.grpFabrica.Text = "Fabrica:";
            // 
            // grpJornada
            // 
            this.grpJornada.BackColor = System.Drawing.Color.Transparent;
            this.grpJornada.Controls.Add(this.btnGuardarJornada);
            this.grpJornada.Controls.Add(this.btnLeerJornada);
            this.grpJornada.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpJornada.Location = new System.Drawing.Point(12, 235);
            this.grpJornada.Name = "grpJornada";
            this.grpJornada.Size = new System.Drawing.Size(200, 100);
            this.grpJornada.TabIndex = 8;
            this.grpJornada.TabStop = false;
            this.grpJornada.Text = "Jornada:";
            // 
            // FrmArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.grpJornada);
            this.Controls.Add(this.grpFabrica);
            this.Controls.Add(this.rtbListaArchivos);
            this.Name = "FrmArchivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Archivos";
            this.grpFabrica.ResumeLayout(false);
            this.grpJornada.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarFabrica;
        private System.Windows.Forms.Button btnGuardarJornada;
        private System.Windows.Forms.RichTextBox rtbListaArchivos;
        private System.Windows.Forms.Button btnCargarFabrica;
        private System.Windows.Forms.Button btnLeerJornada;
        private System.Windows.Forms.GroupBox grpFabrica;
        private System.Windows.Forms.GroupBox grpJornada;
    }
}