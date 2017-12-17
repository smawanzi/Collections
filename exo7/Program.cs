using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace exo7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList col1 = new ArrayList();
            ArrayList col2 = new ArrayList();
            string s;
            int a = 0;/*b;
            int a = 0;
            int nb;
            int somme = 0;*/
            /*int i;*/

            Console.WriteLine("afficher les tableaux de collection : ");
            s = Console.ReadLine();
            a = Convert.ToInt32(s);

            foreach (int e in col1)
            {
                Console.WriteLine(e);
            }

            foreach (int f in col2)
            {
                Console.WriteLine(f);
            }
            Console.ReadLine();

            //for (i = 1; i < a + 1; i++)
            /*{
                Console.WriteLine("saisisser vos notes {0}", i);
                b = Console.ReadLine();
                nb = Convert.ToInt32(b);
                col1.Add(nb);
            }

            for (i = 0; i < al.Count; i++)
            {
                somme = col1 + col2;
            }
            Console.WriteLine(somme);
            Console.ReadLine();*/
        }
    }
}
