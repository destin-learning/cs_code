using System;
 
namespace Rolodex
{

    class Menu
    {
        public int display_menu()
        {
            int iselection = 0;

            System.Console.Clear();
            System.Console.WriteLine("1) Add a new name to the Rolodex");
            System.Console.WriteLine("2) Delete a name from the Rolodex");
            System.Console.WriteLine("3) Edit a Rolodex Entry");
            System.Console.WriteLine("4) List all Rolodex Entries");
            System.Console.WriteLine("9) Exit program");
            System.Console.WriteLine("Please Enter Your Selection:");

            try
            {
                iselection = Convert.ToInt32(System.Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You have entered an invalid selection.");
            }

            return iselection;

        }

        public void cleanup()
        {
            Console.Clear();
            Console.WriteLine("Thank you and goodbye!");
        }

    }
}
