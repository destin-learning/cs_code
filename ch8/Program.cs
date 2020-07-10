using System;

namespace ch4
{
    // this is chapter 8
    class Program
    {
        static void Main(string[] args)
        {
            // 7.1 add in a string variable for your name
            String myName = getName();

            // 4 add in + myName to print out your name
            System.Console.WriteLine("Hello World My Name is: " + myName);

            if (myName.Length == 0 )
            {
                System.Console.WriteLine("You did not enter your name!");
            }
            else
            {
                System.Console.WriteLine("Thanks for entering your name");
            }

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
