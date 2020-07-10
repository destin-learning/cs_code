using System;

namespace ch4
{
    // this is chapter 18
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
                System.Console.WriteLine("2) Array demo");
                System.Console.WriteLine("3) File output demo");
                System.Console.WriteLine("4) File input demo");
                System.Console.WriteLine("5) String Function Demo ");
                System.Console.WriteLine("9) Select to exit the program");
                System.Console.WriteLine("Please Enter Your Selection:");

                // 11.1 validate the integer conversion process
                try 
                {
                  // 10.3 read in a string and convert it to an integer
                  iselection = 0;
                  iselection = Convert.ToInt32(System.Console.ReadLine());
                }
                catch
                {
                    // 11.3 notify the user of the error
                    System.Console.WriteLine("You have entered an invalid selection");
                }
                
                // 10.3 check for menu selection 1
                switch (iselection) // 12.1
                {
                    case 1: // 12.2
                    {
                        // 1 add in a string variable for your name
                        String myName = GetName();
 
                        // 4 add in + myName to print out your name
                        System.Console.WriteLine("Hello World My Name is:" + myName);
                        break;
                    }

                    // this will demonstrate the capability of arrays
                    case 2:           // 13.3
                    {
                        ArrayDemo();  // 13.2
                        break;        // 13.3
                    }

                    // this will demonstrate how to write an output file in C# 
                    case 3: 										
                    {
                        FileDemo();
                        break;
                    break;
                    }

                    // this will demonstrate how to read an input file in C# 	 
                    case 4: 										
                    {
                        FileInputDemo();
                        break;
                    }

                    // this will demonstrate how to use string functions in C#  	 
                    case 5: 										
                    {
                        StringDemo();
                        break;
                    }


                    // check to see if we are done with the program
                    // change this to use an integer now
                    case 9: // 12.3
                    {
                        System.Console.WriteLine("Thank you and goodbye!");
                        done = true;
                        break;
                    }
 
                    default: // 12.4 handle the default case
                    {
                        System.Console.WriteLine("You have made an invalid selection.");
                        break;
                    }
                } // 12.5

                
            } // 10.6 end of loop code

        }

        // demonstrate how to use string functions in C#
        public static void StringDemo()
        {
            String my_string = "This is my string example";
 
            // 18.1 how to get the string length
            int ilen;
            ilen = my_string.Length;
            System.Console.WriteLine("This string length is: " + ilen);
 
            // 18.2 convert a string to uppercase
            String new_string = my_string.ToUpper();
            System.Console.WriteLine("my_string in upper case: " + new_string);
 
            // 18.3 convert a string to lowercase
            new_string = my_string.ToLower();
            System.Console.WriteLine("my_string in lower case: " + new_string);
 
            // 18.4 check the starting string character
            if (my_string.StartsWith("Th"))
            {
                System.Console.WriteLine("This string starts with TH.");
            } else
            {
                System.Console.Write("This string does not start with TH.");
            }
 
            // 18.5 replace a character in a string
            new_string = my_string.Replace("s", "x");
            System.Console.WriteLine("new_string after replacement:" + new_string);
 
            // 18.6 get a substring from the original string
            new_string = my_string.Substring(0, 10);
            System.Console.WriteLine("The first 10 characters of my_string: "+new_string);
 
        }

         // demonstrate how to read an input file in C# and 
        // display it to the screen
        public static void FileInputDemo()
        {
            int counter = 0;
            string line;
 
            // 17.1 open the file we created in the previous demo  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"output.txt");
 
            // 17.2 now loop through every line in the file
            while ((line = file.ReadLine()) != null)
            {
                // 17.3 print the line out
                System.Console.WriteLine(line);
                counter++;
            }
 
            // 17.4 we are done close out the resource
            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
 
        }
       
        // 16.1 demonstrate how to write an output file in C#
        public static void FileDemo()
        {
            // 16.2 Create a string array that consists of three lines.
            string[] lines = { "First line", "Second line", "Third line" }; 
           
            // 16.3 open a new file for the output
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"output.txt")) 
            {
                // 16.4 now write all of the array to the file
                foreach (string line in lines)
                {
                        file.WriteLine(line); 
                }
            }
 
        }

        // show the basic operation of an array
         public static void ArrayDemo()
        {
            // 13.2 set up a string for each day of the week
            string[] days = new string[] {"Sun","Mon","Tue","Wed","Thr","Fri","Sat"};

            int i;

            // 13.3 print out all of the days
            for(i=0;i<=6;i++)
            {
                System.Console.WriteLine("The day of the week is: " + days[i]);
            }
            
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
