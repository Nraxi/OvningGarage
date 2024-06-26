﻿using OvningGarage.Models;

namespace OvningGarage.Handlers
{
    public class GarageHandler
    {

        private Garage<Vehicle> garage;
        private int carCount;
        private int motorcycleCount;
        private int airplaneCount;
        private int busCount;
        private int boatCount;
        private int capacity;


        public GarageHandler(int capacity)
        {
            this.capacity = capacity;
            garage = new Garage<Vehicle>(capacity);
            carCount = 0;
            motorcycleCount = 0;
            airplaneCount = 0;
            busCount = 0;
            boatCount = 0;
        }

        public int TotalVehiclesCount()
        {
            return garage.Count();
        }


        public Vehicle? FindVehicleByParkingTicket(int parkingTicketNr)
        {
            return garage.FirstOrDefault(vehicle => vehicle.ParkingTicketNr == parkingTicketNr);
        }

        public void AddCarToGarage(string name, string regNr, string fuelType, int cylinderVolume, int parkingTicketNr)
        {
            Car car = new Car(name, regNr, fuelType, cylinderVolume, parkingTicketNr);
            garage.AddVehicle(car);
            carCount++;

        }

        public void AddMotorcycleToGarage(string name, string regNr, string fuelType, int numberOfSeats, int parkingTicketNr)
        {
            Motorcycle motorcycle = new Motorcycle(name, regNr, fuelType, numberOfSeats, parkingTicketNr);
            garage.AddVehicle(motorcycle);
            motorcycleCount++;

        }

        public void AddAirplaneToGarage(string name, string regNr, int numberOfEngines, int cylinderVolume, string fuelType, int parkingTicketNr)
        {
            Airplane airplane = new Airplane(name, regNr, numberOfEngines, cylinderVolume, fuelType, parkingTicketNr);
            garage.AddVehicle(airplane);
            airplaneCount++;

        }

        public void AddBusToGarage(string name, string regNr, double length, string fuelType, int parkingTicketNr)
        {
            Bus bus = new Bus(name, regNr, length, fuelType, parkingTicketNr);
            garage.AddVehicle(bus);
            busCount++;

        }

        public void AddBoatToGarage(string name, string regNr, int numberOfEngines, int numberOfSeats, double length, int parkingTicketNr)
        {
            Boat boat = new Boat(name, regNr, numberOfEngines, numberOfSeats, length, parkingTicketNr);
            garage.AddVehicle(boat);
            boatCount++;

        }


        public void RemoveVehicle(int parkingTicketNr)
        {
            bool vehicleRemoved = false;

            foreach (var vehicle in garage)
            {
                if (vehicle.ParkingTicketNr == parkingTicketNr)
                {
                    garage.RemoveVehicle(parkingTicketNr);
                    UpdateCounts(vehicle); // Update vehicle counts
                    vehicleRemoved = true;
                    capacity++;
                    Console.WriteLine("Succeed");
                    break;
                }
            }

            if (!vehicleRemoved)
            {
                Console.WriteLine("Vehicle with the specified parking ticket number not found");

            }
        }


        private void UpdateCounts(Vehicle vehicle)
        {
            if (vehicle is Car)
            {
                carCount--;
            }
            else if (vehicle is Motorcycle)
            {
                motorcycleCount--;
            }
            else if (vehicle is Airplane)
            {
                airplaneCount--;
            }
            else if (vehicle is Bus)
            {
                busCount--;
            }
            else if (vehicle is Boat)
            {
                boatCount--;
            }
        }



        public void ListAllVehicles()
        {
            if (garage.Count == 0)
            {
                Console.WriteLine("The garage is empty.");
            }
            else
            {
                Console.WriteLine("List of all vehicles in the garage:");
                int currentParkingTicketNr = 1;

                foreach (var vehicle in garage)
                {
                    Console.WriteLine($"Ticket Number: {currentParkingTicketNr} Name: {vehicle.Name}, Registration Number: {vehicle.RegNr}");
                    currentParkingTicketNr++;
                }
            }
        }
    

        public void SearchVehiclesByWord(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                Console.WriteLine("Invalid search term. Please enter a valid term.");
                return;
            }

            bool foundMatch = false;

            foreach (var vehicle in garage)
            {
                string vehicleType = GetVehicleType(vehicle);

                if (vehicleType.Equals(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    vehicle.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    vehicle.RegNr.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    vehicle.ParkingTicketNr.ToString().Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Type: {vehicleType}, Name: {vehicle.Name}, Registration Number: {vehicle.RegNr}, Parking Ticket Number: {vehicle.ParkingTicketNr}");
                    foundMatch = true;
                }
            }

            if (!foundMatch)
            {
                Console.WriteLine($"No vehicles found matching the search term '{searchTerm}'.");
            }
        }


        private string GetVehicleType(Vehicle vehicle)
        {
            if (vehicle is Car)
            {
                return "Car";
            }
            else if (vehicle is Motorcycle)
            {
                return "Motorcycle";
            }
            else if (vehicle is Airplane)
            {
                return "Airplane";
            }
            else if (vehicle is Bus)
            {
                return "Bus";
            }
            else if (vehicle is Boat)
            {
                return "Boat";
            }
            else
            {
                return "Unknown";
            }
        }

        public int GetCapacity => garage.Capacity;

        public bool CheckGarageEmpty()
        {
            return garage.Count == 0;
        }

        public void CheckGarage()
        {
            if (garage.Count == 0)
            {
                Console.WriteLine("The garage is empty.");
            }
            else
            {
                Console.WriteLine("The garage is not empty.\n");
                Console.WriteLine($"Total number of vehicles: {garage.Count()}");
                Console.WriteLine($"Number of cars: {carCount}");
                Console.WriteLine($"Number of motorcycles: {motorcycleCount}");
                Console.WriteLine($"Number of airplanes: {airplaneCount}");
                Console.WriteLine($"Number of buses: {busCount}");
                Console.WriteLine($"Number of boats: {boatCount}");
                Console.WriteLine($"\n");
                ListAllVehicles();
            }
        }

        public Vehicle? FindVehicleByRegNr(string regNr)
        {
            foreach (var vehicle in garage)
            {
                if (vehicle.RegNr.Equals(regNr, StringComparison.OrdinalIgnoreCase))
                {
                    return vehicle;
                }
            }

            Console.WriteLine("Vehicle with the specified registration number not found.");
            return null;
        }
    }
}