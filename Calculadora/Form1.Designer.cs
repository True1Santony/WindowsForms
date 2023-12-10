
namespace Calculadora
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
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnBorraMemoria = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnUnoSobreX = new System.Windows.Forms.Button();
            this.BtnCero = new System.Windows.Forms.Button();
            this.btnSumaALaMemoria = new System.Windows.Forms.Button();
            this.btnGuardaEnMemoria = new System.Windows.Forms.Button();
            this.btnMuestraEnMemoria = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnBorra = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnBorraOperando = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNueve
            // 
            this.btnNueve.Location = new System.Drawing.Point(163, 202);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(40, 40);
            this.btnNueve.TabIndex = 0;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.BtnCero_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Location = new System.Drawing.Point(117, 202);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(40, 40);
            this.btnOcho.TabIndex = 1;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.BtnCero_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(117, 248);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(40, 40);
            this.btnCinco.TabIndex = 2;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.BtnCero_Click);
            // 
            // btnDos
            // 
            this.btnDos.Location = new System.Drawing.Point(117, 291);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(40, 40);
            this.btnDos.TabIndex = 3;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.BtnCero_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(163, 245);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(40, 40);
            this.btnSeis.TabIndex = 4;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.BtnCero_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(163, 291);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(40, 40);
            this.btnTres.TabIndex = 5;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.BtnCero_Click);
            // 
            // btnMas
            // 
            this.btnMas.ForeColor = System.Drawing.Color.Red;
            this.btnMas.Location = new System.Drawing.Point(163, 337);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(40, 40);
            this.btnMas.TabIndex = 6;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Location = new System.Drawing.Point(71, 202);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(40, 40);
            this.btnSiete.TabIndex = 7;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.BtnCero_Click);
            // 
            // btnBorraMemoria
            // 
            this.btnBorraMemoria.ForeColor = System.Drawing.Color.Red;
            this.btnBorraMemoria.Location = new System.Drawing.Point(9, 202);
            this.btnBorraMemoria.Name = "btnBorraMemoria";
            this.btnBorraMemoria.Size = new System.Drawing.Size(40, 40);
            this.btnBorraMemoria.TabIndex = 8;
            this.btnBorraMemoria.Text = "MC";
            this.btnBorraMemoria.UseVisualStyleBackColor = true;
            this.btnBorraMemoria.Click += new System.EventHandler(this.btnBorraMemoria_Click);
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(71, 291);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(40, 40);
            this.btnUno.TabIndex = 9;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.BtnCero_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Location = new System.Drawing.Point(71, 248);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(40, 40);
            this.btnCuatro.TabIndex = 10;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.BtnCero_Click);
            // 
            // btnUnoSobreX
            // 
            this.btnUnoSobreX.Location = new System.Drawing.Point(117, 337);
            this.btnUnoSobreX.Name = "btnUnoSobreX";
            this.btnUnoSobreX.Size = new System.Drawing.Size(40, 40);
            this.btnUnoSobreX.TabIndex = 11;
            this.btnUnoSobreX.Text = "1/x";
            this.btnUnoSobreX.UseVisualStyleBackColor = true;
            // 
            // BtnCero
            // 
            this.BtnCero.Location = new System.Drawing.Point(71, 337);
            this.BtnCero.Name = "BtnCero";
            this.BtnCero.Size = new System.Drawing.Size(40, 40);
            this.BtnCero.TabIndex = 12;
            this.BtnCero.Text = "0";
            this.BtnCero.UseVisualStyleBackColor = true;
            this.BtnCero.Click += new System.EventHandler(this.BtnCero_Click);
            // 
            // btnSumaALaMemoria
            // 
            this.btnSumaALaMemoria.ForeColor = System.Drawing.Color.Red;
            this.btnSumaALaMemoria.Location = new System.Drawing.Point(9, 337);
            this.btnSumaALaMemoria.Name = "btnSumaALaMemoria";
            this.btnSumaALaMemoria.Size = new System.Drawing.Size(40, 40);
            this.btnSumaALaMemoria.TabIndex = 13;
            this.btnSumaALaMemoria.Text = "M+";
            this.btnSumaALaMemoria.UseVisualStyleBackColor = true;
            this.btnSumaALaMemoria.Click += new System.EventHandler(this.btnSumaALaMemoria_Click);
            // 
            // btnGuardaEnMemoria
            // 
            this.btnGuardaEnMemoria.ForeColor = System.Drawing.Color.Red;
            this.btnGuardaEnMemoria.Location = new System.Drawing.Point(9, 291);
            this.btnGuardaEnMemoria.Name = "btnGuardaEnMemoria";
            this.btnGuardaEnMemoria.Size = new System.Drawing.Size(40, 40);
            this.btnGuardaEnMemoria.TabIndex = 14;
            this.btnGuardaEnMemoria.Text = "MS";
            this.btnGuardaEnMemoria.UseVisualStyleBackColor = true;
            // 
            // btnMuestraEnMemoria
            // 
            this.btnMuestraEnMemoria.ForeColor = System.Drawing.Color.Red;
            this.btnMuestraEnMemoria.Location = new System.Drawing.Point(9, 248);
            this.btnMuestraEnMemoria.Name = "btnMuestraEnMemoria";
            this.btnMuestraEnMemoria.Size = new System.Drawing.Size(40, 40);
            this.btnMuestraEnMemoria.TabIndex = 15;
            this.btnMuestraEnMemoria.Text = "MR";
            this.btnMuestraEnMemoria.UseVisualStyleBackColor = true;
            this.btnMuestraEnMemoria.Click += new System.EventHandler(this.btnMuestraEnMemoria_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.ForeColor = System.Drawing.Color.Red;
            this.btnDividir.Location = new System.Drawing.Point(209, 202);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(40, 40);
            this.btnDividir.TabIndex = 16;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnBorra
            // 
            this.btnBorra.ForeColor = System.Drawing.Color.Red;
            this.btnBorra.Location = new System.Drawing.Point(189, 171);
            this.btnBorra.Name = "btnBorra";
            this.btnBorra.Size = new System.Drawing.Size(60, 25);
            this.btnBorra.TabIndex = 17;
            this.btnBorra.Text = "C";
            this.btnBorra.UseVisualStyleBackColor = true;
            this.btnBorra.Click += new System.EventHandler(this.btnBorra_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.ForeColor = System.Drawing.Color.Red;
            this.btnIgual.Location = new System.Drawing.Point(209, 337);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(40, 40);
            this.btnIgual.TabIndex = 18;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.ForeColor = System.Drawing.Color.Red;
            this.btnRestar.Location = new System.Drawing.Point(209, 291);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(40, 40);
            this.btnRestar.TabIndex = 19;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.ForeColor = System.Drawing.Color.Red;
            this.btnMultiplicar.Location = new System.Drawing.Point(209, 245);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(40, 40);
            this.btnMultiplicar.TabIndex = 20;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnBorraOperando
            // 
            this.btnBorraOperando.ForeColor = System.Drawing.Color.Red;
            this.btnBorraOperando.Location = new System.Drawing.Point(123, 171);
            this.btnBorraOperando.Name = "btnBorraOperando";
            this.btnBorraOperando.Size = new System.Drawing.Size(60, 25);
            this.btnBorraOperando.TabIndex = 21;
            this.btnBorraOperando.Text = "CE";
            this.btnBorraOperando.UseVisualStyleBackColor = true;
            this.btnBorraOperando.Click += new System.EventHandler(this.btnBorraOperando_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(9, 34);
            this.txtResultado.MaxLength = 11;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(245, 55);
            this.txtResultado.TabIndex = 22;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 399);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnBorraOperando);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnBorra);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMuestraEnMemoria);
            this.Controls.Add(this.btnGuardaEnMemoria);
            this.Controls.Add(this.btnSumaALaMemoria);
            this.Controls.Add(this.BtnCero);
            this.Controls.Add(this.btnUnoSobreX);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnBorraMemoria);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnNueve);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnBorraMemoria;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnUnoSobreX;
        private System.Windows.Forms.Button BtnCero;
        private System.Windows.Forms.Button btnSumaALaMemoria;
        private System.Windows.Forms.Button btnGuardaEnMemoria;
        private System.Windows.Forms.Button btnMuestraEnMemoria;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnBorra;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnBorraOperando;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

