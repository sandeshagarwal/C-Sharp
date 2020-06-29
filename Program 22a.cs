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
        public new void  PrintName()
            // This PrintName method hides the PrintName method in Class Employee which is inherited 
            // we can use the new keyword before the return type to hide the method
        {

            Console.WriteLine(FirstName + " " + LastName +" PartTime");
            // If we want to call PrintName method in Class Employee in here we can use base keyword
            base.PrintName();
            
        }
    }

    class Program

    {

        static void Main(string[] args)

        {

            //Console.WriteLine("Hello World!");

            FullTimeEmployee FTE = new FullTimeEmployee();

            FTE.FirstName = "Hi!";

            FTE.LastName = "There";

            FTE.YearlySalary = 50000000;

            FTE.PrintName();

            PartTimeEmployee  PTE = new PartTimeEmployee();

            PTE.FirstName = "Hi!";

            PTE.LastName = "There PTE";
            PTE.PrintName();
            // We can also typecast and convert the ChildClass into ParentClass and call the methods of Parent Class.
            ((Empolyee)PTE).PrintName();
            // One more way to call ParentClass Method using ChildClass when there is similiar name present
            // as child is a specilaization of parent class, we can use object of ChildClass where reference type is Parent
            Empolyee PTE1 = new PartTimeEmployee(); // reference is parent and object is child class but vice-versa is not possible
            PTE1.FirstName = "Hi!";

            PTE1.LastName = "There PTE1";
            PTE1.PrintName();
            Console.ReadLine();

        }

    }

}
