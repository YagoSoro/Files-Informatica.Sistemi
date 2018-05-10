namespace Test_Form1
{
    partial class FormDati
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
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Canc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.Cyan;
            this.btn_Ok.Location = new System.Drawing.Point(21, 214);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 32);
            this.btn_Ok.TabIndex = 0;
            this.btn_Ok.Text = "&Ok";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Canc
            // 
            this.btn_Canc.BackColor = System.Drawing.Color.Cyan;
            this.btn_Canc.Location = new System.Drawing.Point(188, 214);
            this.btn_Canc.Name = "btn_Canc";
            this.btn_Canc.Size = new System.Drawing.Size(75, 32);
            this.btn_Canc.TabIndex = 1;
            this.btn_Canc.Text = "&Cancel";
            this.btn_Canc.UseVisualStyleBackColor = false;
            this.btn_Canc.Click += new System.EventHandler(this.btn_Canc_Click);
            // 
            // FormDati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Canc);
            this.Controls.Add(this.btn_Ok);
            this.Name = "FormDati";
            this.Text = "FormDati";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Canc;
    }
}