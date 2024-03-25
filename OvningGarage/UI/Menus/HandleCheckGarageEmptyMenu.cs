using OvningGarage.Handlers;
using System;

namespace OvningGarage.UI.Menus
{
    public class HandleCheckGarageEmptyMenu
    {
        public static void VehicleMenu(GarageHandler garageHandler)
        {
            string input;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Check Garage Empty Menu:");
                Console.WriteLine("1. Press 1, to make a check");
                Console.WriteLine("0. Back to Main Menu");

                input = Console.ReadLine()!;

                switch (input)
                {
                    case "1":
                        if (garageHandler.CheckGarageEmpty())
                        {
                            Console.WriteLine("The garage is now empty.");
                        }
                        else
                        {
                            int currentCapacity = garageHandler.GetCapacity;
                            int availableSpots = currentCapacity - garageHandler.TotalVehiclesCount();
                            Console.WriteLine($"The garage is not empty. Available spots: {availableSpots}");
                        }
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid number.");
                        break;
                }
            }
        }
    }
}
