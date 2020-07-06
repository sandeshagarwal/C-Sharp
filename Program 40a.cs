
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
            StreamReader strRdr = null;
            try
            {
                strRdr = new StreamReader(@"C:\Users\BE2094\Documents\testFile1.txt"); // Reads the text file present in System.IO class
                Console.WriteLine(strRdr.ReadToEnd()); // It will read till the end
                
                
            }
            catch(FileNotFoundException ex) // Creating an object of Exception class, we can also use Exception class
            {
                Console.WriteLine("Please check if the file {0} exists", ex.FileName);
                
             
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message); // Prints the message
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if(strRdr != null) // if strRdr is not null, then only we can close it, otherwise we will get an exception
                {
                    strRdr.Close(); // free the memory assigned to the StreamReader
                }
                Console.WriteLine("Executed the finally block");
            }
            Console.ReadLine();
        }
    
   
    }
}
