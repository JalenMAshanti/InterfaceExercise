using InterfaceExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Models
{
    internal class CarLot
    {

        public static List<IVehicleCompany> vehicles = new List<IVehicleCompany>();

        public static void DisplayVehiclesData()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayDetails();
                Console.WriteLine("_________________ \n");

            }
        }
    }
}
