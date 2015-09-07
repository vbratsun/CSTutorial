using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Batterfly
    {
        //поля(переменная) класса
        public string batterflyName;
        public string batterflyColor;
        public string batterflySize;
        public int batterflyQuantity;


        //методы класса 
        public void fly()
        {
            int i = 0; //переменные внутри методов классов - локальные переменные
            for (i = 0; i < 10; i++)
                Console.WriteLine("Fly"+i);
        }

        public void eat()
        {
            Console.WriteLine("eating now");
        }
    }
}
