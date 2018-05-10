using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_Form1
{
    public delegate void mioHandle();
    public delegate void handleClick();

    public partial class FormDati : Form
    {
        public event mioHandle mi_chiudo;
        public event handleClick button_press;

        public FormDati()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            // Devo recuperare i dati
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Canc_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormDati_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mi_chiudo != null)
                mi_chiudo();
        }

        private void btn_premi_Click(object sender, EventArgs e)
        {
            if (button_press != null)
                button_press();
        }
    }
}
