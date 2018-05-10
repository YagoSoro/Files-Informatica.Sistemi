using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Convertitore__
{
    public partial class Form1 : Form
    {
        const float CONV_ED = 1.24f;
        const float CONV_DE = (1f/1.24f);       

        public Form1()
        {
            InitializeComponent();
        }

        // conversione Euro --> Dollari
        private void btn_Conv_Doll_Click(object sender, EventArgs e)
        {
            float euro = Convert.ToSingle(textEuro.Text);   // legge dalla text box
            float doll = euro * CONV_ED;

            textDoll.Text = doll.ToString("N2");    // scrive il risultato nella text box opposta
        }

        // conversione Dollari --> Euro
        private void btn_Conv_Euro_Click(object sender, EventArgs e)
        {
            float doll = Convert.ToSingle(textDoll.Text);
            float euro = doll * CONV_DE;

            textEuro.Text = euro.ToString("N2");
        }
    }
}
