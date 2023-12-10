
namespace TAREA_2._1
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
            this.lstbProductId = new System.Windows.Forms.ListBox();
            this.lstbUnitStock = new System.Windows.Forms.ListBox();
            this.lstbUnitPrice = new System.Windows.Forms.ListBox();
            this.lstbProductName = new System.Windows.Forms.ListBox();
            this.lblID1 = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.lblStock1 = new System.Windows.Forms.Label();
            this.txtbProductId = new System.Windows.Forms.TextBox();
            this.txtbProductName = new System.Windows.Forms.TextBox();
            this.txtbUnitPrice = new System.Windows.Forms.TextBox();
            this.txtbUnitStock = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblID2 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblStock2 = new System.Windows.Forms.Label();
            
            
            
            
            // 
            // lstbProductId
            // 
            this.lstbProductId.FormattingEnabled = true;
            this.lstbProductId.Location = new System.Drawing.Point(193, 73);
            this.lstbProductId.Name = "lstbProductId";
            this.lstbProductId.Size = new System.Drawing.Size(80, 394);
            this.lstbProductId.TabIndex = 0;
            this.lstbProductId.SelectedIndexChanged += new System.EventHandler(this.lstb_SelectedIndexChanged);
            // 
            // lstbUnitStock
            // 
            this.lstbUnitStock.FormattingEnabled = true;
            this.lstbUnitStock.Location = new System.Drawing.Point(572, 73);
            this.lstbUnitStock.Name = "lstbUnitStock";
            this.lstbUnitStock.Size = new System.Drawing.Size(73, 394);
            this.lstbUnitStock.TabIndex = 1;
            this.lstbUnitStock.SelectedIndexChanged += new System.EventHandler(this.lstb_SelectedIndexChanged);
            // 
            // lstbUnitPrice
            // 
            this.lstbUnitPrice.FormattingEnabled = true;
            this.lstbUnitPrice.Location = new System.Drawing.Point(471, 73);
            this.lstbUnitPrice.Name = "lstbUnitPrice";
            this.lstbUnitPrice.Size = new System.Drawing.Size(71, 394);
            this.lstbUnitPrice.TabIndex = 2;
            this.lstbUnitPrice.SelectedIndexChanged += new System.EventHandler(this.lstb_SelectedIndexChanged);
            // 
            // lstbProductName
            // 
            this.lstbProductName.FormattingEnabled = true;
            this.lstbProductName.Location = new System.Drawing.Point(293, 73);
            this.lstbProductName.Name = "lstbProductName";
            this.lstbProductName.Size = new System.Drawing.Size(157, 394);
            this.lstbProductName.TabIndex = 3;
            this.lstbProductName.SelectedIndexChanged += new System.EventHandler(this.lstb_SelectedIndexChanged);
            // 
            // lblID1
            // 
            this.lblID1.AutoSize = true;
            this.lblID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID1.Location = new System.Drawing.Point(190, 29);
            this.lblID1.Name = "lblID1";
            this.lblID1.Size = new System.Drawing.Size(76, 16);
            this.lblID1.TabIndex = 4;
            this.lblID1.Text = "ProductID";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName1.Location = new System.Drawing.Point(290, 29);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(102, 16);
            this.lblName1.TabIndex = 5;
            this.lblName1.Text = "ProductName";
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice1.Location = new System.Drawing.Point(468, 29);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(74, 16);
            this.lblPrice1.TabIndex = 6;
            this.lblPrice1.Text = "Unit price";
            // 
            // lblStock1
            // 
            this.lblStock1.AutoSize = true;
            this.lblStock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock1.Location = new System.Drawing.Point(569, 28);
            this.lblStock1.Name = "lblStock1";
            this.lblStock1.Size = new System.Drawing.Size(92, 16);
            this.lblStock1.TabIndex = 7;
            this.lblStock1.Text = "Unit in stock";
            // 
            // txtbProductId
            // 
            this.txtbProductId.Location = new System.Drawing.Point(795, 73);
            this.txtbProductId.Name = "txtbProductId";
            this.txtbProductId.ReadOnly = true;
            this.txtbProductId.Size = new System.Drawing.Size(165, 20);
            this.txtbProductId.TabIndex = 8;
            // 
            // txtbProductName
            // 
            this.txtbProductName.Location = new System.Drawing.Point(795, 141);
            this.txtbProductName.Name = "txtbProductName";
            this.txtbProductName.Size = new System.Drawing.Size(165, 20);
            this.txtbProductName.TabIndex = 9;
            // 
            // txtbUnitPrice
            // 
            this.txtbUnitPrice.Location = new System.Drawing.Point(795, 219);
            this.txtbUnitPrice.Name = "txtbUnitPrice";
            this.txtbUnitPrice.Size = new System.Drawing.Size(165, 20);
            this.txtbUnitPrice.TabIndex = 10;
            // 
            // txtbUnitStock
            // 
            this.txtbUnitStock.Location = new System.Drawing.Point(795, 297);
            this.txtbUnitStock.Name = "txtbUnitStock";
            this.txtbUnitStock.Size = new System.Drawing.Size(165, 20);
            this.txtbUnitStock.TabIndex = 11;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(795, 444);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(165, 23);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblID2
            // 
            this.lblID2.AutoSize = true;
            this.lblID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID2.Location = new System.Drawing.Point(691, 73);
            this.lblID2.Name = "lblID2";
            this.lblID2.Size = new System.Drawing.Size(76, 16);
            this.lblID2.TabIndex = 13;
            this.lblID2.Text = "ProductID";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.Location = new System.Drawing.Point(691, 148);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(102, 16);
            this.lblName2.TabIndex = 14;
            this.lblName2.Text = "ProductName";
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice2.Location = new System.Drawing.Point(691, 226);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(74, 16);
            this.lblPrice2.TabIndex = 15;
            this.lblPrice2.Text = "Unit price";
            // 
            // lblStock2
            // 
            this.lblStock2.AutoSize = true;
            this.lblStock2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock2.Location = new System.Drawing.Point(691, 304);
            this.lblStock2.Name = "lblStock2";
            this.lblStock2.Size = new System.Drawing.Size(92, 16);
            this.lblStock2.TabIndex = 16;
            this.lblStock2.Text = "Unit in stock";
            // 
            // splitContainer1
            // 
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 496);
            
            this.Controls.Add(this.lblStock2);
            this.Controls.Add(this.lblPrice2);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblID2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtbUnitStock);
            this.Controls.Add(this.txtbUnitPrice);
            this.Controls.Add(this.txtbProductName);
            this.Controls.Add(this.txtbProductId);
            this.Controls.Add(this.lblStock1);
            this.Controls.Add(this.lblPrice1);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.lblID1);
            this.Controls.Add(this.lstbProductName);
            this.Controls.Add(this.lstbUnitPrice);
            this.Controls.Add(this.lstbUnitStock);
            this.Controls.Add(this.lstbProductId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbProductId;
        private System.Windows.Forms.ListBox lstbUnitStock;
        private System.Windows.Forms.ListBox lstbUnitPrice;
        private System.Windows.Forms.ListBox lstbProductName;
        private System.Windows.Forms.Label lblID1;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.Label lblStock1;
        private System.Windows.Forms.TextBox txtbProductId;
        private System.Windows.Forms.TextBox txtbProductName;
        private System.Windows.Forms.TextBox txtbUnitPrice;
        private System.Windows.Forms.TextBox txtbUnitStock;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblID2;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label lblStock2;
        
    }
}

