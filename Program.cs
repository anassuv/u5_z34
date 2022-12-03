using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 345, 897, 568, 234 };
            int k = 0;

            Console.Write("\n[");
            for (int i = 0; i < a.Length; i++)
            {
                if (i < a.Length - 1)
                    Console.Write("{0}, ", a[i]);
                else
                    Console.Write("{0}", a[i]);
                if (a[i] % 2 == 0) k++;
            }
            Console.WriteLine("] -> {0}", k);            

            Console.ReadKey();
        }
    }
}
