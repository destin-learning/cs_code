using System;

namespace ch4
{
    // this is chapter 9
    class Program
    {
        static void Main(string[] args)
        {
            // 9.1 control variable for program
            Boolean done = false; 

            // 9.2 loop to control flow of program
            while(done==false) 
            {
                
                // 1 add in a string variable for your name
                String myName = GetName();
            
                // 4 add in + myName to print out your name
                System.Console.WriteLine("Hello World My Name is: "+myName);


                // 9.3 check for exit condition
                if (myName == "EXIT")
                {
                    System.Console.WriteLine("Thanks and goodbye!");
                    done = true;
                }
                else
                {
                    System.Console.WriteLine("Thanks for entering your name");
                }


            } // 9.4 end of loop code           

        }

        public static String GetName()
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
