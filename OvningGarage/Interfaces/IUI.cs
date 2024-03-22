using System.Collections.Generic;

namespace OvningGarage.Interfaces
{
    public interface IUI
    {
        void DisplayMainMenu();
        void DisplayAddVehicleMenu();
        void DisplayRemoveVehicleMenu();
        void DisplayListAllVehiclesMenu();
        void DisplayCheckGarageEmptyMenu();
        void DisplayFindVehicleByRegNrMenu();
        void DisplayInitialPreDecideGarageMenu();

        List<(string vehicleType, string name, string regNr, int parkingTicketNr, int numberOfEngines, int cylinderVolume, string fuelType, int numberOfSeats, double length)> GetInitialVehiclesInput();

        void InitialPreDecideGarage(List<(string vehicleType, string name, string regNr, int parkingTicketNr, int numberOfEngines, int cylinderVolume, string fuelType, int numberOfSeats, double length)> initialVehicles);
    }
}
