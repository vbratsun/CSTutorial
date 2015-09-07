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
            Batterfly Mahaon = new Batterfly(); //объявление переменной Mahaon типа Batterfly и вызов конструктора объекта

            Mahaon.batterflyName = "Mahaon";
            Mahaon.fly();
            Mahaon.batterflyColor = "White";
            Mahaon.batterflySize = "big one";
            Mahaon.batterflyQuantity = 12;
            

            MyClass instance1 = new MyClass();
            MyClass instance2 = new MyClass();
            MyClass instance3 = new MyClass();

            instance1.field = 1;
            instance2.field = 2;
            
            instance1.Method();
            instance2.Method();
            instance3.MethodS();
        }
    }
}
