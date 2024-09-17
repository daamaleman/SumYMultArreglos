namespace Ejercicio4
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
            this.lblSales = new System.Windows.Forms.Label();
            this.tbSales = new System.Windows.Forms.TextBox();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.lbReport = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(49, 82);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(141, 25);
            this.lblSales.TabIndex = 0;
            this.lblSales.Text = "Ventas Brutas:";
            // 
            // tbSales
            // 
            this.tbSales.Location = new System.Drawing.Point(202, 83);
            this.tbSales.Name = "tbSales";
            this.tbSales.Size = new System.Drawing.Size(197, 30);
            this.tbSales.TabIndex = 1;
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(87, 181);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(105, 61);
            this.btnAddSale.TabIndex = 2;
            this.btnAddSale.Text = "Venta";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(306, 181);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(105, 61);
            this.btnShowReport.TabIndex = 3;
            this.btnShowReport.Text = "Reporte";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // lbReport
            // 
            this.lbReport.FormattingEnabled = true;
            this.lbReport.ItemHeight = 25;
            this.lbReport.Location = new System.Drawing.Point(54, 302);
            this.lbReport.Name = "lbReport";
            this.lbReport.Size = new System.Drawing.Size(389, 254);
            this.lbReport.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 703);
            this.Controls.Add(this.lbReport);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.tbSales);
            this.Controls.Add(this.lblSales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Salarios de Vendedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.TextBox tbSales;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.ListBox lbReport;
    }
}

