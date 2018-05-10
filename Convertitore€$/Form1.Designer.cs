namespace Convertitore__
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
            this.textEuro = new System.Windows.Forms.TextBox();
            this.textDoll = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Conv_Doll = new System.Windows.Forms.Button();
            this.btn_Conv_Euro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textEuro
            // 
            this.textEuro.Location = new System.Drawing.Point(46, 58);
            this.textEuro.Name = "textEuro";
            this.textEuro.Size = new System.Drawing.Size(100, 20);
            this.textEuro.TabIndex = 0;
            this.textEuro.Text = "0";
            this.textEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textDoll
            // 
            this.textDoll.Location = new System.Drawing.Point(179, 58);
            this.textDoll.Name = "textDoll";
            this.textDoll.Size = new System.Drawing.Size(100, 20);
            this.textDoll.TabIndex = 1;
            this.textDoll.Text = "0";
            this.textDoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dollari";
            // 
            // btn_Conv_Doll
            // 
            this.btn_Conv_Doll.Location = new System.Drawing.Point(60, 126);
            this.btn_Conv_Doll.Name = "btn_Conv_Doll";
            this.btn_Conv_Doll.Size = new System.Drawing.Size(75, 23);
            this.btn_Conv_Doll.TabIndex = 4;
            this.btn_Conv_Doll.Text = "Converti";
            this.btn_Conv_Doll.UseVisualStyleBackColor = true;
            this.btn_Conv_Doll.Click += new System.EventHandler(this.btn_Conv_Doll_Click);
            // 
            // btn_Conv_Euro
            // 
            this.btn_Conv_Euro.Location = new System.Drawing.Point(192, 126);
            this.btn_Conv_Euro.Name = "btn_Conv_Euro";
            this.btn_Conv_Euro.Size = new System.Drawing.Size(75, 23);
            this.btn_Conv_Euro.TabIndex = 5;
            this.btn_Conv_Euro.Text = "Converti";
            this.btn_Conv_Euro.UseVisualStyleBackColor = true;
            this.btn_Conv_Euro.Click += new System.EventHandler(this.btn_Conv_Euro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 201);
            this.Controls.Add(this.btn_Conv_Euro);
            this.Controls.Add(this.btn_Conv_Doll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDoll);
            this.Controls.Add(this.textEuro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEuro;
        private System.Windows.Forms.TextBox textDoll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Conv_Doll;
        private System.Windows.Forms.Button btn_Conv_Euro;
    }
}

