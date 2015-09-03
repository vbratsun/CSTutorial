//Calculator Program
//•	Asks the user to enter numbers
//•	Adds the numbers together
//•	Displays the result

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program adds 2 numbers");
            Console.WriteLine("Insert first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert second number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int summ = number1 + number2;
            Console.WriteLine("your result is " + summ);
        }
    }
}
