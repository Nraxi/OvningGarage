using OvningGarage.Handlers;
using System;

namespace OvningGarage.UI.Menus
{
    public class HandleCheckGarageEmptyMenu
    {
        public static void VehicleMenu(GarageHandler garageHandler, int capacity)
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
                        if (GarageHandler.CheckGarageEmpty(garageHandler.GetGarage()))
                        {
                            Console.WriteLine("The garage is empty.");
                            Console.WriteLine($"Garage capacity: {capacity}");
                        }
                        else
                        {
                            Console.WriteLine("The garage is not empty.");
                            Console.WriteLine($"Garage capacity: {capacity}");
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
