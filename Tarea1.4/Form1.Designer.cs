
namespace Tarea1._4
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
            this.lstBxTitulos = new System.Windows.Forms.ListBox();
            this.lstBxActores = new System.Windows.Forms.ListBox();
            this.lstBxDirectores = new System.Windows.Forms.ListBox();
            this.lblTitulos = new System.Windows.Forms.Label();
            this.lblActores = new System.Windows.Forms.Label();
            this.lblDirectores = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBxTitulos
            // 
            this.lstBxTitulos.FormattingEnabled = true;
            this.lstBxTitulos.Location = new System.Drawing.Point(388, 78);
            this.lstBxTitulos.Name = "lstBxTitulos";
            this.lstBxTitulos.Size = new System.Drawing.Size(350, 550);
            this.lstBxTitulos.TabIndex = 0;
            // 
            // lstBxActores
            // 
            this.lstBxActores.FormattingEnabled = true;
            this.lstBxActores.Location = new System.Drawing.Point(744, 78);
            this.lstBxActores.Name = "lstBxActores";
            this.lstBxActores.Size = new System.Drawing.Size(350, 550);
            this.lstBxActores.TabIndex = 1;
            // 
            // lstBxDirectores
            // 
            this.lstBxDirectores.FormattingEnabled = true;
            this.lstBxDirectores.Location = new System.Drawing.Point(1100, 78);
            this.lstBxDirectores.Name = "lstBxDirectores";
            this.lstBxDirectores.Size = new System.Drawing.Size(350, 550);
            this.lstBxDirectores.TabIndex = 2;
            // 
            // lblTitulos
            // 
            this.lblTitulos.AutoSize = true;
            this.lblTitulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulos.Location = new System.Drawing.Point(384, 41);
            this.lblTitulos.Name = "lblTitulos";
            this.lblTitulos.Size = new System.Drawing.Size(62, 20);
            this.lblTitulos.TabIndex = 3;
            this.lblTitulos.Text = "Titulos";
            // 
            // lblActores
            // 
            this.lblActores.AutoSize = true;
            this.lblActores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActores.Location = new System.Drawing.Point(740, 41);
            this.lblActores.Name = "lblActores";
            this.lblActores.Size = new System.Drawing.Size(71, 20);
            this.lblActores.TabIndex = 4;
            this.lblActores.Text = "Actores";
            // 
            // lblDirectores
            // 
            this.lblDirectores.AutoSize = true;
            this.lblDirectores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectores.Location = new System.Drawing.Point(1096, 41);
            this.lblDirectores.Name = "lblDirectores";
            this.lblDirectores.Size = new System.Drawing.Size(92, 20);
            this.lblDirectores.TabIndex = 5;
            this.lblDirectores.Text = "Directores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tarea1._4.Properties.Resources.cine;
            this.pictureBox1.Location = new System.Drawing.Point(3, 392);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 640);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDirectores);
            this.Controls.Add(this.lblActores);
            this.Controls.Add(this.lblTitulos);
            this.Controls.Add(this.lstBxDirectores);
            this.Controls.Add(this.lstBxActores);
            this.Controls.Add(this.lstBxTitulos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxTitulos;
        private System.Windows.Forms.ListBox lstBxActores;
        private System.Windows.Forms.ListBox lstBxDirectores;
        private System.Windows.Forms.Label lblTitulos;
        private System.Windows.Forms.Label lblActores;
        private System.Windows.Forms.Label lblDirectores;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

