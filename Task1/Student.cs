using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
	public class Student
	{

		private List <double> grades = new List<double>();
		public void ADD(double grade)
        {
			if (grade >= 0 && grade <= 100) grades.Add(grade);
			else Console.WriteLine("Invalid Grade!!");
        }
        public void print()
        {
            Console.WriteLine($"Min Grade = { grades.Min()}");
            Console.WriteLine($"Max Grade = { grades.Max()}");
            Console.WriteLine($"Grades AVG = { grades.Average()}");

        }

    }
}