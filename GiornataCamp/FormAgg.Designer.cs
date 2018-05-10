namespace GiornataCamp
{
    partial class FormAgg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_partita = new System.Windows.Forms.Label();
            this.nu_partite = new System.Windows.Forms.NumericUpDown();
            this.btn_goalc = new System.Windows.Forms.Button();
            this.btn_goalt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nu_partite)).BeginInit();
            this.SuspendLayout();
            // 
            // label_partita
            // 
            this.label_partita.AutoSize = true;
            this.label_partita.Location = new System.Drawing.Point(81, 72);
            this.label_partita.Name = "label_partita";
            this.label_partita.Size = new System.Drawing.Size(37, 13);
            this.label_partita.TabIndex = 0;
            this.label_partita.Text = "Partita";
            // 
            // nu_partite
            // 
            this.nu_partite.Location = new System.Drawing.Point(135, 70);
            this.nu_partite.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nu_partite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nu_partite.Name = "nu_partite";
            this.nu_partite.Size = new System.Drawing.Size(71, 20);
            this.nu_partite.TabIndex = 1;
            this.nu_partite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nu_partite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_goalc
            // 
            this.btn_goalc.Location = new System.Drawing.Point(28, 123);
            this.btn_goalc.Name = "btn_goalc";
            this.btn_goalc.Size = new System.Drawing.Size(90, 37);
            this.btn_goalc.TabIndex = 2;
            this.btn_goalc.Text = "Goal Casa";
            this.btn_goalc.UseVisualStyleBackColor = true;
            this.btn_goalc.Click += new System.EventHandler(this.btn_goalc_Click);
            // 
            // btn_goalt
            // 
            this.btn_goalt.Location = new System.Drawing.Point(173, 123);
            this.btn_goalt.Name = "btn_goalt";
            this.btn_goalt.Size = new System.Drawing.Size(90, 37);
            this.btn_goalt.TabIndex = 3;
            this.btn_goalt.Text = "Goal Trasferta";
            this.btn_goalt.UseVisualStyleBackColor = true;
            this.btn_goalt.Click += new System.EventHandler(this.btn_goalt_Click);
            // 
            // FormAgg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_goalt);
            this.Controls.Add(this.btn_goalc);
            this.Controls.Add(this.nu_partite);
            this.Controls.Add(this.label_partita);
            this.Name = "FormAgg";
            this.Text = "FormAgg";
            ((System.ComponentModel.ISupportInitialize)(this.nu_partite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_partita;
        private System.Windows.Forms.NumericUpDown nu_partite;
        private System.Windows.Forms.Button btn_goalc;
        private System.Windows.Forms.Button btn_goalt;
    }
}