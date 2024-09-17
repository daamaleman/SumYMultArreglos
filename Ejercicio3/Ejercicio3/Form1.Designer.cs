namespace Ejercicio3
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
            this.lblSeller = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbSeller = new System.Windows.Forms.TextBox();
            this.tbProducts = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.lbReport = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.Location = new System.Drawing.Point(48, 71);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(141, 25);
            this.lblSeller.TabIndex = 0;
            this.lblSeller.Text = "Vendedor(1-4)";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(48, 148);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(143, 25);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Productos(1-5)";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(48, 219);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(67, 25);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Monto";
            // 
            // tbSeller
            // 
            this.tbSeller.Location = new System.Drawing.Point(194, 72);
            this.tbSeller.Name = "tbSeller";
            this.tbSeller.Size = new System.Drawing.Size(182, 30);
            this.tbSeller.TabIndex = 3;
            // 
            // tbProducts
            // 
            this.tbProducts.Location = new System.Drawing.Point(194, 148);
            this.tbProducts.Name = "tbProducts";
            this.tbProducts.Size = new System.Drawing.Size(182, 30);
            this.tbProducts.TabIndex = 4;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(121, 219);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(182, 30);
            this.tbAmount.TabIndex = 5;
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(476, 90);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(117, 43);
            this.btnAddSale.TabIndex = 6;
            this.btnAddSale.Text = "Venta";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(476, 183);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(117, 42);
            this.btnShowReport.TabIndex = 7;
            this.btnShowReport.Text = "Reporte";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // lbReport
            // 
            this.lbReport.FormattingEnabled = true;
            this.lbReport.ItemHeight = 25;
            this.lbReport.Location = new System.Drawing.Point(95, 323);
            this.lbReport.Name = "lbReport";
            this.lbReport.Size = new System.Drawing.Size(457, 254);
            this.lbReport.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 646);
            this.Controls.Add(this.lbReport);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbProducts);
            this.Controls.Add(this.tbSeller);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblSeller);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox tbSeller;
        private System.Windows.Forms.TextBox tbProducts;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.ListBox lbReport;
    }
}

