using OvningGarage.Interfaces;
using OvningGarage.Models;

namespace OvningGarage.Handlers
{
    public class GarageHandler<T> : IHandler<T> where T : Vehicle
    {
        private Garage<T> garage;
        private int carCount;
        private int motorcycleCount;
        private int airplaneCount;
        private int busCount;
        private int boatCount;


        public GarageHandler(int capacity)
        {
            garage = new Garage<T>(capacity);
            carCount = 0;
            motorcycleCount = 0;
            airplaneCount = 0;
            busCount = 0;
            boatCount = 0;
        }


        public void AddVehicleToGarage(string vehicleType, string name, string regNr, int parkingTicketNr, int numberOfEngines, int cylinderVolume, string fuelType, int numberOfSeats, double length)
        {
            T vehicle;
            switch (vehicleType.ToLower())
            {
                case "car":
                    vehicle = (T)(object)new Car(name, regNr, parkingTicketNr, fuelType, cylinderVolume);
                    carCount++;
                    break;
                case "motorcycle":
                    vehicle = (T)(object)new Motorcycle(name, regNr, parkingTicketNr, fuelType, numberOfSeats);
                    motorcycleCount++;
                    break;
                case "airplane":
                    vehicle = (T)(object)new Airplane(name, regNr, parkingTicketNr, numberOfEngines, cylinderVolume, fuelType);
                    airplaneCount++;
                    break;
                case "bus":
                    vehicle = (T)(object)new Bus(name, regNr, parkingTicketNr, length, fuelType);
                    busCount++;
                    break;
                case "boat":
                    vehicle = (T)(object)new Boat(name, regNr, parkingTicketNr, numberOfEngines, numberOfSeats, length);
                    boatCount++;
                    break;
                default:
                    throw new ArgumentException("Invalid vehicle type.");
            }

            garage.AddVehicle(parkingTicketNr, vehicle);
        }

        public void InitialPreDecideGarage(List<(string vehicleType, string name, string regNr, int parkingTicketNr, int numberOfEngines, int cylinderVolume, string fuelType, int numberOfSeats, double length)> initialVehicles)
        {
            foreach (var vehicleParams in initialVehicles)
            {
                AddVehicleToGarage(vehicleParams.vehicleType, vehicleParams.name, vehicleParams.regNr, vehicleParams.parkingTicketNr, vehicleParams.numberOfEngines, vehicleParams.cylinderVolume, vehicleParams.fuelType, vehicleParams.numberOfSeats, vehicleParams.length);
            }
        }

        public bool RemoveVehicleFromGarage(int parkingTicketNr)
        {
            return garage.RemoveVehicle(parkingTicketNr);
        }

        public void ListAllVehicles(Garage<T> garage)
        {
            Console.WriteLine("List of all vehicles in the garage:");
            foreach (var vehicle in garage)
            {
                Console.WriteLine($"Ticket Number: {vehicle.ParkingTicketNr} Name: {vehicle.Name}, Registration Number: {vehicle.RegNr}");
            }
        }

        public void CheckGarageEmpty()
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

        public T FindVehicleByRegNr(string regNr)
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
