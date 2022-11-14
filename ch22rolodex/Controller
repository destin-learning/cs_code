using System;
 
namespace Rolodex
{

    class Controller
    {
        static Model my_model;

        // constructor for our Controller class
        public Controller()
        {
            my_model = new Model();
            my_model.init_model();
        }

        public void route_selection(int iselection)
        {
            switch (iselection)
            {

                // process adding a new person
                case 1:
                {
                    my_model.add_entry();
                    break;
                }
    
                // delete a rolodex entry
                case 2:
                {
                    my_model.delete_entry();
                    break;
                }
 
                // edit an existing entry
                case 3:
                {
                    my_model.edit_entry();
                    break;
                }
 
                // list all entries in the rolodex
                case 4:
                {
                    my_model.list_all();
                    break;
                }

                case 9:
                {
                    // make sure we save everthing before we exit
                    my_model.save_all();
                    break;
                }

            }

        }

    }
}
