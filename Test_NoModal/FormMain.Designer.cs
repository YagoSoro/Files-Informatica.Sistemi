namespace Test_Form1
{
    partial class FormMain
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
            this.btn_Apri = new System.Windows.Forms.Button();
            this.text_num = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Apri
            // 
            this.btn_Apri.BackColor = System.Drawing.Color.Cyan;
            this.btn_Apri.Location = new System.Drawing.Point(187, 211);
            this.btn_Apri.Name = "btn_Apri";
            this.btn_Apri.Size = new System.Drawing.Size(75, 30);
            this.btn_Apri.TabIndex = 0;
            this.btn_Apri.Text = "Apri";
            this.btn_Apri.UseVisualStyleBackColor = false;
            this.btn_Apri.Click += new System.EventHandler(this.btn_Apri_Click);
            // 
            // text_num
            // 
            this.text_num.Location = new System.Drawing.Point(43, 59);
            this.text_num.Name = "text_num";
            this.text_num.Size = new System.Drawing.Size(61, 20);
            this.text_num.TabIndex = 1;
            this.text_num.Text = "0";
            this.text_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.text_num);
            this.Controls.Add(this.btn_Apri);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Apri;
        private System.Windows.Forms.TextBox text_num;
    }
}

