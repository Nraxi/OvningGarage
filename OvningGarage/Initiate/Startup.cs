using OvningGarage.Handlers;
using OvningGarage.Interfaces;

namespace OvningGarage.Initiate
{
    public class Startup
    {
        private readonly IUI ui;
        private int capacity;

        public Startup(IUI ui, int capacity)
        {
            this.ui = ui;
            this.capacity = capacity;
        }

        public void Run()
        {
            bool exit = false;
            GarageHandler garageHandler = new GarageHandler(capacity);
            do
            {
                ui.DisplayMainMenu();
                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        ui.DisplayAddVehicleMenu(garageHandler);
                        // Implementera logiken för att lägga till fordon
                        break;
                    case "2":
                        ui.DisplayRemoveVehicleMenu();
                        // Implementera logiken för att ta bort fordon
                        break;
                    case "3":
                        ui.DisplayListAllVehiclesMenu(garageHandler);
                        // Implementera logiken för att lista alla fordon
                        break;
                    case "4":
                        ui.DisplayCheckGarageEmptyMenu(garageHandler, capacity);
                        // Implementera logiken för att kontrollera om garaget är tomt
                        break;
                    case "5":
                        ui.DisplayFindVehicleByRegNrMenu();
                        // Implementera logiken för att hitta fordon efter registreringsnummer
                        break;
                    case "6":
                        ui.DisplayInitialPreDecideGarageMenu();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }
            } while (!exit);
        }
    }
}
