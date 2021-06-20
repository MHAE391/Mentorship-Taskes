using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.ADD(50);
            student.ADD(55);
            student.ADD(22.5);
            student.ADD(100);
            student.ADD(99.5);
            student.print();

        }
    }
}
