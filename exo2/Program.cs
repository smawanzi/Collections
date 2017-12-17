using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al;
            al = new ArrayList();
            Console.WriteLine("afficher les voyelles");
            al.Add("a");
            al.Add("e");
            al.Add("y");
            al.Add("u");
            al.Add("i");
            al.Add("o");
            foreach (string s in al)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
