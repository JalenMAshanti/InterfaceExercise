using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Interfaces
{
    internal interface IVehicleCompany : IVehicle, ICompany
    {
        public void DisplayDetails();
    }
}
