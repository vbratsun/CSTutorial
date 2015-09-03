using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            
            Console.WriteLine("How much you sleep?");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name);

            if (hoursOfSleep < 8)
            {
                Console.WriteLine("you should sleep more");
            }
            else
            {
                Console.WriteLine("you sleep enough");
            }
        }
    }
}
