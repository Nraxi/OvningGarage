using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningGarage.Interfaces
{
    public interface IVehicle
    {
        string Name { get; set; }
        string RegNr { get; set; }
    }
}
