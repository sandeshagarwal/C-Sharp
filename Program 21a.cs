using System;

namespace Practice
{
    class Empolyee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    class FullTimeEmployee : Empolyee
    {
        public int YearlySalary;
    }

    class PartTimeEmployee : Empolyee
    {
        int  HourlySalary;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Hi!";
            FTE.LastName = "There";
            FTE.YearlySalary = 50000000;
            FTE.PrintName();
            Console.ReadLine();
        }
    }
}
