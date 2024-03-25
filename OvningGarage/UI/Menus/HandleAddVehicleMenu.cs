using Microsoft.VisualBasic.FileIO;
using OvningGarage.Handlers;
using OvningGarage.Models;

namespace OvningGarage.UI.Menus
{
    public class HandleAddVehicleMenu
    {
        public static void VehicleMenu(GarageHandler garageHandler)
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
                        Console.WriteLine("Adding a Car...");
                        Car(garageHandler);
                        break;

                    case "2":
                        Console.WriteLine("Adding Motorcycle...");
                        Motorcycle(garageHandler);
                        break;
                    case "3":
                        Console.WriteLine("Adding Airplane...");
                        Airplane(garageHandler);
                        break;
                    case "4":
                        Console.WriteLine("Adding Bus...");
                        Bus(garageHandler);
                        break;
                    case "5":
                        Console.WriteLine("Adding Boat...");
                        Boat(garageHandler);
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
        private static void Car(GarageHandler garageHandler)
        {
            Console.WriteLine("Enter car brand:");
            var brand = Console.ReadLine();

            Console.WriteLine("Enter car registration number:");
            var regNr = Console.ReadLine();

            Console.WriteLine("Enter car fuel type:");
            var fuelType = Console.ReadLine();

            int cylinderVolume;
            Console.WriteLine("Enter car cylinder volume:");
            while (!int.TryParse(Console.ReadLine(), out cylinderVolume))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for cylinder volume:");
            }

            int parkingTicketNr = garageHandler.TotalVehiclesCount() + 1;
            int currentCapacity = garageHandler.GetCapacity;
            // Nullkontroller för att undvika varningar
            if (brand != null && regNr != null && fuelType != null)
            {
                if (garageHandler.TotalVehiclesCount() >= currentCapacity)
                {
                    Console.WriteLine("The Garage is full. Please consider parking elsewhere.");
                }
                else
                {
                    garageHandler.AddCarToGarage(brand, regNr, fuelType, cylinderVolume, parkingTicketNr);
                    Console.WriteLine("Your car has been added. Please check that the current information is correct.");
                    Console.WriteLine("If wrong please call the customer service");
                    Console.WriteLine(garageHandler.FindVehicleByRegNr(regNr).GetVehicleInfo());
                }
            }
            else
            {
                Console.WriteLine("One or more input values are null. Car cannot be added.");
                return;
            }
        }

        private static void Motorcycle(GarageHandler garageHandler)
        {
            Console.WriteLine("Enter Motorcycle brand:");
            var brand = Console.ReadLine();

            Console.WriteLine("Enter Motorcycle registration number:");
            var regNr = Console.ReadLine();

            Console.WriteLine("Enter Motorcycle fuel type:");
            var fuelType = Console.ReadLine();

            int numberOfSeats;
            Console.WriteLine("Enter Motorcycle numbers of seats:");
            while (!int.TryParse(Console.ReadLine(), out numberOfSeats))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for cylinder volume:");
            }

            int parkingTicketNr = garageHandler.TotalVehiclesCount() + 1;
            int currentCapacity = garageHandler.GetCapacity;
            // Nullkontroller för att undvika varningar
            if (brand != null && regNr != null && fuelType != null)
            {
                if (garageHandler.TotalVehiclesCount() >= currentCapacity)
                {
                    Console.WriteLine("The Garage is full. Please consider parking elsewhere.");
                }
                else
                {
                    garageHandler.AddMotorcycleToGarage(brand, regNr, fuelType, numberOfSeats, parkingTicketNr);
                    Console.WriteLine("Adding Motorcycle...");
                    Console.WriteLine("\n press enter");
                    Console.ReadKey();
                    Console.WriteLine("Your Motorcycle has been added. ");
                    Console.WriteLine(garageHandler.FindVehicleByRegNr(regNr).GetVehicleInfo());

                    Console.WriteLine("If something is wrong please call the customer service");
                }
            }
            else
            {
                Console.WriteLine("One or more input values are null. Motorcycle cannot be added.");
                return;
            }
        }








        private static void Airplane(GarageHandler garageHandler)
        {
            Console.WriteLine("Enter Airplane brand:");
            var brand = Console.ReadLine();

            Console.WriteLine("Enter Airplane registration number:");
            var regNr = Console.ReadLine();

            int numberOfEngines;
            Console.WriteLine("Enter Airplane number of Engines volume:");
            while (!int.TryParse(Console.ReadLine(), out numberOfEngines))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the engines:");
            }


            int cylinderVolume;
            Console.WriteLine("Enter Airplane cylinder volume:");
            while (!int.TryParse(Console.ReadLine(), out cylinderVolume))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for cylinder volume:");
            }

            Console.WriteLine("Enter Airplane fuel type:");
            var fuelType = Console.ReadLine();
            int parkingTicketNr = garageHandler.TotalVehiclesCount() + 1;
            int currentCapacity = garageHandler.GetCapacity;
            // Nullkontroller för att undvika varningar
            if (brand != null && regNr != null && fuelType != null)
            {
                if (garageHandler.TotalVehiclesCount() >= currentCapacity)
                {
                    Console.WriteLine("The Garage is full. Please consider parking elsewhere.");
                }
                else
                {
                    garageHandler.AddAirplaneToGarage(brand, regNr, numberOfEngines, cylinderVolume, fuelType, parkingTicketNr);
                    Console.WriteLine("Adding Airplane...");
                    Console.WriteLine("\n press enter");
                    Console.ReadKey();
                    Console.WriteLine("Your Airplane has been added. ");
                    Console.WriteLine(garageHandler.FindVehicleByRegNr(regNr).GetVehicleInfo());

                    Console.WriteLine("If something is wrong please call the customer service");
                }
            }
            else
            {
                Console.WriteLine("One or more input values are null. Airplane cannot be added.");
                return;
            }
        }



        private static void Bus(GarageHandler garageHandler)
        {
            Console.WriteLine("Enter Bus brand:");
            var brand = Console.ReadLine();

            Console.WriteLine("Enter Bus registration number:");
            var regNr = Console.ReadLine();

            double length;
            Console.WriteLine("Enter Bus numbers of seats:");
            while (!double.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for length:");
            }

            Console.WriteLine("Enter Bus fuel type:");
            var fuelType = Console.ReadLine();
            int parkingTicketNr = garageHandler.TotalVehiclesCount() + 1;
            int currentCapacity = garageHandler.GetCapacity;
            // Nullkontroller för att undvika varningar
            if (brand != null && regNr != null && fuelType != null)
            {
                if (garageHandler.TotalVehiclesCount() >= currentCapacity)
                {
                    Console.WriteLine("The Garage is full. Please consider parking elsewhere.");
                }
                else
                {
                    garageHandler.AddBusToGarage(brand, regNr, length, fuelType, parkingTicketNr);
                    Console.WriteLine("Adding Bus...");
                    Console.WriteLine("\n press enter");
                    Console.ReadKey();
                    Console.WriteLine("Your Bus has been added. ");
                    Console.WriteLine(garageHandler.FindVehicleByRegNr(regNr).GetVehicleInfo());

                    Console.WriteLine("If something is wrong please call the customer service");
                }
            }
            else
            {
                Console.WriteLine("One or more input values are null. Bus cannot be added.");
                return;
            }
        }

        private static void Boat(GarageHandler garageHandler)
        {
            Console.WriteLine("Enter Boat brand:");
            var brand = Console.ReadLine();

            Console.WriteLine("Enter Boat registration number:");
            var regNr = Console.ReadLine();


            int numberOfEngines;
            Console.WriteLine("Enter Boat number of Engine:");
            while (!int.TryParse(Console.ReadLine(), out numberOfEngines))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for cylinder volume:");
            }

            int numberOfSeats;
            Console.WriteLine("Enter Boat numbers of seats:");
            while (!int.TryParse(Console.ReadLine(), out numberOfSeats))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for cylinder volume:");
            }


            double length;
            Console.WriteLine("Enter boat lengths");
            while (!double.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for length:");
            }

            int parkingTicketNr = garageHandler.TotalVehiclesCount() + 1;

            int currentCapacity = garageHandler.GetCapacity;
            // Nullkontroller för att undvika varningar
            if (brand != null && regNr != null)
            {
                if (garageHandler.TotalVehiclesCount() >= currentCapacity)
                {
                    Console.WriteLine("The Garage is full. Please consider parking elsewhere.");
                }
                else
                {
                    garageHandler.AddBoatToGarage(brand, regNr, numberOfEngines, numberOfSeats, length, parkingTicketNr);
                    Console.WriteLine("Adding Boat...");
                    Console.WriteLine("\n press enter");
                    Console.ReadKey();
                    Console.WriteLine("Your Boat has been added. ");
                    Console.WriteLine(garageHandler.FindVehicleByRegNr(regNr).GetVehicleInfo());

                    Console.WriteLine("If something is wrong please call the customer service");
                }
            }
            else
            {
                Console.WriteLine("One or more input values are null. Boat cannot be added.");
                return;
            }
        }
    }
}
