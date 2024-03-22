﻿using System;
using OvningGarage.Interfaces;

namespace OvningGarage.UI.Menus
{
    public class HandleInitialPreDecideGarageMenu
    {
        public static void VehicleMenu(IUI ui)
        {
            string input;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Do you want to pre-decide the garage contents?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("0. Back to Main Menu");

                input = Console.ReadLine()!;

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter pre-decide the garage contents");
                        var initialVehicles = ui.GetInitialVehiclesInput();
                        ui.InitialPreDecideGarage(initialVehicles);
                        Console.WriteLine("Garage initialized with pre-decided contents.");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid number.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}