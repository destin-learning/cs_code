using System;

namespace ch4
{
    // this is chapter 7
    class Program
    {
        static void Main(string[] args)
        {
            // 7.1 add in a string variable for your name
            String myName = getName();
 
            // 7.4 add in + myName to print out your name
            System.Console.WriteLine("Hello World My Name is:"+myName);

        }

        public static String getName()
        {
            // 1 add in a string variable for your name
            String myName;
 
            // 2 add in a print statement to tell you to enter in your name
            System.Console.WriteLine("Please Enter Your Name:");
 
            // 3 now the readline statement will read in your name 
            myName = Console.ReadLine();
 
            return myName;

        }
    }
}
