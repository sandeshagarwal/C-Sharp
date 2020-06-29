using System;



namespace Practice

{

    
    class Program

    {
        int a;
        int b;
        static void Sum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }
        public static void Sum(int a, int b,out int sum) // using out paramater for returning the sum
        {
             sum = a + b;
            
        }

        public static void Main(string[] args)

        {
            int sum = 0;// we have to initialize the variable sum to zero and call it in sum's place in Sum() method
            Sum(20, 19);
            Sum(10, 12, out sum);
            Console.WriteLine("Sum is ={0}", sum);
            int add = 0; // we have to initialize the variable add to zero and call it in sum's place
            //Sum(20, 19);
            Sum(10, 22, out add);
            Console.WriteLine("Sum is ={0}", add);
            Console.ReadLine();

        }

    }

}
