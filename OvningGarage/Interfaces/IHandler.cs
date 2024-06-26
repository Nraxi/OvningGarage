﻿using OvningGarage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningGarage.Interfaces
{
    public interface IHandler 
    {
        void AddVehicleToGarage(string vehicleType, string name, string regNr, int parkingTicketNr, int numberOfEngines, int cylinderVolume, string fuelType, int numberOfSeats, double length);
        void InitialPreDecideGarage(List<(string vehicleType, string name, string regNr, int parkingTicketNr, int numberOfEngines, int cylinderVolume, string fuelType, int numberOfSeats, double length)> initialVehicles);
        bool RemoveVehicleFromGarage(int parkingTicketNr);
       
        void CheckGarageEmpty();
        void FindVehicleByRegNr(string regNr);
    }
}
