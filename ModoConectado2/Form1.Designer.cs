
namespace ModoConectado2
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
            this.lstbDepartamento = new System.Windows.Forms.ListBox();
            this.lstbLocalizacion = new System.Windows.Forms.ListBox();
            this.lstbApellidos = new System.Windows.Forms.ListBox();
            this.lstbOficio = new System.Windows.Forms.ListBox();
            this.lstbSalario = new System.Windows.Forms.ListBox();
            this.lstbFechaAlta = new System.Windows.Forms.ListBox();
            this.lstbComision = new System.Windows.Forms.ListBox();
            this.lstbBuscarPor = new System.Windows.Forms.ListBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtOficio = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtFechaAlta = new System.Windows.Forms.TextBox();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.txtbBuscar = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblLocalizacion = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblOficio = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBajar = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstbOcultoID = new System.Windows.Forms.ListBox();
            this.txtOcultoID = new System.Windows.Forms.TextBox();
            this.txtIDdepartamento = new System.Windows.Forms.TextBox();
            this.lstbIDdepartamento = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstbDepartamento
            // 
            this.lstbDepartamento.FormattingEnabled = true;
            this.lstbDepartamento.Location = new System.Drawing.Point(137, 43);
            this.lstbDepartamento.Name = "lstbDepartamento";
            this.lstbDepartamento.Size = new System.Drawing.Size(120, 95);
            this.lstbDepartamento.TabIndex = 0;
            this.lstbDepartamento.Click += new System.EventHandler(this.lstbDepartamento_Click);
            this.lstbDepartamento.SelectedIndexChanged += new System.EventHandler(this.lstbDepartamento_SelectedIndexChanged);
            // 
            // lstbLocalizacion
            // 
            this.lstbLocalizacion.FormattingEnabled = true;
            this.lstbLocalizacion.Location = new System.Drawing.Point(337, 43);
            this.lstbLocalizacion.Name = "lstbLocalizacion";
            this.lstbLocalizacion.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstbLocalizacion.Size = new System.Drawing.Size(120, 95);
            this.lstbLocalizacion.TabIndex = 1;
            // 
            // lstbApellidos
            // 
            this.lstbApellidos.FormattingEnabled = true;
            this.lstbApellidos.Location = new System.Drawing.Point(38, 206);
            this.lstbApellidos.Name = "lstbApellidos";
            this.lstbApellidos.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstbApellidos.Size = new System.Drawing.Size(97, 199);
            this.lstbApellidos.TabIndex = 2;
            // 
            // lstbOficio
            // 
            this.lstbOficio.FormattingEnabled = true;
            this.lstbOficio.Location = new System.Drawing.Point(154, 206);
            this.lstbOficio.Name = "lstbOficio";
            this.lstbOficio.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstbOficio.Size = new System.Drawing.Size(96, 199);
            this.lstbOficio.TabIndex = 3;
            // 
            // lstbSalario
            // 
            this.lstbSalario.FormattingEnabled = true;
            this.lstbSalario.Location = new System.Drawing.Point(278, 206);
            this.lstbSalario.Name = "lstbSalario";
            this.lstbSalario.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstbSalario.Size = new System.Drawing.Size(90, 199);
            this.lstbSalario.TabIndex = 4;
            // 
            // lstbFechaAlta
            // 
            this.lstbFechaAlta.FormattingEnabled = true;
            this.lstbFechaAlta.Location = new System.Drawing.Point(396, 206);
            this.lstbFechaAlta.Name = "lstbFechaAlta";
            this.lstbFechaAlta.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstbFechaAlta.Size = new System.Drawing.Size(90, 199);
            this.lstbFechaAlta.TabIndex = 5;
            // 
            // lstbComision
            // 
            this.lstbComision.FormattingEnabled = true;
            this.lstbComision.Location = new System.Drawing.Point(503, 206);
            this.lstbComision.Name = "lstbComision";
            this.lstbComision.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstbComision.Size = new System.Drawing.Size(90, 199);
            this.lstbComision.TabIndex = 6;
            // 
            // lstbBuscarPor
            // 
            this.lstbBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbBuscarPor.FormattingEnabled = true;
            this.lstbBuscarPor.ItemHeight = 20;
            this.lstbBuscarPor.Location = new System.Drawing.Point(137, 479);
            this.lstbBuscarPor.Name = "lstbBuscarPor";
            this.lstbBuscarPor.Size = new System.Drawing.Size(120, 104);
            this.lstbBuscarPor.TabIndex = 7;
            this.lstbBuscarPor.SelectedIndexChanged += new System.EventHandler(this.lstbBuscarPor_SelectedIndexChanged);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(38, 420);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(97, 20);
            this.txtApellidos.TabIndex = 8;
            // 
            // txtOficio
            // 
            this.txtOficio.Location = new System.Drawing.Point(154, 420);
            this.txtOficio.Name = "txtOficio";
            this.txtOficio.Size = new System.Drawing.Size(96, 20);
            this.txtOficio.TabIndex = 9;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(278, 420);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(90, 20);
            this.txtSalario.TabIndex = 10;
            // 
            // txtFechaAlta
            // 
            this.txtFechaAlta.Location = new System.Drawing.Point(396, 420);
            this.txtFechaAlta.Name = "txtFechaAlta";
            this.txtFechaAlta.Size = new System.Drawing.Size(90, 20);
            this.txtFechaAlta.TabIndex = 11;
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(503, 420);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(90, 20);
            this.txtComision.TabIndex = 12;
            // 
            // txtbBuscar
            // 
            this.txtbBuscar.Location = new System.Drawing.Point(317, 521);
            this.txtbBuscar.Name = "txtbBuscar";
            this.txtbBuscar.Size = new System.Drawing.Size(95, 20);
            this.txtbBuscar.TabIndex = 13;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(133, 6);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(124, 20);
            this.lblDepartamento.TabIndex = 14;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblLocalizacion
            // 
            this.lblLocalizacion.AutoSize = true;
            this.lblLocalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizacion.Location = new System.Drawing.Point(333, 6);
            this.lblLocalizacion.Name = "lblLocalizacion";
            this.lblLocalizacion.Size = new System.Drawing.Size(108, 20);
            this.lblLocalizacion.TabIndex = 15;
            this.lblLocalizacion.Text = "Localizacíon";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(34, 175);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(82, 20);
            this.lblApellidos.TabIndex = 16;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblOficio
            // 
            this.lblOficio.AutoSize = true;
            this.lblOficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOficio.Location = new System.Drawing.Point(150, 175);
            this.lblOficio.Name = "lblOficio";
            this.lblOficio.Size = new System.Drawing.Size(55, 20);
            this.lblOficio.TabIndex = 17;
            this.lblOficio.Text = "Oficio";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(277, 175);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(65, 20);
            this.lblSalario.TabIndex = 18;
            this.lblSalario.Text = "Salario";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.Location = new System.Drawing.Point(392, 175);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(96, 20);
            this.lblFechaAlta.TabIndex = 19;
            this.lblFechaAlta.Text = "Fecha Alta";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComision.Location = new System.Drawing.Point(499, 175);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(82, 20);
            this.lblComision.TabIndex = 20;
            this.lblComision.Text = "Comisión";
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(34, 526);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(96, 20);
            this.lblBuscarPor.TabIndex = 21;
            this.lblBuscarPor.Text = "Buscar por";
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgual.Location = new System.Drawing.Point(273, 521);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(25, 25);
            this.lblIgual.TabIndex = 22;
            this.lblIgual.Text = "=";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::ModoConectado2.Properties.Resources.buscar;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(427, 479);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 69);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::ModoConectado2.Properties.Resources.nuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(656, 568);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 68);
            this.btnNuevo.TabIndex = 28;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::ModoConectado2.Properties.Resources.borrar;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(656, 494);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 68);
            this.btnBorrar.TabIndex = 27;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ModoConectado2.Properties.Resources.save_3621;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(656, 420);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 68);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBajar
            // 
            this.btnBajar.BackgroundImage = global::ModoConectado2.Properties.Resources.uparrow_abajo_1538;
            this.btnBajar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBajar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBajar.Location = new System.Drawing.Point(629, 313);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(51, 51);
            this.btnBajar.TabIndex = 25;
            this.btnBajar.UseVisualStyleBackColor = true;
            this.btnBajar.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.BackgroundImage = global::ModoConectado2.Properties.Resources.uparrow_arriba_1538;
            this.btnSubir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubir.Location = new System.Drawing.Point(629, 235);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(51, 51);
            this.btnSubir.TabIndex = 24;
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::ModoConectado2.Properties.Resources.power_77952;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(656, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 70);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstbOcultoID
            // 
            this.lstbOcultoID.FormattingEnabled = true;
            this.lstbOcultoID.Location = new System.Drawing.Point(10, 43);
            this.lstbOcultoID.Name = "lstbOcultoID";
            this.lstbOcultoID.Size = new System.Drawing.Size(120, 95);
            this.lstbOcultoID.TabIndex = 30;
            this.lstbOcultoID.Visible = false;
            // 
            // txtOcultoID
            // 
            this.txtOcultoID.Location = new System.Drawing.Point(12, 144);
            this.txtOcultoID.Name = "txtOcultoID";
            this.txtOcultoID.Size = new System.Drawing.Size(118, 20);
            this.txtOcultoID.TabIndex = 31;
            this.txtOcultoID.Visible = false;
            // 
            // txtIDdepartamento
            // 
            this.txtIDdepartamento.Location = new System.Drawing.Point(489, 144);
            this.txtIDdepartamento.Name = "txtIDdepartamento";
            this.txtIDdepartamento.Size = new System.Drawing.Size(118, 20);
            this.txtIDdepartamento.TabIndex = 32;
            this.txtIDdepartamento.Visible = false;
            // 
            // lstbIDdepartamento
            // 
            this.lstbIDdepartamento.FormattingEnabled = true;
            this.lstbIDdepartamento.Location = new System.Drawing.Point(489, 43);
            this.lstbIDdepartamento.Name = "lstbIDdepartamento";
            this.lstbIDdepartamento.Size = new System.Drawing.Size(120, 95);
            this.lstbIDdepartamento.TabIndex = 33;
            this.lstbIDdepartamento.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 651);
            this.Controls.Add(this.lstbIDdepartamento);
            this.Controls.Add(this.txtIDdepartamento);
            this.Controls.Add(this.txtOcultoID);
            this.Controls.Add(this.lstbOcultoID);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBajar);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.lblBuscarPor);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblOficio);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblLocalizacion);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.txtbBuscar);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.txtFechaAlta);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtOficio);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lstbBuscarPor);
            this.Controls.Add(this.lstbComision);
            this.Controls.Add(this.lstbFechaAlta);
            this.Controls.Add(this.lstbSalario);
            this.Controls.Add(this.lstbOficio);
            this.Controls.Add(this.lstbApellidos);
            this.Controls.Add(this.lstbLocalizacion);
            this.Controls.Add(this.lstbDepartamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbDepartamento;
        private System.Windows.Forms.ListBox lstbLocalizacion;
        private System.Windows.Forms.ListBox lstbApellidos;
        private System.Windows.Forms.ListBox lstbOficio;
        private System.Windows.Forms.ListBox lstbSalario;
        private System.Windows.Forms.ListBox lstbFechaAlta;
        private System.Windows.Forms.ListBox lstbComision;
        private System.Windows.Forms.ListBox lstbBuscarPor;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtOficio;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtFechaAlta;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.TextBox txtbBuscar;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblLocalizacion;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblOficio;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnBajar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lstbOcultoID;
        private System.Windows.Forms.TextBox txtOcultoID;
        private System.Windows.Forms.TextBox txtIDdepartamento;
        private System.Windows.Forms.ListBox lstbIDdepartamento;
    }
}

