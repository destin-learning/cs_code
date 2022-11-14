using System;
 
namespace Rolodex
{

    class Model
    {
        Person[] my_list = new Person[100];
        int irec_to_add = 0;
 
        public void init_model()
        {
            // create the array of people objects to
            // store our rolodex information
            //Person[] my_list = new Person[100];

            irec_to_add = 0;
 
            int i;
            for (i = 0; i < 99; i++)
            {
                my_list[i] = new Person(0,
                    String.Empty,
                    String.Empty,
                    new DateTime(2000, 1, 1),
                    String.Empty,
                    String.Empty);
            }

            // load in our existing data if we have any
            load_all_entries();
        }

        // add a new person to the Rodolex
        public void add_entry()
        {
            string fname;
            string lname;
            string email;
            string phone;
            DateTime bdate = new DateTime(2000, 1, 1);
 
            // 22.2 prompt the operator to enter in a new entry into the Rolodex
            System.Console.WriteLine("Please enter a new entry:");
            System.Console.Write("First Name: ");
            fname = System.Console.ReadLine();
            System.Console.Write("Last Name: ");
            lname = System.Console.ReadLine();
            System.Console.Write("email Address: ");
            email = System.Console.ReadLine();
            System.Console.Write("Phone Number: ");
            phone = System.Console.ReadLine();
   
            // 22.3 add the new entry to the Person array
            my_list[irec_to_add] = new Person(irec_to_add,
                fname,
                lname,
                bdate,
                email,
                phone);
            
            // move the pointer to the next entry
            irec_to_add++;
 
            // notify the user that the entry has been added
            System.Console.WriteLine("Your new entry has been added.");
            System.Console.WriteLine("Press any key to continue.");
            System.Console.ReadKey();
 
        }

        // list all the entries in the rolodex
        public void list_all()
        {
            System.Console.WriteLine("First Name,Last Name,Address,Phone Number,Birthdate");
            System.Console.WriteLine("--------------------------------------------------------------------------------");
 
            // make sure to only go unitl the end of the list
            for (int i=0;i<irec_to_add;i++)
            {
                string my_person = my_list[i].id +
                    "," + my_list[i].first_name +
                    "," + my_list[i].last_name +
                    "," + my_list[i].phone_number +
                    "," + my_list[i].email_address +
                    "," + my_list[i].birth_date.ToShortDateString();
 
                    // make sure there is data in the record
                    if (my_list[i].id != -1)
                    {
                        System.Console.WriteLine(my_person);
                    }
            }
            System.Console.WriteLine("Press any key to continue:");
            System.Console.ReadKey();
        }

        // save all the entries in the rolodex
        public void save_all()   
        {
 
            // open the file for output
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"rolodex.csv");
 
            for (int i=0;i<irec_to_add;i++)
            {
                string my_person = my_list[i].id +
                    "," + my_list[i].first_name +
                    "," + my_list[i].last_name +
                    "," + my_list[i].phone_number +
                    "," + my_list[i].email_address +
                    "," + my_list[i].birth_date.ToShortDateString();
 
                // make sure there is data in the record
                if (my_list[i].id != -1)
                {
                    file.WriteLine(my_person);
                }
            }
 
            file.Close();
            Console.WriteLine("Your file has been saved. Thank you for using Rolodex!");

        }

        public void load_all_entries()
        {
            // open the file and read in each line          
            int counter = 0;
            string line;
 
            // open the file we created in the previous demo  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"rolodex.csv");
 
            // now loop through every line in the file
            while ((line = file.ReadLine()) != null)
            {
                string[] values = line.Split(',') ;
                my_list[counter].id = counter;
                my_list[counter].first_name = values[1];
                my_list[counter].last_name = values[2];
                my_list[counter].email_address = values[3];
                my_list[counter].phone_number = values[4];
 
                // bump up the counter for the next entry in the file
                counter++;
            }
 
            // make sure to set next entry after all the name have been loaded
            irec_to_add = counter;
 
            file.Close();
            System.Console.WriteLine("There were {0} names loaded", counter);
 
        }

        // delete a person from the rolodex
        public void delete_entry()
        {
            int iselection = 0;
            Console.WriteLine("Enter ID to delete:");
 
            // read in a string and convert it to an integer 
            // now validate it can be converted
            try
            {
                iselection = Convert.ToInt32(System.Console.ReadLine());
                // now mark the desired record with a -1 id 
                // so it will be marked for deletion
                my_list[iselection].id = -1;
                Console.WriteLine("Your record has been deleted.");
            }
            catch
            {
                Console.WriteLine("You have entered an invalid ID.");
            }
 
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();
        }

        // edit an entry in the rolodex
        public void edit_entry()
        {
            int iselection = 0;
            Console.WriteLine("Enter an ID to update:");
 
            // read in a string and convert it to an integer
            // now validate it can be converted
            try
            {
                iselection = Convert.ToInt32(System.Console.ReadLine());
                
                string fname;
                string lname;
                string email;
                string phone;
                DateTime bdate = new DateTime(2000, 1, 1);
 
                // 22.2 prompt the operator to enter in a new entry into the Rolodex
                System.Console.WriteLine("Please enter a new entry:");
                System.Console.Write("First Name: ");
                fname = System.Console.ReadLine();
                System.Console.Write("Last Name: ");
                lname = System.Console.ReadLine();
                System.Console.Write("email Address: ");
                email = System.Console.ReadLine();
                System.Console.Write("Phone Number: ");
                phone = System.Console.ReadLine();
   
                // 22.3 add the new entry to the Person array
                my_list[iselection] = new Person(iselection,
                    fname,
                    lname,
                    bdate,
                    email,
                    phone);
                    Console.WriteLine("Your record has been updated.");
            }
            catch
            {
                Console.WriteLine("You have entered an invalid ID.");
            }
 
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();
        }


    }
   
}
