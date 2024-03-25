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

        public virtual string GetVehicleInfo()
        {
            return $"Name: {Name}, Registration Number: {RegNr}, Parking Ticket Number: {ParkingTicketNr}";
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

        public override string GetVehicleInfo()
        {
            return base.GetVehicleInfo() + $", Number of Engines: {NumberOfEngines}, Cylinder Volume: {CylinderVolume}, Fuel Type: {FuelType}";
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

        public override string GetVehicleInfo()
        {
            return base.GetVehicleInfo() + $", Fuel Type: {FuelType}, Number of Seats: {NumberOfSeats}";
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

        public override string GetVehicleInfo()
        {
            return base.GetVehicleInfo() + $", Fuel Type: {FuelType}, Cylinder Volume: {CylinderVolume}";
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

        public override string GetVehicleInfo()
        {
            return base.GetVehicleInfo() + $", Fuel Type: {FuelType}, Length: {Length}";
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

        public override string GetVehicleInfo()
        {
            return base.GetVehicleInfo() + $", Number of Engines: {NumberOfEngines}, Number of Seats: {NumberOfSeats}, Length: {Length}";
        }
    }
}
