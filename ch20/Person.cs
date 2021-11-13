using System;
 
namespace ch4
{
    // demonstration class to model the basic attributes of a person
    class Person
    {
        // define all person attributes here:
        private int id;
        private String first_name;
        private String last_name;
        private DateTime birth_date;
        private String email_address;
        private String phone_number;
 
        // this is a basic constructor
        public Person(int new_id, 
            String new_first_name, 
            String new_last_name,
            DateTime new_birth_date,
            String new_email_address,
            String new_phone_number)
        {
            // set the object attribute to the input parameter values
            this.id = new_id;
            this.first_name = new_first_name;
            this.last_name = new_last_name;
            this.birth_date = new_birth_date;
            this.email_address = new_email_address;
            this.phone_number = new_phone_number;
 
        }

        // now create a custom toString method
        public override string ToString()
        {
            String my_string;
 
            // create our custom string note the \n is
            // used to create a new line on the screen
            my_string = "Person ID: " + this.id
                + "\nFirst Name: " + this.first_name
                + "\nLast Name: " + this.last_name
                + "\nEmail address: " + this.email_address
                + "\nPhone: " + this.phone_number;
 
            return my_string;
        }
 
    }
}
