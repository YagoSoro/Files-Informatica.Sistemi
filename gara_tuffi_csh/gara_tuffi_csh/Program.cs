using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gara_tuffi_csh
{
    class Program
    {
        const int n_tuffi = 2;

        static classifica c = new classifica();
        static giudici g = new giudici();

        static void Main(string[] args)
        {
            concorrente x;
            char ch;

            if (c.carica() == false)
            {
                Console.WriteLine("File concorrenti mancante");
                Console.ReadKey();
                return;
            }

            // menu
            do
            {
                Console.Clear();
                Console.WriteLine("[1] : Svolgimento della gara");
                Console.WriteLine("[2] : Visualizzazione classifica finale");
                Console.WriteLine("[*] : Fine");
                Console.WriteLine("A te la scelta: ");
                ch = Console.ReadKey().KeyChar;

                switch (ch)
                {
                    case '1':
                        gara();
                        break;

                    case '2':
                        break;
                }

            } while (ch != '*');
        }

        // svolgimento della gara
        static void gara()
        {
            for (int i = 0; i < n_tuffi; i++)
            {
                Console.Clear();
                Console.WriteLine("{0} {1}", c.tab[i].nome, c.tab[i].naz);
                Console.WriteLine("Punteggi: ");
                for (int k = 0; k < 6; k++)
                {
                    int v;

                    do
                    {
                        v = Convert.ToInt32(Console.ReadLine());

                    } while (v < 0 || v > 10);

                    g.set(k, v);
                }

                c.tab[i].punti += g.getVoto();
            }
        }
    }
}
