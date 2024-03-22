﻿using System;

namespace OvningGarage.UI.Menus
{
    public class HandleFindVehicleByRegNrMenu
    {
        public static void VehicleMenu()
        {
            string input;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Find Vehicle By a Registration Number:");
                Console.WriteLine("1. Press 1, to move forward");
                Console.WriteLine("0. Back to Main Menu");

                input = Console.ReadLine()!;

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter registration number:");
                        Console.ReadLine();
                        Console.WriteLine("Veichle INFO...");
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