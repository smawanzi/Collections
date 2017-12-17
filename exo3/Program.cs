using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int a,i, note;
            ArrayList al = new ArrayList();
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
            Console.WriteLine("afficher les notes saisit");
            foreach (int e in al)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();

        }
    }
}
