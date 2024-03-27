using OvningGarage.Handlers;
using System;

namespace OvningGarage.UI.Menus
{
    public class HandleRemoveVehicleMenu
    {
        public static void VehicleMenu(GarageHandler garageHandler)
        {
            string input;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Remove Vehicle Menu:");
                Console.WriteLine("1. Press 1, to remove a Vehicle");
                Console.WriteLine("0. Back to Main Menu");

                input = Console.ReadLine()!;

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter your parking ticket number:");
                        if (!int.TryParse(Console.ReadLine(), out int parkingTicketNr))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid parking ticket number.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        }

                        if (garageHandler.FindVehicleByParkingTicket(parkingTicketNr) == null)
                        {
                            Console.WriteLine("Vehicle with the specified parking ticket number not found.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        }

                        garageHandler.RemoveVehicle(parkingTicketNr);
                        Console.WriteLine("Removing Vehicle...");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid number.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
        }
    }
}
