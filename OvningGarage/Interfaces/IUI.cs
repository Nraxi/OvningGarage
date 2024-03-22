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

      
    }
}
