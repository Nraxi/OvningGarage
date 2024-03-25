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
        Console.WriteLine("3. List All Vehicles");
        Console.WriteLine("4. Check Garage Empty");
        Console.WriteLine("5. Find Vehicle By Registration Number");
        Console.WriteLine("6. Initialize Garage with Initial Vehicles");
        Console.WriteLine("0. Exit");
    }

    public void DisplayAddVehicleMenu(GarageHandler garageHandler, int capacity)
    {
        HandleAddVehicleMenu.VehicleMenu(garageHandler, capacity);
    }

    public void DisplayRemoveVehicleMenu()
    {
        HandleRemoveVehicleMenu.VehicleMenu();
    }

    public void DisplayListAllVehiclesMenu()
    {
        HandleListAllVehiclesMenu.VehicleMenu();

    }

    public void DisplayCheckGarageEmptyMenu(GarageHandler garageHandler, int capacity)
    {

        HandleCheckGarageEmptyMenu.VehicleMenu(garageHandler, capacity);

    }

    public void DisplayFindVehicleByRegNrMenu()
    {
        HandleFindVehicleByRegNrMenu.VehicleMenu();
    }

    public void DisplayInitialPreDecideGarageMenu()
    {
        HandleInitialPreDecideGarageMenu.VehicleMenu();
    }


}
