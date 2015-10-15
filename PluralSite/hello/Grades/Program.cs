using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void GiveBookAName(ref GradeBook book)
        {
            //book = new GradeBook();
            //book.Name = "The Gradebook";
        }

        static void IncrementNumber(out int number)
        {
            number = 1;
        }

        static void Main(string[] args)
        {
            Arrays();
            
            //Immutable();
            GradeBook book = new GradeBook("Scott's book");
            book.AddGrade(91f);
            book.AddGrade(89.1f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();

            book.NameChanged = new NamedChangedDelegate(OnNameChanged);
            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged2;
            
            book.Name = "Allen's book";
            WriteNames(book.Name);

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.HighestGrade);

            Console.ReadLine();
        }

        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("***");
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("name changed from {0} to {1}",
                args.OldValue, args.NewValue);
        }
                      
        private static void WriteBytes(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteByteArray(bytes);
        }

        private static void WriteByteArray(byte[] bytes)
        {
            foreach (byte b in bytes)
            {
                Console.Write("0x{0:X} ", b);
            }
            Console.WriteLine();
        }

        private static void WriteNames(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        private static void WriteBytes(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteByteArray(bytes);
        }

        private static void Arrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            foreach (float grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        private static void AddGrades(float[] grades)
        {
            if (grades.Length >= 3)
            {
                grades[0] = 91f;
                grades[1] = 89.1f;
                grades[2] = 75f;
            }
        }

        private static void Immutable()
        {
            string name = " Scott ";
            name = name.Trim();

            DateTime date = new DateTime(2014,1,1);
            date = date.AddHours(25);

            Console.WriteLine(date);
            Console.WriteLine(name);

        }

        private static void PassByValueAndRef()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(ref g1);
            Console.WriteLine(g2.Name);

            int x1 = 10;
            IncrementNumber(out x1);
            Console.WriteLine(x1);
        }
    }
}
