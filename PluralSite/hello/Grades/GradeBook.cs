﻿using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            } 
        }

        public GradeBook(string name = "There is no name")
        {
            _name = name;
            grades = new List<float>();

        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0f;

            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

                sum = sum + grade;
            }
            
            stats.AverageGrade = sum / grades.Count;
            
            return stats;
        }

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    var oldValue = _name;
                    _name = value;
                    if (NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.OldValue = oldValue;
                        args.NewValue = value;
                        NameChanged(this, args);
                    }
                }

            }
        }

        public NamedChangedDelegate NameChanged;

        private List<float> grades;
        
    }
}
