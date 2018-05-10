namespace ConvertitoreCF
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textFahr = new System.Windows.Forms.TextBox();
            this.textCent = new System.Windows.Forms.TextBox();
            this.btn_Conv_Fahr = new System.Windows.Forms.Button();
            this.btn_Conv_Cent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "°C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "°F";
            // 
            // textFahr
            // 
            this.textFahr.Location = new System.Drawing.Point(27, 53);
            this.textFahr.Name = "textFahr";
            this.textFahr.Size = new System.Drawing.Size(100, 20);
            this.textFahr.TabIndex = 2;
            this.textFahr.Text = "0";
            this.textFahr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textCent
            // 
            this.textCent.Location = new System.Drawing.Point(163, 53);
            this.textCent.Name = "textCent";
            this.textCent.Size = new System.Drawing.Size(100, 20);
            this.textCent.TabIndex = 3;
            this.textCent.Text = "0";
            this.textCent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Conv_Fahr
            // 
            this.btn_Conv_Fahr.Location = new System.Drawing.Point(41, 100);
            this.btn_Conv_Fahr.Name = "btn_Conv_Fahr";
            this.btn_Conv_Fahr.Size = new System.Drawing.Size(75, 24);
            this.btn_Conv_Fahr.TabIndex = 4;
            this.btn_Conv_Fahr.Text = "Converti °F";
            this.btn_Conv_Fahr.UseVisualStyleBackColor = true;
            this.btn_Conv_Fahr.Click += new System.EventHandler(this.btn_Conv_Fahr_Click);
            // 
            // btn_Conv_Cent
            // 
            this.btn_Conv_Cent.Location = new System.Drawing.Point(175, 100);
            this.btn_Conv_Cent.Name = "btn_Conv_Cent";
            this.btn_Conv_Cent.Size = new System.Drawing.Size(75, 24);
            this.btn_Conv_Cent.TabIndex = 5;
            this.btn_Conv_Cent.Text = "Converti °C";
            this.btn_Conv_Cent.UseVisualStyleBackColor = true;
            this.btn_Conv_Cent.Click += new System.EventHandler(this.btn_Conv_Cent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 171);
            this.Controls.Add(this.btn_Conv_Cent);
            this.Controls.Add(this.btn_Conv_Fahr);
            this.Controls.Add(this.textCent);
            this.Controls.Add(this.textFahr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textFahr;
        private System.Windows.Forms.TextBox textCent;
        private System.Windows.Forms.Button btn_Conv_Fahr;
        private System.Windows.Forms.Button btn_Conv_Cent;
    }
}

