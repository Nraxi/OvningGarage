using System;

namespace OvningGarage.UI.Menus
{
    internal class HandleMessages
    {
        public static bool ConfirmParking()
        {
            Console.WriteLine("Did parking succeed?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            string input = Console.ReadLine()!;

            switch (input)
            {
                case "1":
                    Console.WriteLine("Parking succeeded!");
                    return true;
                case "2":
                    Console.WriteLine("Parking failed.");
                    return false;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid number.");
                    return false;
            }
        }
    }
}
