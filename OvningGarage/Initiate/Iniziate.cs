using OvningGarage.Handlers;
using OvningGarage.Interfaces;
using OvningGarage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningGarage.Initiate
{
    internal class Iniziate
    {
        public static void InitializeGarage()
        {
            Console.WriteLine("Welcome to the Garage Initialization!");

            // Be användaren att ange antalet platser i garaget
            Console.WriteLine("Please enter the number of parking spots in the garage:");
            int capacity = int.Parse(Console.ReadLine()!);

            // Skapa en instans av GarageHandler med angivet kapacitet
            var garageHandler = new GarageHandler(capacity);

            // Lägg till några fordon i garaget för att testa
            garageHandler.AddCarToGarage("Volvo", "ABC123", 1, "gasoline", 2000);
            garageHandler.AddMotorcycleToGarage("Honda", "XYZ789", 2, "Petrol", 1);
            garageHandler.AddAirplaneToGarage("Boeing", "DEF456", 3, 4, 5000, "Jet");

            // Visa alla fordon i garaget
            garageHandler.ListAllVehicles();

            // Vänta på användarens bekräftelse för att fortsätta
            Console.WriteLine("Press Enter to proceed...");
            Console.ReadLine();

            // Kontrollera om det finns några fordon kvar i garaget
            while (!garageHandler.CheckGarageEmpty())
            {
                Console.WriteLine("There are vehicles in the garage. Please remove them before proceeding.");
                Console.WriteLine("Enter the number tha u want to del");
                var input = Console.ReadLine();
                int parkingTicketNr;
                if (int.TryParse(input, out parkingTicketNr))
                {
                    garageHandler.RemoveVehicle(parkingTicketNr);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid parking ticket number.");
                    continue; // Gå tillbaka till början av loopen för att låta användaren försöka igen
                }
            }
        

            // Om garaget är tomt och antalet platser är angivet, starta Startup
            if (capacity > 0)
            {
                Console.WriteLine("Redirecting to Startup...");
                Console.ReadKey();
                StartStartup();
            }
            else
            {
                Console.WriteLine("Garage is empty...");
                Console.ReadKey();
                StartStartup();
            }
        }

        // Starta Startup
        private static void StartStartup()
        {
            IUI ui = new ConsoleUI();
            var startup = new Startup(ui);
            startup.Run();
        }
    }
}