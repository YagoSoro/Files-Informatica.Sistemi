using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConvertitoreCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // conversione da celsius a fahrenheit
        private void btn_Conv_Fahr_Click(object sender, EventArgs e)
        {
            float cels = Convert.ToSingle(textCent.Text);
            float fahr = (cels * 1.8f) + 32f;

            textCent.Text = fahr.ToString("0.0");
        }

        // conversione da fahrenheit a celsius
        private void btn_Conv_Cent_Click(object sender, EventArgs e)
        {
            float fahr = Convert.ToSingle(textFahr.Text);
            float cels = (fahr - 32f) / 1.8f;

            textFahr.Text = cels.ToString("0.0");
        }
    }
}