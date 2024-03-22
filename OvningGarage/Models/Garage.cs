using System;
using System.Collections;
using System.Collections.Generic;

namespace OvningGarage.Models
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private T[] vehicles;
        private int count;
        private int capacity;

        public Garage(int capacity)
        {
            this.capacity = capacity;
            vehicles = new T[capacity];
            count = 0;
        }

        public void AddVehicle(int parkingTicketNr, T vehicle)
        {
            if (count < capacity)
            {
                vehicles[parkingTicketNr] = vehicle;
                count++;
            }
            else
            {
               Console.WriteLine("The Garage is full.");
            }
        }

        public bool RemoveVehicle(int parkingTicketNr)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null && vehicles[i].ParkingTicketNr == parkingTicketNr)
                {
                    vehicles[i] = null!; // Mark the slot as null
                    count--;
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T vehicle in vehicles)
            {
                if (vehicle != null)
                {
                    yield return vehicle;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
