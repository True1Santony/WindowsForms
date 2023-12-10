
namespace WindowsFormsHolaMundo
{
    partial class Form1
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
            this.BtnPulsar = new System.Windows.Forms.Button();
            this.TxtMensaje = new System.Windows.Forms.TextBox();
            this.BtnAdios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPulsar
            // 
            this.BtnPulsar.Location = new System.Drawing.Point(383, 259);
            this.BtnPulsar.Name = "BtnPulsar";
            this.BtnPulsar.Size = new System.Drawing.Size(75, 23);
            this.BtnPulsar.TabIndex = 0;
            this.BtnPulsar.Text = "Pulsar";
            this.BtnPulsar.UseVisualStyleBackColor = true;
            this.BtnPulsar.Click += new System.EventHandler(this.BtnPulsar_Click);
            // 
            // TxtMensaje
            // 
            this.TxtMensaje.Location = new System.Drawing.Point(383, 174);
            this.TxtMensaje.Name = "TxtMensaje";
            this.TxtMensaje.Size = new System.Drawing.Size(100, 20);
            this.TxtMensaje.TabIndex = 1;
            // 
            // BtnAdios
            // 
            this.BtnAdios.Location = new System.Drawing.Point(497, 258);
            this.BtnAdios.Name = "BtnAdios";
            this.BtnAdios.Size = new System.Drawing.Size(75, 23);
            this.BtnAdios.TabIndex = 2;
            this.BtnAdios.Text = "Adios";
            this.BtnAdios.UseVisualStyleBackColor = true;
            this.BtnAdios.Click += new System.EventHandler(this.BtnPulsar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAdios);
            this.Controls.Add(this.TxtMensaje);
            this.Controls.Add(this.BtnPulsar);
            this.Name = "Form1";
            this.Text = "FrmHolaMundo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPulsar;
        private System.Windows.Forms.TextBox TxtMensaje;
        private System.Windows.Forms.Button BtnAdios;
    }
}

