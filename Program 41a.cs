using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Divide program
            try
            {
                Console.WriteLine("Enter the First Number");
                int FN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Second Number");
                int SN = Convert.ToInt32(Console.ReadLine());
                try
                {
                    int Result = FN / SN;
                    Console.WriteLine("The Result is {0}", Result);
                }
                catch (Exception ex)
                {
                    string path = @"C:\Users\BE2094\Documents\new4.txt";
                    if (File.Exists(path))
                    {
                        StreamWriter sw = new StreamWriter(path);
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine(ex.GetType().Name);
                        Console.WriteLine(ex.Message);
                    }
                    else
                    {
                        throw new FileNotFoundException(path + " is not present", ex); //Passing Original(Inner) exception as parameter to the constructor
                    }                                                                   // of Current Exception(FileNotFoundException)
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType().Name);
                if (e.InnerException != null) 
                {
                    Console.WriteLine(e.InnerException.Message); // The InnerException should not be Null otherwise it will show another exception as "NullReferenceException"
                    Console.WriteLine(e.InnerException.GetType().Name);
                }
            }
            

            Console.ReadLine();
        }
    
   
    }
}
