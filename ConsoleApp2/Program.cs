using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int i = 10;
                int k = 6;

                int *ptr = &k;
                int *ptr2 = &i;

                int* q = ptr;
                *q = 5;

                Console.WriteLine(*ptr * *ptr2);
                Console.WriteLine((int)ptr); 
                Console.WriteLine((int)ptr2);
                Console.WriteLine((int)q);
            }
            Console.ReadKey();
        }
    }
}
