using System;
using System.Collections.Generic;

namespace PracticeNew
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> EmployeeList)
        {
            foreach(Employee e in EmployeeList)
            {
                if (e.Experience >= 5)
                    Console.WriteLine(e.Name + " is promoted ");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<Employee> EmpList = new List<Employee>();
            EmpList.Add(new Employee() { ID = 101, Name = "Harvey", Experience = 7, Salary = 1000000 });
            EmpList.Add(new Employee() { ID = 102, Name = "Sandesh", Experience = 7, Salary = 1000000 });
            EmpList.Add(new Employee() { ID = 103, Name = "Ashter", Experience = 5, Salary = 1000000 });
            EmpList.Add(new Employee() { ID = 104, Name = "Mike", Experience = 1, Salary = 1000000 });

            Employee.PromoteEmployee(EmpList);
            Console.ReadLine();
        }
    }
}
