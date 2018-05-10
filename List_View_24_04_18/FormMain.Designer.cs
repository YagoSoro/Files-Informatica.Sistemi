namespace List_View_24_04_18
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
            this.listPart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_visual = new System.Windows.Forms.Button();
            this.btn_agg = new System.Windows.Forms.Button();
            this.btn_carica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPart
            // 
            this.listPart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.listPart.GridLines = true;
            this.listPart.Location = new System.Drawing.Point(12, 12);
            this.listPart.Name = "listPart";
            this.listPart.Size = new System.Drawing.Size(456, 198);
            this.listPart.TabIndex = 0;
            this.listPart.UseCompatibleStateImageBehavior = false;
            this.listPart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N.";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "S. Casa";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "S. Ospite";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "GC";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "GO";
            this.columnHeader6.Width = 80;
            // 
            // btn_visual
            // 
            this.btn_visual.Location = new System.Drawing.Point(360, 321);
            this.btn_visual.Name = "btn_visual";
            this.btn_visual.Size = new System.Drawing.Size(95, 30);
            this.btn_visual.TabIndex = 1;
            this.btn_visual.Text = "Visualizza";
            this.btn_visual.UseVisualStyleBackColor = true;
            this.btn_visual.Click += new System.EventHandler(this.btn_visual_Click);
            // 
            // btn_agg
            // 
            this.btn_agg.Location = new System.Drawing.Point(234, 321);
            this.btn_agg.Name = "btn_agg";
            this.btn_agg.Size = new System.Drawing.Size(95, 30);
            this.btn_agg.TabIndex = 2;
            this.btn_agg.Text = "Aggiorna";
            this.btn_agg.UseVisualStyleBackColor = true;
            this.btn_agg.Click += new System.EventHandler(this.btn_agg_Click);
            // 
            // btn_carica
            // 
            this.btn_carica.Location = new System.Drawing.Point(106, 321);
            this.btn_carica.Name = "btn_carica";
            this.btn_carica.Size = new System.Drawing.Size(95, 30);
            this.btn_carica.TabIndex = 3;
            this.btn_carica.Text = "Carica";
            this.btn_carica.UseVisualStyleBackColor = true;
            this.btn_carica.Click += new System.EventHandler(this.btn_carica_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 375);
            this.Controls.Add(this.btn_carica);
            this.Controls.Add(this.btn_agg);
            this.Controls.Add(this.btn_visual);
            this.Controls.Add(this.listPart);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listPart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_visual;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_agg;
        private System.Windows.Forms.Button btn_carica;

    }
}

