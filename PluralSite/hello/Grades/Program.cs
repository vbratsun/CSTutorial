﻿using System;
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
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(ref g1);
            Console.WriteLine(g2.Name);

            int x1 = 10;
            IncrementNumber(out x1);
            Console.WriteLine(x1);

            //GradeBook book = new GradeBook();
            //book.AddGrade(91f);
            //book.AddGrade(89.1f);
            //book.AddGrade(75f);
            
            //GradeStatistics stats = book.ComputeStatistics();
                        
            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.LowestGrade);
            //Console.WriteLine(stats.HighestGrade);

            Console.ReadLine();
        }
    }
}
