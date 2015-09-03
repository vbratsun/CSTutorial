//Salary and Bonus
//•	Asks the user to enter a salary
//•	Display their bonus
//o	    If the salary is less than 10000, bonus is 30% of salary
//o	    If salary is greater than 100000 but less than 20000, bonus is 20% of salary
//o	    If salary is greater than 200000 but less than 30000, bonus is 10% of salary
//•	Display their total salary (salary plus bonus)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryAndBonus
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter your salary");
            double salary = Convert.ToDouble(Console.ReadLine());

            if (salary < 10000)
            {
                double bonus = salary*0.3;
                double salarywithbonus = salary + bonus;
                Console.WriteLine("Your salary with bonus included is " + salarywithbonus);
            }

            else
            {
                if ((salary < 20000) || (salary > 100000) && (salary < 200000))
                {
                    double bonus = salary*0.2;
                    double salarywithbonus = salary + bonus;
                    Console.WriteLine("Your salary with bonus included is " + salarywithbonus);
                }

                else
                {
                    if ((salary < 30000) || (salary > 200000))
                    {
                        double bonus = salary * 0.1;
                        double salarywithbonus = salary + bonus;
                        Console.WriteLine("Your salary with bonus included is " + salarywithbonus);
                    }
                }
                
            }




        }
    }
}
