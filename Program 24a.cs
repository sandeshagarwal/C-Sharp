using System;



namespace Practice

{

    class BaseClass
    {
        public virtual void PrintMethod()
        {
            Console.WriteLine("Hello I'm a method of Baseclass");
        }

    }

    class DerivedClass : BaseClass
    {
        public override void PrintMethod()
        {
            Console.WriteLine("Hello I'm a method of Derivedclass");
        }

    }

    class Program

    {

        static void Main(string[] args)

        {
            BaseClass bs = new DerivedClass();
            bs.PrintMethod();
            Console.ReadLine();

        }

    }

}
