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
    public partial class FormMain : Form
    {
        partite gior = new partite();
        FormAgg fg = null;

        public FormMain()
        {
            InitializeComponent();
            gior.carica("partite.txt");
            visualizza();
        }

        void visualizza()
        {
            list_par.Items.Clear();
            ListViewItem x;

            for (int i = 0; i < gior.ne; i++)
            {
                x = new ListViewItem((i+1).ToString());

                x.SubItems.Add(gior.tab[i, 0].nome);
                x.SubItems.Add(gior.tab[i, 1].nome);
                x.SubItems.Add(gior.tab[i, 0].goal.ToString());
                x.SubItems.Add(gior.tab[i, 1].goal.ToString());

                list_par.Items.Add(x);
            }
        }

        // funzione delegato alla gestione dell'evento click
        private void menu_agg_Click(object sender, EventArgs e)
        {
            if (gior.ne == 0)
            {
                MessageBox.Show("Partite non caricate", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fg == null)
            {
                fg = new FormAgg();
                fg.risCambiato += aggPartite;
            }

            fg.Show();
        }

        void aggPartite(int r, int c)
        {
            gior.tab[r, c].goal++;
            visualizza();
            
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            if (list_par.SelectedIndices.Count == 0)
            {
                return;
            }

            int riga = list_par.SelectedIndices[0];
            FormMod fm = new FormMod(gior.tab[riga, 0].goal, gior.tab[riga, 1].goal);
            fm.ShowDialog();
            
            gior.tab[riga, 0].goal = fm.goal_c;
            gior.tab[riga, 1].goal = fm.goal_t;

            visualizza();

            list_par.SelectedIndices.Clear();
        }
    }
}
