using System;

namespace Practice
{
    class ParentClass
    {

        public ParentClass()
        {
            Console.WriteLine("Parent class constructor called");
        }

        // overloading the constructor

        public ParentClass(string Message)
        {
            Console.WriteLine(Message);
        }
    }

    class ChildClass : ParentClass
    {
        // We can overload the parentclass constructor and call the constructor with parameter using the "base" keyword
        // When base keyword does not have any parameter it will call the default constructor in parent class else
        // If it has any parameter than it will overload the default connstructor
            public ChildClass() : base("hello there!")
            {
                Console.WriteLine("Child class constructor called");
            }
        
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            
            
            // Making an object of child class.
            ChildClass c = new ChildClass();
            Console.ReadLine();
        }
    }
}
