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
                Gender = gender.Male
            };
            customers[1] = new Customer
            {
                Name = "Mary",
                Gender = gender.Female
            };
            customers[2] = new Customer
            {
                Name = "Sam",
                Gender = gender.Unknown
            };
            foreach (Customer c in customers)
            {
                Console.WriteLine("Name = {0}, Gender ={1}", c.Name, c.Gender); // Without using GetGender method we can directly use enum
                Console.WriteLine("Name = {0}, Gender ={1}", c.Name, GetGender(c.Gender));// using GetGender method we can use enum case as we have used in case of int 
            }
            Console.ReadLine();
        }

        public static string GetGender(gender gen) // we can use this method to get gender and otherwise 
        {
            switch (gen)
            {
                case gender.Unknown: // gender enum case
                    return "Unknown";
                case gender.Male:
                    return "Male";
                case gender.Female:
                    return "Female";
                default:
                    return "Invalid Gender";
            }
        }

    }

    public enum gender  // created an enum
    {
        Unknown,
        Male,
        Female
    }

    class Customer
    {
        public string Name { get; set; }
        public gender Gender { get; set; } // this is of gender enum type
    }
}
