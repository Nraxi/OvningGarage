using OvningGarage.Handlers;
using System.Collections.Generic;

namespace OvningGarage.Interfaces
{
    public interface IUI
    {
        void DisplayMainMenu();
        void DisplayAddVehicleMenu(GarageHandler garageHandler);
        void DisplayRemoveVehicleMenu(GarageHandler garageHandler);
        void DisplayListAllVehiclesMenu(GarageHandler garageHandler);
        void DisplayCheckGarageEmptyMenu(GarageHandler garageHandler, int capacity);

        void DisplayFindVehicleByRegNrMenu();
        void DisplayInitialPreDecideGarageMenu();

      
    }
}
