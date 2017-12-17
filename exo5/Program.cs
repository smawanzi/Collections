using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            int i = 0,a;
            int negative;
            int positive;
            Console.WriteLine("afficher nombre : ");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("saisir le nombre",i,al.Count);
                 a = Convert.ToInt32(Console.ReadLine());
                 al.Add(a);
            }            
            
            for (i = 0; i < al.Count; i++)
            {
                if ((int)al[i] <= 0)
                {
                    negative = i - 1;
                    Console.WriteLine("Le nombre de valeur est négative");
                }
                else
                {
                    positive = i + 1;
                    Console.WriteLine("Le nombre de valeur est positive");
                }
            }
            Console.ReadLine();
        }
    }
}
