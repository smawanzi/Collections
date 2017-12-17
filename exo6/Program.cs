using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            string s,b;
            int a=0;
            int nb;
            int somme=0;
            int i;

            Console.WriteLine("afficher nombre : ");
            s = Console.ReadLine();
            a = Convert.ToInt32(s);

            for (i = 1; i < a + 1; i++)
            {
                Console.WriteLine("saisisser vos notes {0}", i);
                b = Console.ReadLine();
                nb = Convert.ToInt32(b);
                al.Add(nb);
            }

            for (i = 0; i < al.Count; i++)
            {
                somme = somme + (int)al[i];
            }
            Console.WriteLine(somme);
            Console.ReadLine();
        }
    }
}
