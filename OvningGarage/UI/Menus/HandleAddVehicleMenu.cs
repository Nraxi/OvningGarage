using OvningGarage.Handlers;
using System;

namespace OvningGarage.UI.Menus
{
    public class HandleAddVehicleMenu
    {
        public static void VehicleMenu()
        {
            string input;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Add Vehicle Menu:");
                Console.WriteLine("Choose vehicle type:");
                Console.WriteLine("1. Car");
                Console.WriteLine("2. Motorcycle");
                Console.WriteLine("3. Airplane");
                Console.WriteLine("4. Bus");
                Console.WriteLine("5. Boat");
                Console.WriteLine("0. Back to Main Menu");

                input = Console.ReadLine()!;

                switch (input)
                {
                    case "1":
                        
                        //var märke = Console.ReadLine();
                        //var RegNr = Console.ReadLine();
                        //int ParkingTicketNr = Console.ReadLine();
                        //var FuelType = Console.ReadLine();
                        //int CylinderVolume = Console.ReadLine();
                        //GarageHandler.AddCarToGarage(märke, RegNr, ParkingTicketNr, FuelType, CylinderVolume);
                        Console.WriteLine("Adding Car...");
                        break;
                    case "2":
                        Console.WriteLine("Adding Motorcycle...");
                        break;
                    case "3":
                        Console.WriteLine("Adding Airplane...");
                        break;
                    case "4":
                        Console.WriteLine("Adding Bus...");
                        break;
                    case "5":
                        Console.WriteLine("Adding Boat...");
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
