using System;



//namespace Practice

//{

  abstract class Customer
{
    public abstract void Print(); // abstract member
    public void Hello() // non-abstract member
    {
        Console.WriteLine("Hi! There, thanks for learning :)");
    }
}
    class Program : Customer 

    {
        public override void Print() //abstract member Implementation
        {
        Console.WriteLine("Print Method");
        }
       
        public static void Main(string[] args)

        {
        Program p = new Program();
        Customer c = new Program(); // creating a reference of base abstract class with object of derived class
        p.Print();
        p.Hello();
        c.Print();
        c.Hello();
        Console.ReadLine();

        }

    }

//}
