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
    // delegato alla gestione dell'evento cambio risultato
    public delegate void cambioRis(int part, int sqad);

    public partial class FormAgg : Form
    {
        int par;
        int sq;

        // crea un nuovo evento
        public event cambioRis risCambiato;

        public FormAgg()
        {
            InitializeComponent();
        }

        private void btn_goalc_Click(object sender, EventArgs e)
        {
            sq = 0;
            avvertiMod();
        }

        private void btn_goalt_Click(object sender, EventArgs e)
        {
            sq = 1;
            avvertiMod();
        }

        void avvertiMod()
        {
            par = Convert.ToInt32(nu_partite.Value);

            if (risCambiato != null)
            {
                risCambiato(par-1, sq);
            }
        }
    }
}
