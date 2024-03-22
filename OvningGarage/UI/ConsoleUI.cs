using OvningGarage.Interfaces;
using OvningGarage.UI.Menus;

public class ConsoleUI : IUI
{
    public void DisplayMainMenu()
    {
       
        Console.Clear();
        Console.WriteLine("Main Menu:");
        Console.WriteLine("1. Add Vehicle");
        Console.WriteLine("2. Remove Vehicle");
        Console.WriteLine("3. List All Vehicles");
        Console.WriteLine("4. Check Garage Empty");
        Console.WriteLine("5. Find Vehicle By Registration Number");
        Console.WriteLine("6. Initialize Garage with Initial Vehicles");
        Console.WriteLine("0. Exit");
    }

    public void DisplayAddVehicleMenu()
    {
        HandleAddVehicleMenu.VehicleMenu();
    }

    public void DisplayRemoveVehicleMenu()
    {
        HandleRemoveVehicleMenu.VehicleMenu();
    }

    public void DisplayListAllVehiclesMenu()
    {
        HandleListAllVehiclesMenu.VehicleMenu();
        // No additional input required
    }

    public void DisplayCheckGarageEmptyMenu()
    {
       HandleCheckGarageEmptyMenu.VehicleMenu();
        // No additional input required
    }

    public void DisplayFindVehicleByRegNrMenu()
    {
  HandleFindVehicleByRegNrMenu.VehicleMenu();
    }

    public void DisplayInitialPreDecideGarageMenu()
    {
        HandleInitialPreDecideGarageMenu.VehicleMenu(this);
    }

    public void InitialPreDecideGarage(List<(string vehicleType, string name, string regNr, int parkingTicketNr, int numberOfEngines, int cylinderVolume, string fuelType, int numberOfSeats, double length)> initialVehicles)
    {
        // Implementation for initializing garage with initial vehicles
        Console.WriteLine("Initializing garage with initial vehicles:");
        foreach (var vehicleParams in initialVehicles)
        {
            Console.WriteLine($"Vehicle Type: {vehicleParams.vehicleType}, Name: {vehicleParams.name}, Registration Number: {vehicleParams.regNr}");
            // You might want to call your handler method here to add the vehicle to the garage
            // For example: garageHandler.AddVehicleToGarage(vehicleParams.vehicleType, vehicleParams.name, vehicleParams.regNr, vehicleParams.parkingTicketNr, vehicleParams.numberOfEngines, vehicleParams.cylinderVolume, vehicleParams.fuelType, vehicleParams.numberOfSeats, vehicleParams.length);
        }
        Console.WriteLine("Initialization complete.");
    }

    public List<(string vehicleType, string name, string regNr, int parkingTicketNr, int numberOfEngines, int cylinderVolume, string fuelType, int numberOfSeats, double length)> GetInitialVehiclesInput()
    {
        List<(string vehicleType, string name, string regNr, int parkingTicketNr, int numberOfEngines, int cylinderVolume, string fuelType, int numberOfSeats, double length)> initialVehicles = new List<(string vehicleType, string name, string regNr, int parkingTicketNr, int numberOfEngines, int cylinderVolume, string fuelType, int numberOfSeats, double length)>();

        // Code to get input for initial vehicles from the user...

        return initialVehicles;
    }
}
