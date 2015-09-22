using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;
            short b = 256;
            double c = 0;

            Console.WriteLine(a);
            Console.WriteLine(b);
            
            if (a>0)
            {
                c = a + b;
            }
            Console.WriteLine(c);

            
            Console.ReadKey();
        }
    }
}
