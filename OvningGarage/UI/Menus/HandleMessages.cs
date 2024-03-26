using System;

namespace OvningGarage.UI.Menus
{
    internal class HandleMessages
    {
        public static bool ConfirmParking()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 5); // Slumpmässigt välj ett av de fyra meddelandena

            Console.WriteLine("Parking confirmation:");
            Console.WriteLine("1. Success");
            Console.WriteLine("2. Failed");

            string choice = Console.ReadLine()!;
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Vehicle parked successfully!");

                    return true;
                case "2":
                    Console.WriteLine("Parking failed.");
                    Console.WriteLine("1. Why");
                    Console.WriteLine("2. Exit");
                    string reasonChoice = Console.ReadLine()!;
                    switch (reasonChoice)
                    {
                        case "1":
                            Console.WriteLine("Reason: We were unable to park the vehicle due to the issue down below:");
                            switch (randomNumber)
                            {
                                case 1:
                                    Console.WriteLine(" We hit a pillar and your vehicle is at the repair shop.");
                                    break;
                                case 2:
                                    Console.WriteLine(" We accidentally collided with your vehicle.");
                                    break;
                                case 3:
                                    Console.WriteLine(" We found an item in your vehicle that shouldn't be there. Please come and collect it immediately.");
                                    break;
                                case 4:
                                    Console.WriteLine(" It's now with the Police due to enforcement action.");
                                    break;
                                default:
                                    Console.WriteLine("Unknown reason for failure.");
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Exiting...");
                            break;
                    }
                    return false;
                default:
                    Console.WriteLine("Invalid choice.");
                    return false;
            }
        }
    }
}