namespace List_View_24_04_18
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
            this.label1 = new System.Windows.Forms.Label();
            this.nu_part = new System.Windows.Forms.NumericUpDown();
            this.cb_goal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_agg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nu_part)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Partita N.";
            // 
            // nu_part
            // 
            this.nu_part.Location = new System.Drawing.Point(95, 28);
            this.nu_part.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nu_part.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nu_part.Name = "nu_part";
            this.nu_part.Size = new System.Drawing.Size(67, 20);
            this.nu_part.TabIndex = 1;
            this.nu_part.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nu_part.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_goal
            // 
            this.cb_goal.FormattingEnabled = true;
            this.cb_goal.Items.AddRange(new object[] {
            "Casa",
            "Ospite"});
            this.cb_goal.Location = new System.Drawing.Point(95, 69);
            this.cb_goal.Name = "cb_goal";
            this.cb_goal.Size = new System.Drawing.Size(67, 21);
            this.cb_goal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Partita N.";
            // 
            // btn_agg
            // 
            this.btn_agg.Location = new System.Drawing.Point(60, 167);
            this.btn_agg.Name = "btn_agg";
            this.btn_agg.Size = new System.Drawing.Size(167, 74);
            this.btn_agg.TabIndex = 4;
            this.btn_agg.Text = "&Aggiorna";
            this.btn_agg.UseVisualStyleBackColor = true;
            // 
            // FormAgg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_agg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_goal);
            this.Controls.Add(this.nu_part);
            this.Controls.Add(this.label1);
            this.Name = "FormAgg";
            this.Text = "FormAgg";
            ((System.ComponentModel.ISupportInitialize)(this.nu_part)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nu_part;
        private System.Windows.Forms.ComboBox cb_goal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_agg;
    }
}