using System;
using System.IO;
using System.Text;

namespace gara_tuffi_csh
{
    public class classifica
    {
        public const int DIM = 100;
        public const string nome_f = "Concorrente.txt";

        // attributi
        public concorrente[] tab;
        public int ne;

        // costruttore
        public classifica()
        {
            tab = new concorrente[DIM];
            ne = 0;
        }

        // funzione carica
        public bool carica()
        {
            if (File.Exists(nome_f) == false)
                return false;

            StreamReader sr = new StreamReader(nome_f);
            concorrente x;
            string riga;

            while ((riga = sr.ReadLine()) != null)
            {
                string[] comp = riga.Split('\t');
                x.nome = comp[0];
                x.naz = comp[1];
                x.punti = 0;
                aggiungi(x);
            }

            sr.Close();

            return true;
        }

        public bool aggiungi(concorrente x)
        {
            if (ne >= DIM)
                return false;

            tab[ne] = x;
            ne++;
            return true;
        }
    }
}
