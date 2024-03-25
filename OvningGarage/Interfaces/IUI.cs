using OvningGarage.Handlers;
using System.Collections.Generic;

namespace OvningGarage.Interfaces
{
    public interface IUI
    {
        void DisplayMainMenu();
        void DisplayAddVehicleMenu(GarageHandler garageHandler, int capacity);
        void DisplayRemoveVehicleMenu(GarageHandler garageHandler);
        void DisplayListAllVehiclesMenu(GarageHandler garageHandler);
        void DisplayCheckGarageEmptyMenu(GarageHandler garageHandler);

        void DisplayFindVehicleByRegNrMenu(GarageHandler garageHandler);
        void DisplayHandleSearchAttribute(GarageHandler garageHandler);



    }
}
