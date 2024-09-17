namespace Ejercicio1
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
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.lbSums = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Location = new System.Drawing.Point(65, 94);
            this.lblDie1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(101, 31);
            this.lblDie1.TabIndex = 0;
            this.lblDie1.Text = "Dado 1:";
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.Location = new System.Drawing.Point(65, 157);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(101, 31);
            this.lblDie2.TabIndex = 1;
            this.lblDie2.Text = "Dado 2:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(239, 128);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(110, 25);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Resultado: ";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(445, 116);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(157, 48);
            this.btnLaunch.TabIndex = 3;
            this.btnLaunch.Text = "Lanzar";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSums
            // 
            this.lbSums.FormattingEnabled = true;
            this.lbSums.ItemHeight = 25;
            this.lbSums.Location = new System.Drawing.Point(121, 290);
            this.lbSums.Name = "lbSums";
            this.lbSums.Size = new System.Drawing.Size(426, 229);
            this.lbSums.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 674);
            this.Controls.Add(this.lbSums);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDie2);
            this.Controls.Add(this.lblDie1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Dados ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDie1;
        private System.Windows.Forms.Label lblDie2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ListBox lbSums;
    }
}

