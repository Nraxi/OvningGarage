using OvningGarage.Handlers;
using System;

namespace OvningGarage.UI.Menus
{
    public class HandleListAllVehiclesMenu
    {
        public static void VehicleMenu(GarageHandler garageHandler)
        {
            string input;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("List All Vehicles Menu:");
                Console.WriteLine("1. To get a List");
                Console.WriteLine("2. to get a detailed List");
                Console.WriteLine("0. Back to Main Menu");

                input = Console.ReadLine()!;

                switch (input)
                {
                    case "1":
                        Console.WriteLine("List of List");
                        garageHandler.ListAllVehicles();

                        
                        break;
                    case "2":
                        garageHandler.CheckGarage();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid number.");
                        break;
                }
                Console.ReadKey();
                Console.Clear(); 
            }
        }
    }
}
