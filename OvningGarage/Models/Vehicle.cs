namespace OvningGarage.Models
{
    public class Vehicle
    {
        public int ParkingTicketNr { get; set; }
        public string Name { get; set; }
        public string RegNr { get; set; }

        public Vehicle(string name, string regNr, int parkingTicketNr)
        {
            Name = name;
            RegNr = regNr;
            ParkingTicketNr = parkingTicketNr;
        }
    }

    public class Airplane : Vehicle
    {
        public int NumberOfEngines { get; set; }
        public int CylinderVolume { get; set; }
        public string FuelType { get; set; }

        public Airplane(string name, string regNr, int numberOfEngines, int cylinderVolume, string fuelType, int parkingTicketNr)
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

        public Motorcycle(string name, string regNr, string fuelType, int numberOfSeats, int parkingTicketNr)
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

        public Car(string name, string regNr, string fuelType, int cylinderVolume, int parkingTicketNr)
            : base(name, regNr, parkingTicketNr)
        {
            FuelType = fuelType;
            CylinderVolume = cylinderVolume;
        }
    }

    public class Bus : Vehicle
    {
        public string FuelType { get; set; }
        public double Length { get; set; }

        public Bus(string name, string regNr, double length, string fuelType, int parkingTicketNr)
            : base(name, regNr, parkingTicketNr)
        {
            Length = length;
            FuelType = fuelType;
        }
    }

    public class Boat : Vehicle
    {
        public int NumberOfEngines { get; set; }
        public int NumberOfSeats { get; set; }
        public double Length { get; set; }

        public Boat(string name, string regNr, int numberOfEngines, int numberOfSeats, double length, int parkingTicketNr)
            : base(name, regNr, parkingTicketNr)
        {
            NumberOfEngines = numberOfEngines;
            NumberOfSeats = numberOfSeats;
            Length = length;
        }
    }
}
