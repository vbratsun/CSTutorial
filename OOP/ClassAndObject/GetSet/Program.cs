using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class MyClass
    {
        private string field = null;

        public string Field
        {
            set
            {
                field = value;
            }
            
            get
            {
                return field;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance.Field = "Hello World Set";
            Console.WriteLine(instance.Field);
            
            Console.ReadLine();
        }
    }
}
