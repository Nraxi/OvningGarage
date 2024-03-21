using OvningGarage.Interfaces;

namespace OvningGarage.Models
{
    public class Vehicle : IVeichle
    {
        public int ParkingTicketNr { get; set; }
        public string Name { get; set; }
        public string RegNr { get; set; }


        public Vehicle(string name, string regNr, int parkingTicketNr)
        {
            ParkingTicketNr = parkingTicketNr;
            Name = name;
            RegNr = regNr;
        }
    }

    public class Airplane : Vehicle
    {
        public int NumberOfEngines { get; set; }
        public int CylinderVolume { get; set; }
        public string FuelType { get; set; }
        public Airplane(string name, string regNr, int parkingTicketNr, int numberOfEngines, int cylinderVolume, string fuelType)
            : base(name, regNr, parkingTicketNr)
        {
            NumberOfEngines = numberOfEngines;
            CylinderVolume = cylinderVolume;
            FuelType = fuelType;
        }
    }



    public class Motorcycle : Vehicle
    {
        public string FuelType { get; set; }
        public int NumberOfSeats { get; set; }
        public Motorcycle(string name, string regNr, int parkingTicketNr, string fuelType, int numberOfSeats)
            : base(name, regNr, parkingTicketNr)
        {
            FuelType = fuelType;
            NumberOfSeats = numberOfSeats;
        }
    }

    public class Car : Vehicle
    {
        public string FuelType { get; set; }
        public int CylinderVolume { get; set; }
        public Car(string name, string regNr, int parkingTicketNr, string fuelType, int cylinderVolume)
            : base(name, regNr, parkingTicketNr)
        {
            FuelType = fuelType;
            CylinderVolume = cylinderVolume;
        }
    }

    public class Bus : Vehicle
    {
        public string FuelType { get; set; }
        public double Lenght { get; set; }
        public Bus(string name, string regNr, int parkingTicketNr, double lenght, string fuelType)
            : base(name, regNr, parkingTicketNr)
        {
            Lenght = lenght;
            FuelType = fuelType;
        }
    }

    public class Boat : Vehicle
    {
        public int NumberOfEngines { get; set; }
        public int NumberOfSeats { get; set; }
        public double Length { get; set; }
        public Boat(string name, string regNr, int parkingTicketNr, int numberOfEngines, int numberOfSeats, double length)
            : base(name, regNr, parkingTicketNr)
        {
            NumberOfEngines = numberOfEngines;
            NumberOfSeats = numberOfSeats;
            Length = length;
        }
    }
}
