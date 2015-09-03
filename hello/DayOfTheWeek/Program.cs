//Day Of the Week
//•	The program finds out the day of the week
//•	If it’s Monday, display “I love Mondays!”
//•	If it’s not, display the day of the week in message “Today is <day of the week>!  I love <day of the week>’s too!”

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program finds out the day of the week");
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);
            string currentDay = DateTime.Now.DayOfWeek.ToString();

            if (currentDay == "Monday")
            {
                Console.WriteLine("I love Mondays!");
            }
            else
            {
                Console.WriteLine("Today is "+currentDay+"! I love "+currentDay+"’s too!");
            }

        }
    }
}
