using OvningGarage.Handlers;
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
        Console.WriteLine("3. List All Vehicles / List Vehicles types and numbers");
        Console.WriteLine("4. Check Garage Empty");
        Console.WriteLine("5. Find Vehicle By Registration Number");
        Console.WriteLine("6. Initialize Garage with Initial Vehicles");
        Console.WriteLine("0. Exit");
    }

    public void DisplayAddVehicleMenu(GarageHandler garageHandler)
    {
        HandleAddVehicleMenu.VehicleMenu(garageHandler);
    }

    public void DisplayRemoveVehicleMenu(GarageHandler garageHandler)
    {
        HandleRemoveVehicleMenu.VehicleMenu(garageHandler);
    }

    public void DisplayListAllVehiclesMenu(GarageHandler garageHandler)
    {
        HandleListAllVehiclesMenu.VehicleMenu(garageHandler);

    }

    public void DisplayCheckGarageEmptyMenu(GarageHandler garageHandler, int capacity)
    {

        HandleCheckGarageEmptyMenu.VehicleMenu(garageHandler);

    }

    public void DisplayFindVehicleByRegNrMenu(GarageHandler garageHandler)
    {
        HandleFindVehicleByRegNrMenu.VehicleMenu(garageHandler);
    }

    public void DisplayInitialPreDecideGarageMenu()
    {
        HandleInitialPreDecideGarageMenu.VehicleMenu();
    }


}
