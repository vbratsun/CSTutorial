using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class MyClass
    {
        public int field;
        static public int fieldS;

        public void Method()
        {
            Console.WriteLine(field);
        }

        public void MethodS()
        {
            Console.WriteLine(fieldS);            
        }
    }
}
