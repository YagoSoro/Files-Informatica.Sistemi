using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_compito
{
    public class Compl
    {
        // attributi
        float re;
        float im;
        string s;

        // costruttore
        public Compl(float r = 0, float i = 0)
        {
            re = r;
            im = i;
        }

        public string Get()
        {
            if (im > 0)
                s = String.Format("{0} + i{1}", re, im);
            else
                s = String.Format("{0} - i{1}", re, -im);

            return s;
        }

        // somma
        public static Compl operator +(Compl p1, Compl p2)
        {
            Compl p3 = new Compl();

            p3.re = p1.re + p2.re;
            p3.im = p1.im + p2.im;

            return p3;
        }

        public static Compl operator *(Compl p1, Compl p2)
        {
            Compl p3 = new Compl();

            p3.re = p1.re * p2.re - p1.im * p2.im;
            p3.im = p1.re * p2.im + p1.im * p2.re;

            return p3;
        }
    }
}
