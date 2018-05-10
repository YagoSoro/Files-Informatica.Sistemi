using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace List_View_24_04_18
{
    public partial class FormMain : Form
    {
        FormAgg fg;

        struct Squadra
        {
            string nome;
            int goal;
        };    

        public FormMain()
        {
            InitializeComponent();  // costruttore che inizializza gli eventi
        }

        private void btn_visual_Click(object sender, EventArgs e)
        {
            visualizza();   // chiamata della funzione visualizza quando il bottone visualizza viene clickato
        }

        void visualizza()   // funzione visualizza per riempimento della tabella con nomi quadre e goal
        {
            listPart.Items.Clear();
            ListViewItem item;

            for (int i = 0; i < 10; i++)    // ciclo per il riempimento della tabella
            {
                item = new ListViewItem((i + 1).ToString());
                
                item.SubItems.Add("Squadra C" + (i + 1).ToString());
                item.SubItems.Add("Squadra O" + (i + 1).ToString());
                item.SubItems.Add("0");
                item.SubItems.Add("0");
                
                listPart.Items.Add(item);
            }
        }

        private void btn_agg_Click(object sender, EventArgs e)  // funzione di gestione dell bottone aggiona nel formmain
        {
            if (fg == null)
            {
                fg = new FormAgg(); 
                // ...
            }

            fg.Show(); // Visualizzazione della FormAgg, che aggiorna la tabella
        }

        private void btn_carica_Click(object sender, EventArgs e)
        {
            carica("campionato.txt");
        }

        StreamReader sr = new StreamReader("campionato.txt");

        void carica(string nomefile)
        {
            for (int i = 0; i < 10; i++)
            {
                sr.ReadLine();
            }
        }
    }
}
