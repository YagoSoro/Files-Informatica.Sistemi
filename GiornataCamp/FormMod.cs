using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GiornataCamp
{
    public partial class FormMod : Form
    {
        public int goal_c;
        public int goal_t;

        public FormMod(int c = 0, int t = 0)
        {
            InitializeComponent();

            goal_c = c;
            goal_t = t;

            nu_casa.Value = goal_c;
            nu_trasf.Value = goal_t;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            goal_c = Convert.ToInt32(nu_casa.Value);
            goal_t = Convert.ToInt32(nu_trasf.Value);

            Close();
        }
    }
}
