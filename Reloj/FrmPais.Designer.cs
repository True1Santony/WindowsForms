
namespace Reloj
{
    partial class FrmPais
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
            this.txtNombrePais = new System.Windows.Forms.TextBox();
            this.txtDiferenciaHora = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.btnAceptarPais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombrePais
            // 
            this.txtNombrePais.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombrePais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePais.Location = new System.Drawing.Point(150, 32);
            this.txtNombrePais.Multiline = true;
            this.txtNombrePais.Name = "txtNombrePais";
            this.txtNombrePais.Size = new System.Drawing.Size(158, 40);
            this.txtNombrePais.TabIndex = 0;
            // 
            // txtDiferenciaHora
            // 
            this.txtDiferenciaHora.BackColor = System.Drawing.SystemColors.Info;
            this.txtDiferenciaHora.Location = new System.Drawing.Point(150, 150);
            this.txtDiferenciaHora.Multiline = true;
            this.txtDiferenciaHora.Name = "txtDiferenciaHora";
            this.txtDiferenciaHora.Size = new System.Drawing.Size(158, 42);
            this.txtDiferenciaHora.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(25, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferencia.Location = new System.Drawing.Point(25, 148);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(91, 20);
            this.lblDiferencia.TabIndex = 3;
            this.lblDiferencia.Text = "Diferencia";
            // 
            // btnAceptarPais
            // 
            this.btnAceptarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarPais.Location = new System.Drawing.Point(86, 260);
            this.btnAceptarPais.Name = "btnAceptarPais";
            this.btnAceptarPais.Size = new System.Drawing.Size(102, 35);
            this.btnAceptarPais.TabIndex = 4;
            this.btnAceptarPais.Text = "Apeptar";
            this.btnAceptarPais.UseVisualStyleBackColor = true;
            this.btnAceptarPais.Click += new System.EventHandler(this.btnApeptarPais_Click);
            // 
            // FrmPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(333, 324);
            this.Controls.Add(this.btnAceptarPais);
            this.Controls.Add(this.lblDiferencia);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDiferenciaHora);
            this.Controls.Add(this.txtNombrePais);
            this.Name = "FrmPais";
            this.Text = "FrmPais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombrePais;
        private System.Windows.Forms.TextBox txtDiferenciaHora;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.Button btnAceptarPais;
    }
}