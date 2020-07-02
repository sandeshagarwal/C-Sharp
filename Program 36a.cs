using System;



//namespace Practice

//{

public delegate void DelegatePrint(string Msg);

class Program

    {
        public  void Print(string Message)
        {
        Console.WriteLine(Message);
        }
       
        public static void Main(string[] args)

        {
        Program p = new Program(); // We can define the function as static so that we don't have to call the function via an object.
        DelegatePrint del = new DelegatePrint(p.Print);// new DelegatePrint(Print)
        del("Keep up the Good work, kudos to you!");
         // A delegate is a safe function pointer
        Console.ReadLine();

        }

    }

//}
