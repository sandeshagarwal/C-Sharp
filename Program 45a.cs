using System;

namespace PracticeHere
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer
            {
                Name = "Mark",
                Gender = 1
            };
            customers[1] = new Customer
            {
                Name = "Mary",
                Gender = 2
            };
            customers[2] = new Customer
            {
                Name = "Sam",
                Gender = 0
            };
            foreach (Customer c in customers)
            {
                Console.WriteLine("Name = {0}, Gender ={1}", c.Name, GetGender(c.Gender));
            }
            Console.ReadLine();
        }

            public static string GetGender(int gender)
            {
                switch(gender)
                {
                    case 0:
                        return "Unknown";
                    case 1:
                        return "Male";
                    case 2:
                        return "Female";
                    default:
                        return "Invalid Gender";
                }
            }
        
    }

    class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }
}
