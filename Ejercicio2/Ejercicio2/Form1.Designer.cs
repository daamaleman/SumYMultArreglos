namespace Ejercicio2
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbSmoke = new System.Windows.Forms.RadioButton();
            this.rdbNoSmoke = new System.Windows.Forms.RadioButton();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lblApproach = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elegir asiento:";
            // 
            // rdbSmoke
            // 
            this.rdbSmoke.AutoSize = true;
            this.rdbSmoke.Location = new System.Drawing.Point(115, 127);
            this.rdbSmoke.Name = "rdbSmoke";
            this.rdbSmoke.Size = new System.Drawing.Size(66, 20);
            this.rdbSmoke.TabIndex = 1;
            this.rdbSmoke.TabStop = true;
            this.rdbSmoke.Text = "Fumar";
            this.rdbSmoke.UseVisualStyleBackColor = true;
            // 
            // rdbNoSmoke
            // 
            this.rdbNoSmoke.AutoSize = true;
            this.rdbNoSmoke.Location = new System.Drawing.Point(115, 164);
            this.rdbNoSmoke.Name = "rdbNoSmoke";
            this.rdbNoSmoke.Size = new System.Drawing.Size(87, 20);
            this.rdbNoSmoke.TabIndex = 2;
            this.rdbNoSmoke.TabStop = true;
            this.rdbNoSmoke.Text = "No Fumar";
            this.rdbNoSmoke.UseVisualStyleBackColor = true;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(102, 222);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(130, 43);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "Elegir:";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lblApproach
            // 
            this.lblApproach.AutoSize = true;
            this.lblApproach.Location = new System.Drawing.Point(137, 287);
            this.lblApproach.Name = "lblApproach";
            this.lblApproach.Size = new System.Drawing.Size(0, 20);
            this.lblApproach.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 412);
            this.Controls.Add(this.lblApproach);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.rdbNoSmoke);
            this.Controls.Add(this.rdbSmoke);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Elegir Asiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbSmoke;
        private System.Windows.Forms.RadioButton rdbNoSmoke;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label lblApproach;
    }
}

