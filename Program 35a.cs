using System;



//namespace Practice

//{

  interface I1
{
    void Print1();
}
interface I2
{
    void Print2();
}
class A : I1 // implementing I1
{
    public void Print1()
    {
        Console.WriteLine("Hey There, keep up the good work!");
    }
}
class B : I2 // implementing I2
{
    public void Print2()
    {
        Console.WriteLine("Show your Results!");
    }
}
class AB : I1, I2 // Inheriting the classes A and B with implementing I1 and I2
{
    A a = new A();
    B b = new B();
    public void Print1()
    {
        a.Print1();
    }
    public void Print2()
    {
        b.Print2();
    }
}
class Program : AB

    {
       
       
        public static void Main(string[] args)

        {
        Program p = new Program();
        p.Print1(); // This is possible because the class Program is inherting from class AB
        p.Print2();

        AB ab = new AB();
        ab.Print1();
        ab.Print2();
        Console.ReadLine();

        }

    }

//}
