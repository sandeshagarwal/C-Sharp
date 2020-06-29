using System;



namespace Practice

{

    class Empolyee

    {

        public string FirstName = "FN";

        public string LastName = "LN";
                
        public virtual void PrintName()

        {

            Console.WriteLine(FirstName + " " + LastName);

        }

    }



    class FullTimeEmployee : Empolyee

    {
        public override void PrintName()
        {

            Console.WriteLine(FirstName + " " + LastName + " FullTime");

        }


    }



    class PartTimeEmployee : Empolyee

    {
        public new void  PrintName()   // here the method is not overriden so, the PrintName() method of emplyee class will be called         
        {

            Console.WriteLine(FirstName + " " + LastName +" PartTime");
            
        }
    }

    class TemporaryEmployee : Empolyee

    {
        public override void PrintName()
        {

            Console.WriteLine(FirstName + " " + LastName + " Temporary");

        }
    }

    class Program

    {

        static void Main(string[] args)

        {
            Empolyee[] emp = new Empolyee[4]; //Creating an Array of Employees
            emp[0] = new Empolyee();
            // here reference is Employee class and objects are of different classes
            //The PrintName() methods in different classes are not called because the reference is employee class
            //To call the methods(not constructors) of different classes we have to override the methods and make Employee class methods as virtual
            emp[1] = new FullTimeEmployee(); // the FullTimeEmployee will be called and PrintName() methods in it is called as it is overidden
            emp[2] = new PartTimeEmployee();
            emp[3] = new TemporaryEmployee();

            TemporaryEmployee temp = new TemporaryEmployee();
            temp.PrintName();

            PartTimeEmployee pte = new PartTimeEmployee();
            pte.PrintName();



            foreach(Empolyee e in emp)
            {
                e.PrintName();
            }
            Console.ReadLine();

        }

    }

}
