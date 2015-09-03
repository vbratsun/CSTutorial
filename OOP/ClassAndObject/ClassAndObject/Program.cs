using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    //объект
    class Program
    {
        static void Main(string[] args)
        {
            Batterfly Mahaon = new Batterfly();
            Mahaon.batterflyName = "Mahaon";
            Mahaon.fly();
            Mahaon.batterflyColor = "White";
            Mahaon.batterflySize = "big one";
            Mahaon.batterflyQuantity = 12;
            Console.ReadKey();
        }
    }
}
