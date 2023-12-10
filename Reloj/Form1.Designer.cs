
namespace Reloj
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
            this.components = new System.ComponentModel.Container();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MnuPais = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPaisAnadir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPaisBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoraPaisSeleccionado = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.SystemColors.Info;
            this.txtHora.Location = new System.Drawing.Point(276, 90);
            this.txtHora.Multiline = true;
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(169, 66);
            this.txtHora.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuPais});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(779, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MnuPais
            // 
            this.MnuPais.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuPaisAnadir,
            this.MnuPaisBorrar,
            this.MnuSeparator});
            this.MnuPais.Name = "MnuPais";
            this.MnuPais.Size = new System.Drawing.Size(40, 20);
            this.MnuPais.Text = "País";
            // 
            // MnuPaisAnadir
            // 
            this.MnuPaisAnadir.Name = "MnuPaisAnadir";
            this.MnuPaisAnadir.Size = new System.Drawing.Size(180, 22);
            this.MnuPaisAnadir.Text = "Añadir";
            this.MnuPaisAnadir.Click += new System.EventHandler(this.MnuPaisAnadir_Click);
            // 
            // MnuPaisBorrar
            // 
            this.MnuPaisBorrar.Name = "MnuPaisBorrar";
            this.MnuPaisBorrar.Size = new System.Drawing.Size(180, 22);
            this.MnuPaisBorrar.Text = "Borrar";
            this.MnuPaisBorrar.Click += new System.EventHandler(this.MnuPaisBorrar_Click);
            // 
            // MnuSeparator
            // 
            this.MnuSeparator.Name = "MnuSeparator";
            this.MnuSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hora en";
            // 
            // txtHoraPaisSeleccionado
            // 
            this.txtHoraPaisSeleccionado.BackColor = System.Drawing.SystemColors.Info;
            this.txtHoraPaisSeleccionado.Location = new System.Drawing.Point(276, 266);
            this.txtHoraPaisSeleccionado.Multiline = true;
            this.txtHoraPaisSeleccionado.Name = "txtHoraPaisSeleccionado";
            this.txtHoraPaisSeleccionado.Size = new System.Drawing.Size(169, 66);
            this.txtHoraPaisSeleccionado.TabIndex = 5;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(272, 243);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(19, 20);
            this.lblPais.TabIndex = 7;
            this.lblPais.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(779, 496);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoraPaisSeleccionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MnuPais;
        private System.Windows.Forms.ToolStripMenuItem MnuPaisAnadir;
        private System.Windows.Forms.ToolStripMenuItem MnuPaisBorrar;
        private System.Windows.Forms.ToolStripSeparator MnuSeparator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoraPaisSeleccionado;
        private System.Windows.Forms.Label lblPais;
    }
}

