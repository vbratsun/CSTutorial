using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int[] array = {1,2,3,4,5,6,7,9};

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i]+" ");
            }

            Console.WriteLine();

            int summ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                double iC = i % 2;
                
                if (! (iC == 0) )
                {
                    Console.Write(array[i] + " ");
                    summ = summ + array[i];                    
                }
                             
            }
            Console.WriteLine();
            Console.WriteLine(summ);

            foreach (int j in array)
            {
                Console.Write(j + " ");
            }
            
            Console.ReadKey();

        }
    }
}
