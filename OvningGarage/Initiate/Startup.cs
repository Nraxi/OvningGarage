using OvningGarage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningGarage.Initiate
{
    public class Startup
    {
        private readonly IUI ui;

        public Startup(IUI ui)
        {
            this.ui = ui;
        }

        public void Run()
        {
            bool exit = false;
            do
            {
                ui.DisplayMainMenu();
                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        ui.DisplayAddVehicleMenu();
                        // Implement logic for adding vehicles
                        break;
                    case "2":
                        ui.DisplayRemoveVehicleMenu();
                        // Implement logic for removing vehicles
                        break;
                    case "3":
                        ui.DisplayListAllVehiclesMenu();
                        // Implement logic for listing all vehicles
                        break;
                    case "4":
                        ui.DisplayCheckGarageEmptyMenu();
                        // Implement logic for checking if garage is empty
                        break;
                    case "5":
                        ui.DisplayFindVehicleByRegNrMenu();
                        // Implement logic for finding vehicle by registration number
                        break;
                    case "6":
                        ui.DisplayInitialPreDecideGarageMenu();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (!exit);
        }
    }
}
