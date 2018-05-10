namespace GiornataCamp
{
    partial class FormMod
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.nu_casa = new System.Windows.Forms.NumericUpDown();
            this.nu_trasf = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nu_casa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_trasf)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(159, 45);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(95, 20);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // nu_casa
            // 
            this.nu_casa.Location = new System.Drawing.Point(21, 45);
            this.nu_casa.Name = "nu_casa";
            this.nu_casa.Size = new System.Drawing.Size(50, 20);
            this.nu_casa.TabIndex = 1;
            // 
            // nu_trasf
            // 
            this.nu_trasf.Location = new System.Drawing.Point(92, 45);
            this.nu_trasf.Name = "nu_trasf";
            this.nu_trasf.Size = new System.Drawing.Size(50, 20);
            this.nu_trasf.TabIndex = 2;
            // 
            // FormMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 102);
            this.Controls.Add(this.nu_trasf);
            this.Controls.Add(this.nu_casa);
            this.Controls.Add(this.btn_ok);
            this.Name = "FormMod";
            this.Text = "FormMod";
            ((System.ComponentModel.ISupportInitialize)(this.nu_casa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_trasf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.NumericUpDown nu_casa;
        private System.Windows.Forms.NumericUpDown nu_trasf;
    }
}