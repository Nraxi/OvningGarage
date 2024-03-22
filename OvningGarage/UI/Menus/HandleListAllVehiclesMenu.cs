using System;

namespace OvningGarage.UI.Menus
{
    public class HandleListAllVehiclesMenu
    {
        public static void VehicleMenu()
        {
            string input;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("List All Vehicles Menu:");
                Console.WriteLine("1. Press 1, to get List");
                Console.WriteLine("0. Back to Main Menu");

                input = Console.ReadLine()!;

                switch (input)
                {
                    case "1":
                        Console.WriteLine("List of List");
                        
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
