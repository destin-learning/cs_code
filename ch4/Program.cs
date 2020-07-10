using System;

namespace ch4
{
    // this is chapter 6
    class Program
    {
        static void Main(string[] args)
        {
             // 6.1 add in a string variable for your name
            String myName;
 
            // 6.2 prompt to enter in your name
            System.Console.WriteLine("Please Enter Your Name:");
 
            // 6.3 now read in your name 
            myName = Console.ReadLine();
 
            // 6.4 add in + myName to print out your name
            System.Console.WriteLine("Hello World My Name is:"+myName);

        }
    }
}
