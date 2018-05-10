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
    public partial class FormMain : Form
    {
        FormDati fd;
        int n = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_Apri_Click(object sender, EventArgs e)
        {
            if (fd == null)
            {
                fd = new FormDati();
                fd.mi_chiudo += gestioneChiusura;
                fd.button_press += btnPremuto;
            }

            fd.Show();
        }

        void gestioneChiusura()
        {
            fd = null;
        }

        void btnPremuto()
        {
            n++;
            text_num.Text = n.ToString();
        }
    }
}
