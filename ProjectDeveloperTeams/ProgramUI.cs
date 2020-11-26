using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDeveloperTeams
{
    class ProgramUI
    {
        DeveloperRepo devrepo = new DeveloperRepo();
        public void Run()
        {
            Menu();
        }

        /*
         * These lines BELOW are for TESTING ONLY..
         */

        /* Console.WriteLine(developer.FirstName + "\n"+
             developer.LastName + "\n" +
             developer.ID + "\n" +
             developer.PluralSightAccess);
         Console.ReadLine();
         devrepo.AddDevToList(developer);
         devrepo.GetDevList();

         Console.ReadLine();

         */

    
    //Method to display the menu
    private void Menu()
    {
        bool AppRunning = true;
        while (AppRunning)
        {
            Console.WriteLine("Select an option from the menu:\n" +  //Template<  ":\n" +  >
                "1. Add a Developer:\n" +
                "2. Add Team:\n" +
                "3. View list of All Developers:\n" +
                "4. View list of Developers Needing PluralSight:\n" +
                "5. Exit:\n");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //Add a new developer
                    CreateNewDev();
                    break;
                case "2":
                    //Create a new Team
                    break;
                case "3":
                    //View list of all developers
                    break;
                case "4":
                    //view list of developers needing pluralsight
                    break;
                case "5":
                    //exit the application
                    Console.WriteLine("Ok- Ending now");
                    AppRunning = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection number.");
                    break;
            }
            Console.WriteLine("Press a key to continue-");
            Console.ReadKey();
            Console.Clear();

        }
    }

        //create new content
        private void CreateNewDev()
        {
            Developer developer = new Developer();
            DeveloperRepo _devrepo = new DeveloperRepo();

            Console.WriteLine("Please enter a developer name:");
            //string FirstName = Console.ReadLine();
            developer.FirstName = Console.ReadLine();

            Console.WriteLine("Last Name:");
            //string LastName = Console.ReadLine();
            developer.LastName = Console.ReadLine();
            Console.WriteLine("ID:");
            //string ID = Console.ReadLine();
            developer.ID = Console.ReadLine();
            Console.WriteLine("Access to Plural Sight (true or false");
            developer.PluralSightAccess = bool.Parse(Console.ReadLine());

            _devrepo.AddDevToList(developer);

        }
    }
}
