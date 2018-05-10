using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_compito
{
    class Program
    {
        static void Main()
        {
            Compl p1 = new Compl(4, 2);
            Compl p2 = new Compl(3, 5);
            Compl p3 = new Compl();

            p3 = p1 + p2;
            p3 = p1 * p2;

            Console.WriteLine("p3 = {0}", p3.Get());
            Console.ReadKey();
        }
    }   
}
