using System;

namespace _20201104student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            Console.WriteLine("Enter your name :" );
            s.Name = Console.ReadLine();
            Console.WriteLine("Enter your grade  :");
            s.Grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Student ID :");
            s.StudentID =Console.ReadLine();

            Console.WriteLine(s.Say());
        }
    }
}
