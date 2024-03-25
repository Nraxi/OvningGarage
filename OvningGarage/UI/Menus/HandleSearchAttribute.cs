using System;
using System.Collections.Generic;
using OvningGarage.Handlers;
using OvningGarage.Interfaces;

namespace OvningGarage.UI.Menus
{
    public class HandleSearchAttribute
    {
        public static void VehicleMenu(GarageHandler garageHandler)
        {
            string input;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Search on attribute");
                Console.WriteLine("1. Yes");
                Console.WriteLine("0. Back to Main Menu");

                input = Console.ReadLine()!;

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter the search term:");
                        string searchTerm = Console.ReadLine()!;
                        garageHandler.SearchVehiclesByWord(searchTerm);
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
