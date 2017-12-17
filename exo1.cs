using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace collection
{
    class exo1
    {
        static void Main(string[] args)
        {
            ArrayList al;
            al = new ArrayList();
            Console.WriteLine("afficher les 7 valeurs numériques");
            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);
            al.Add(5);
            al.Add(6);
            al.Add(7);
            
            foreach (int a in al)
            {
                Console.WriteLine(a);
            }
            for (int i = 0; i < al.Count; i++)
            {
                al[i] = 0;
            }
            Console.WriteLine("afficher les 7 valeurs remis a 0");
            foreach (var a in al)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
                
    }
}
