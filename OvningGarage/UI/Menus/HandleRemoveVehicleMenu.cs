using OvningGarage.Handlers;
using System;

namespace OvningGarage.UI.Menus
{
    public class HandleRemoveVehicleMenu
    {
        public static void VehicleMenu( )
        {
            string input;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Remove Vehicle Menu:");
                Console.WriteLine("1. Press 1, to remove a car");
                Console.WriteLine("0. Back to Main Menu");

                input = Console.ReadLine()!;

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter your parking ticket number:");
                        Console.ReadLine();
                        Console.WriteLine("Removeing Car...");
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
