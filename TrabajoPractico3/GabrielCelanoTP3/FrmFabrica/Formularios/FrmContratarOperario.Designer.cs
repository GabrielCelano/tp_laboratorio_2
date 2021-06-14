
namespace FrmFabrica
{
    partial class FrmContratarOperario
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.nudDNI = new System.Windows.Forms.NumericUpDown();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDNI)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(40, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(40, 54);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(40, 84);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(40, 116);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(64, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID Operario:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(128, 47);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(176, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(168, 109);
            this.nudID.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudID.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(136, 20);
            this.nudID.TabIndex = 7;
            this.nudID.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudDNI
            // 
            this.nudDNI.Location = new System.Drawing.Point(168, 77);
            this.nudDNI.Maximum = new decimal(new int[] {
            90000000,
            0,
            0,
            0});
            this.nudDNI.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDNI.Name = "nudDNI";
            this.nudDNI.Size = new System.Drawing.Size(136, 20);
            this.nudDNI.TabIndex = 8;
            this.nudDNI.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(43, 185);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(100, 50);
            this.btnVerificar.TabIndex = 10;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(204, 185);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(100, 50);
            this.btnAsignar.TabIndex = 11;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(43, 146);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(93, 13);
            this.lblPuesto.TabIndex = 12;
            this.lblPuesto.Text = "Puesto de trabajo:";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(168, 146);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(136, 21);
            this.cmbPuesto.TabIndex = 13;
            // 
            // FrmContratarOperario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 247);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.nudDNI);
            this.Controls.Add(this.nudID);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmContratarOperario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contratar Empleado";
            this.Load += new System.EventHandler(this.FrmAsignarOperarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDNI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.NumericUpDown nudDNI;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbPuesto;
    }
}