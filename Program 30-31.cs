using System;



//namespace Practice

//{

  interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}
    class Program : I1 , I2 

    {
        public void InterfaceMethod() //default Interface Implementation
        {
        Console.WriteLine("Hello I1");
        }
        void I2.InterfaceMethod() //Explicit Interface Implementation
        {
        Console.WriteLine("Hello I2"); 
        }
        public static void Main(string[] args)

        {
        Program p = new Program();
        p.InterfaceMethod(); //default Interface calling
        ((I2)p).InterfaceMethod(); //Explicit Interface calling
        // we can also call the default interface using the below
        I2 i = new Program();
        i.InterfaceMethod();
        Console.ReadLine();

        }

    }

//}
