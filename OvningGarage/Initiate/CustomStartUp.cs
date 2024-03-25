using OvningGarage.Handlers;
using OvningGarage.Interfaces;
using System;

namespace OvningGarage.Initiate
{
    public class CustomStartUp
    {
        private readonly IUI ui;
        private readonly int capacity;
        private readonly GarageHandler garageHandler;

        public CustomStartUp(IUI ui, int capacity, GarageHandler garageHandler)
        {
            this.ui = ui;
            this.capacity = capacity;
            this.garageHandler = garageHandler;
        }

        public void Run()
        {
            bool exit = false;
            do
            {
                ui.DisplayMainMenu();
                string choice = Console.ReadLine()!;

                if (choice == null)
                {
                    Console.WriteLine(" Handle EOF (Ctrl + Z)");
                    // Handle EOF (Ctrl + Z)
                    break;
                }

                switch (choice.Trim())
                {
                    case "1":
                        ui.DisplayAddVehicleMenu(garageHandler, capacity);
                        // Implementera logiken för att lägga till fordon
                        break;
                    case "2":
                        ui.DisplayRemoveVehicleMenu(garageHandler);
                        // Implementera logiken för att ta bort fordon
                        break;
                    case "3":
                        ui.DisplayListAllVehiclesMenu(garageHandler);
                        // Implementera logiken för att lista alla fordon
                        break;
                    case "4":
                        ui.DisplayCheckGarageEmptyMenu(garageHandler);
                        // Implementera logiken för att kontrollera om garaget är tomt
                        break;
                    case "5":
                        ui.DisplayFindVehicleByRegNrMenu(garageHandler);
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
