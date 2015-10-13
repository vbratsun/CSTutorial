using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicPrivateDif
{
    class MyClass
    {
        private string field = null;

        public void SetField(string value)//setter
        {
            field=value;
        }
        
        public string GetField()//getted
        {
            return field;
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance.SetField("Hello World");

            string @field = instance.GetField();
            Console.WriteLine(@field);
            Console.ReadLine();
        }
    }
}
