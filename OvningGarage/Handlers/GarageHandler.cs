using OvningGarage.Models;
using System.Linq;

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


        public GarageHandler(int capacity)
        {
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



        public void AddCarToGarage(string name, string regNr, int parkingTicketNr, string fuelType, int cylinderVolume)
        {
            Car car = new Car(name, regNr, parkingTicketNr, fuelType, cylinderVolume);
            garage.AddVehicle(parkingTicketNr, car);
            carCount++;
        }

        public void AddMotorcycleToGarage(string name, string regNr, int parkingTicketNr, string fuelType, int numberOfSeats)
        {
            Motorcycle motorcycle = new Motorcycle(name, regNr, parkingTicketNr, fuelType, numberOfSeats);
            garage.AddVehicle(parkingTicketNr, motorcycle);
            motorcycleCount++;
        }

        public void AddAirplaneToGarage(string name, string regNr, int parkingTicketNr, int numberOfEngines, int cylinderVolume, string fuelType)
        {
            Airplane airplane = new Airplane(name, regNr, parkingTicketNr, numberOfEngines, cylinderVolume, fuelType);
            garage.AddVehicle(parkingTicketNr, airplane);
            airplaneCount++;
        }

        public void AddBusToGarage(string name, string regNr, int parkingTicketNr, double length, string fuelType)
        {
            Bus bus = new Bus(name, regNr, parkingTicketNr, length, fuelType);
            garage.AddVehicle(parkingTicketNr, bus);
            busCount++;
        }

        public void AddBoatToGarage(string name, string regNr, int parkingTicketNr, int numberOfEngines, int numberOfSeats, double length)
        {
            Boat boat = new Boat(name, regNr, parkingTicketNr, numberOfEngines, numberOfSeats, length);
            garage.AddVehicle(parkingTicketNr, boat);
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
                    break;
                }
            }

            if (!vehicleRemoved)
            {
                Console.WriteLine("Vehicle with the specified parking ticket number not found");
                //throw new ArgumentException("Vehicle with the specified parking ticket number not found.");
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
            Console.WriteLine("List of all vehicles in the garage:");
            foreach (var vehicle in garage)
            {
                Console.WriteLine($"Ticket Number: {vehicle.ParkingTicketNr} Name: {vehicle.Name}, Registration Number: {vehicle.RegNr}");
            }
        }

        public bool CheckGarageEmpty()
        {
            return garage.Count() == 0;
        }

        public void CheckGarage()
        {
            if (garage.Count() == 0)
            {
                Console.WriteLine("The garage is empty.");
            }
            else
            {
                Console.WriteLine("The garage is not empty.");
                Console.WriteLine($"Total number of vehicles: {garage.Count()}");
                Console.WriteLine($"Number of cars: {carCount}");
                Console.WriteLine($"Number of motorcycles: {motorcycleCount}");
                Console.WriteLine($"Number of airplanes: {airplaneCount}");
                Console.WriteLine($"Number of buses: {busCount}");
                Console.WriteLine($"Number of boats: {boatCount}");
            }
        }

        public Vehicle FindVehicleByRegNr(string regNr)
        {
            foreach (var vehicle in garage)
            {
                if (vehicle.RegNr.Equals(regNr, StringComparison.OrdinalIgnoreCase))
                {
                    return vehicle;
                }
            }
            throw new ArgumentException("Vehicle with the specified registration number not found.");
        }
    }
}
