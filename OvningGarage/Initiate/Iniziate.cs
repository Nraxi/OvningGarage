﻿using OvningGarage.Handlers;
using OvningGarage.Interfaces;
using OvningGarage.Models;
using OvningGarage.UI.Menus;
using System;

namespace OvningGarage.Initiate
{
    internal class Iniziate
    {
        public static void InitializeGarage()
        {
            Console.WriteLine("Welcome to the Garage Initialization!");

            // Be användaren att ange om de vill hoppa över initialiseringen
            Console.WriteLine("Do you want to skip the initialization and go directly to startup? (Yes/No)");
            string skipInput = Console.ReadLine()!;
            if (skipInput.ToLower() == "yes")
            {
                Console.WriteLine("Skipping initialization. Redirecting to Startup...");
                Console.ReadKey();
                StartStartup(10); // Ange ett godtyckligt värde för capacity här
                return;
            }

            // Be användaren att ange antalet platser i garaget
            Console.WriteLine("Please enter the number of parking spots in the garage:");
            int capacity;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out capacity))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    continue;
                }

                if (capacity <= 3)
                {
                    Console.WriteLine("Capacity must be greater than 3. Please enter a higher value.");
                    continue;
                }

                break;
            }

            // Skapa en instans av GarageHandler med angivet kapacitet
            var garageHandler = new GarageHandler(capacity);

            // Lägg till några fordon i garaget för att testa
            garageHandler.AddCarToGarage("Volvo", "ABC123", "gasoline", 2000, capacity); // Parkeringsticketnummer tilldelas automatiskt
            garageHandler.AddMotorcycleToGarage("Honda", "XYZ789", "Petrol", 1, capacity); // Parkeringsticketnummer tilldelas automatiskt
            garageHandler.AddAirplaneToGarage("Boeing", "DEF456", 4, 5000, "Jet", capacity); // Parkeringsticketnummer tilldelas automatiskt

            // Visa alla fordon i garaget
            garageHandler.ListAllVehicles();

            // Räkna antalet lediga platser i garaget
            int availableSpots = capacity - garageHandler.TotalVehiclesCount();
            Console.WriteLine($"There are now {availableSpots} available spots in the Garage. ");
            // Vänta på användarens bekräftelse för att fortsätta
            Console.WriteLine("Press Enter to proceed...");
            Console.ReadLine();

            // Kontrollera om det finns några fordon kvar i garaget
            while (!GarageHandler.CheckGarageEmpty(garageHandler.GetGarage()))
            {
                Console.WriteLine("There are still vehicles in the garage. Please remove them before proceeding.");
                Console.WriteLine("Enter the  parking ticket number that you want to delete:");
                var input = Console.ReadLine();
                int parkingTicketNr;
                if (int.TryParse(input, out parkingTicketNr))
                {
                    garageHandler.RemoveVehicle(parkingTicketNr);
                    availableSpots++;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid parking ticket number.");
                    continue; // Gå tillbaka till början av loopen för att låta användaren försöka igen
                }
            }

            // Uppdatera antalet lediga platser i garaget efter att fordon har tagits bort
            availableSpots = capacity - garageHandler.TotalVehiclesCount();

            // Om garaget är tomt och antalet platser är angivet, starta Startup
            if (availableSpots == capacity)
            {
                Console.WriteLine($"The total Capacity of the Garage is now: {availableSpots}");
                Console.WriteLine("Press Enter to proceed...");
                Console.ReadLine();
                Console.WriteLine("Redirecting to Startup...");
                Console.ReadKey();
                StartStartup(capacity);
            }
            else
            {
                Console.WriteLine("Garage is not empty. Please remove remaining vehicles.");
                Console.ReadKey();
            }
        }

        // Starta Startup
        private static void StartStartup(int capacity)
        {
            IUI ui = new ConsoleUI();
            var startup = new Startup(ui, capacity);
            startup.Run();
        }
    }
}
