using System;

namespace OvningGarage.UI.Menus
{
    public class HandleCheckGarageEmptyMenu
    {
        public static void VehicleMenu()
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
                        Console.WriteLine("LIST OR NOT");
                        Console.ReadLine();
                        Console.WriteLine("GET LIST...");
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
