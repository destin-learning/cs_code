using System;

namespace ch4
{
    // this is chapter 11
    class Program
    {
        static void Main(string[] args)
        {
            Boolean done = false; // 10.1
            int iselection = 0;
 
            while(done==false)
            {
                // 10.2
                System.Console.WriteLine("1) Select to enter your name");
                System.Console.WriteLine("9) Select to exit the program");
                System.Console.WriteLine("Please Enter Your Selection:");

                // 11.1 validate the integer conversion process
                try 
                {
                  // 10.3 read in a string and convert it to an integer
                  iselection = Convert.ToInt32(System.Console.ReadLine());
                }
                catch
                {
                    // 11.3 notify the user of the error
                    System.Console.WriteLine("You have entered an invalid selection");
                }
                
                // 10.4 check for menu selection 1
                if(iselection==1)
                {
         	       // 1 add in a string variable for your name
         	       String myName = GetName();
 
         	       // 4 add in + myName to print out your name
         	       System.Console.WriteLine("Hello World My Name is: "+myName);
                }

                // 10.5 check for exit condition
                if (iselection == 9)
                {
                    System.Console.WriteLine("Thanks and goodbye!");
                    done = true;
                }
                

            } // 10.6 end of loop code


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
