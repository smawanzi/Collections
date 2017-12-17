using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            string s;
            int a, i, note, total=0;
            double moyenne;
            Console.WriteLine("saisir les notes");
            s = Console.ReadLine();
            a = Convert.ToInt32(s);

            for (i = 1; i < a + 1; i++)
            {
                Console.WriteLine("saisisser vos notes {0}", i);
                s = Console.ReadLine();
                note = Convert.ToInt32(s);
                al.Add(note);
            }
            
            for (i = 0; i < al.Count; i++)
			{
                total = total + (int)al[i];
			}
            Console.WriteLine(moyenne = total / al.Count);
            Console.ReadLine();
        }
    }
    
}
