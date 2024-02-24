
namespace Examen
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
            this.lstbIncidencia = new System.Windows.Forms.ListBox();
            this.lstbDescIncidencia = new System.Windows.Forms.ListBox();
            this.lstbGeneraAveria = new System.Windows.Forms.ListBox();
            this.lstbFechaInicio = new System.Windows.Forms.ListBox();
            this.txtbIncidencia = new System.Windows.Forms.TextBox();
            this.txtbDescIncidencia = new System.Windows.Forms.TextBox();
            this.txtbGeneraAveria = new System.Windows.Forms.TextBox();
            this.txtbFechaInicio = new System.Windows.Forms.TextBox();
            this.lblIncidencia = new System.Windows.Forms.Label();
            this.lbldescIncidencia = new System.Windows.Forms.Label();
            this.lblGeneraAveria = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbIncidencia
            // 
            this.lstbIncidencia.FormattingEnabled = true;
            this.lstbIncidencia.Location = new System.Drawing.Point(330, 68);
            this.lstbIncidencia.Name = "lstbIncidencia";
            this.lstbIncidencia.Size = new System.Drawing.Size(145, 290);
            this.lstbIncidencia.TabIndex = 0;
            this.lstbIncidencia.SelectedIndexChanged += new System.EventHandler(this.lstbIncidencia_SelectedIndexChanged);
            // 
            // lstbDescIncidencia
            // 
            this.lstbDescIncidencia.FormattingEnabled = true;
            this.lstbDescIncidencia.Location = new System.Drawing.Point(501, 68);
            this.lstbDescIncidencia.Name = "lstbDescIncidencia";
            this.lstbDescIncidencia.Size = new System.Drawing.Size(145, 290);
            this.lstbDescIncidencia.TabIndex = 1;
            this.lstbDescIncidencia.SelectedIndexChanged += new System.EventHandler(this.lstbIncidencia_SelectedIndexChanged);
            // 
            // lstbGeneraAveria
            // 
            this.lstbGeneraAveria.FormattingEnabled = true;
            this.lstbGeneraAveria.Location = new System.Drawing.Point(695, 68);
            this.lstbGeneraAveria.Name = "lstbGeneraAveria";
            this.lstbGeneraAveria.Size = new System.Drawing.Size(147, 290);
            this.lstbGeneraAveria.TabIndex = 2;
            this.lstbGeneraAveria.SelectedIndexChanged += new System.EventHandler(this.lstbIncidencia_SelectedIndexChanged);
            // 
            // lstbFechaInicio
            // 
            this.lstbFechaInicio.FormattingEnabled = true;
            this.lstbFechaInicio.Location = new System.Drawing.Point(880, 68);
            this.lstbFechaInicio.Name = "lstbFechaInicio";
            this.lstbFechaInicio.Size = new System.Drawing.Size(145, 290);
            this.lstbFechaInicio.TabIndex = 3;
            this.lstbFechaInicio.SelectedIndexChanged += new System.EventHandler(this.lstbIncidencia_SelectedIndexChanged);
            // 
            // txtbIncidencia
            // 
            this.txtbIncidencia.Enabled = false;
            this.txtbIncidencia.Location = new System.Drawing.Point(330, 388);
            this.txtbIncidencia.Name = "txtbIncidencia";
            this.txtbIncidencia.Size = new System.Drawing.Size(145, 20);
            this.txtbIncidencia.TabIndex = 4;
            // 
            // txtbDescIncidencia
            // 
            this.txtbDescIncidencia.Location = new System.Drawing.Point(501, 388);
            this.txtbDescIncidencia.Name = "txtbDescIncidencia";
            this.txtbDescIncidencia.Size = new System.Drawing.Size(145, 20);
            this.txtbDescIncidencia.TabIndex = 5;
            // 
            // txtbGeneraAveria
            // 
            this.txtbGeneraAveria.Location = new System.Drawing.Point(697, 388);
            this.txtbGeneraAveria.Name = "txtbGeneraAveria";
            this.txtbGeneraAveria.Size = new System.Drawing.Size(145, 20);
            this.txtbGeneraAveria.TabIndex = 6;
            // 
            // txtbFechaInicio
            // 
            this.txtbFechaInicio.Location = new System.Drawing.Point(880, 388);
            this.txtbFechaInicio.Name = "txtbFechaInicio";
            this.txtbFechaInicio.Size = new System.Drawing.Size(145, 20);
            this.txtbFechaInicio.TabIndex = 7;
            // 
            // lblIncidencia
            // 
            this.lblIncidencia.AutoSize = true;
            this.lblIncidencia.Location = new System.Drawing.Point(330, 24);
            this.lblIncidencia.Name = "lblIncidencia";
            this.lblIncidencia.Size = new System.Drawing.Size(68, 13);
            this.lblIncidencia.TabIndex = 8;
            this.lblIncidencia.Text = "Id Incidencia";
            // 
            // lbldescIncidencia
            // 
            this.lbldescIncidencia.AutoSize = true;
            this.lbldescIncidencia.Location = new System.Drawing.Point(498, 24);
            this.lbldescIncidencia.Name = "lbldescIncidencia";
            this.lbldescIncidencia.Size = new System.Drawing.Size(84, 13);
            this.lbldescIncidencia.TabIndex = 9;
            this.lbldescIncidencia.Text = "Desc Incidencia";
            // 
            // lblGeneraAveria
            // 
            this.lblGeneraAveria.AutoSize = true;
            this.lblGeneraAveria.Location = new System.Drawing.Point(694, 24);
            this.lblGeneraAveria.Name = "lblGeneraAveria";
            this.lblGeneraAveria.Size = new System.Drawing.Size(74, 13);
            this.lblGeneraAveria.TabIndex = 10;
            this.lblGeneraAveria.Text = "Genera averia";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(877, 24);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(65, 13);
            this.lblFechaInicio.TabIndex = 11;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(-1, -3);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(53, 41);
            this.btnAlta.TabIndex = 12;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(58, -3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(73, 39);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 552);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblGeneraAveria);
            this.Controls.Add(this.lbldescIncidencia);
            this.Controls.Add(this.lblIncidencia);
            this.Controls.Add(this.txtbFechaInicio);
            this.Controls.Add(this.txtbGeneraAveria);
            this.Controls.Add(this.txtbDescIncidencia);
            this.Controls.Add(this.txtbIncidencia);
            this.Controls.Add(this.lstbFechaInicio);
            this.Controls.Add(this.lstbGeneraAveria);
            this.Controls.Add(this.lstbDescIncidencia);
            this.Controls.Add(this.lstbIncidencia);
            this.Name = "Form1";
            this.Text = "Examen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbIncidencia;
        private System.Windows.Forms.ListBox lstbDescIncidencia;
        private System.Windows.Forms.ListBox lstbGeneraAveria;
        private System.Windows.Forms.ListBox lstbFechaInicio;
        private System.Windows.Forms.TextBox txtbIncidencia;
        private System.Windows.Forms.TextBox txtbDescIncidencia;
        private System.Windows.Forms.TextBox txtbGeneraAveria;
        private System.Windows.Forms.TextBox txtbFechaInicio;
        private System.Windows.Forms.Label lblIncidencia;
        private System.Windows.Forms.Label lbldescIncidencia;
        private System.Windows.Forms.Label lblGeneraAveria;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBorrar;
    }
}

