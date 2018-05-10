using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GiornataCamp
{
    public struct squadra
    {
        public string nome;
        public int goal;
    }

    class partite
    {
        public squadra[,] tab;
        public int ne;

        public partite()
        {
            tab = new squadra[10, 2];
            ne = 0;
        }

        public bool carica(string nomefile)
        {
            StreamReader sr = new StreamReader(nomefile);
            string riga;

            while ((riga = sr.ReadLine()) != null)
            {
                string[] pezzi = riga.Split('-');

                tab[ne, 0].nome = pezzi[0];
                tab[ne, 0].goal = 0;

                tab[ne, 1].nome = pezzi[1];
                tab[ne, 1].goal = 0;

                ne++;
            }

            return true;
        }
    }
}
