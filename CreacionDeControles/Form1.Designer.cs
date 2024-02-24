
namespace CreacionDeControles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.miControl = new MiControlHotel.UserControl1();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsButtonNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsButtonGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsButtonBorrar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // miControl
            // 
            this.miControl.Location = new System.Drawing.Point(577, 29);
            this.miControl.Name = "miControl";
            this.miControl.Size = new System.Drawing.Size(327, 343);
            this.miControl.TabIndex = 0;
            this.miControl.Load += new System.EventHandler(this.miControl_Load);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 608);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(941, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButtonNuevo,
            this.tsButtonGuardar,
            this.tsButtonBorrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(941, 38);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsButtonNuevo
            // 
            this.tsButtonNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonNuevo.Image")));
            this.tsButtonNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonNuevo.Name = "tsButtonNuevo";
            this.tsButtonNuevo.Size = new System.Drawing.Size(46, 35);
            this.tsButtonNuevo.Text = "Nuevo";
            this.tsButtonNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsButtonGuardar
            // 
            this.tsButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonGuardar.Image")));
            this.tsButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonGuardar.Name = "tsButtonGuardar";
            this.tsButtonGuardar.Size = new System.Drawing.Size(53, 35);
            this.tsButtonGuardar.Text = "Guardar";
            this.tsButtonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsButtonBorrar
            // 
            this.tsButtonBorrar.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonBorrar.Image")));
            this.tsButtonBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonBorrar.Name = "tsButtonBorrar";
            this.tsButtonBorrar.Size = new System.Drawing.Size(43, 35);
            this.tsButtonBorrar.Text = "Borrar";
            this.tsButtonBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 630);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.miControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MiControlHotel.UserControl1 miControl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsButtonNuevo;
        private System.Windows.Forms.ToolStripButton tsButtonGuardar;
        private System.Windows.Forms.ToolStripButton tsButtonBorrar;
    }
}

