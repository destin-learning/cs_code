using System;

namespace Rolodex
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean done = false;
            int iselection = 0;
            Menu my_menu = new Menu();
            Controller my_controller = new Controller();

            // initialize the data for the Rolodex
            Model myModel = new Model();
            myModel.init_model();

            // process commends until the user selects exit
            while (done == false)
            {
                iselection = my_menu.display_menu();

                my_controller.route_selection(iselection); 

                if(iselection==9)
                { 
                    done = true;
                }  
                
            } // end of done loop
            
        }
    }
}
