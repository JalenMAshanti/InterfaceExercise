using InterfaceExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Models
{
    public class Truck : IVehicleCompany
    {
        public double TruckBedSize { get; set; }
        public int WeightCarryLimit { get; set; }

        //Interface Members / IVehicle
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        //Interface Members / ICompany
        public string Logo { get; set; }
        public string Slogan { get; set; }

        public Truck()
        {

        }

        public Truck(double truckBedSize, int weightCarryLimit, string make, string model, int year, string logo, string slogan)
        {
            TruckBedSize = truckBedSize;
            WeightCarryLimit = weightCarryLimit;
            Make = make;
            Model = model;
            Year = year;
            Logo = logo;
            Slogan = slogan;
        }

        public void Drive()
        {
            Console.WriteLine("Driving a truck");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Logo: {Logo}");
            Console.WriteLine($"Slogan: {Slogan}");
            Console.WriteLine($"Truck Bed Size: {TruckBedSize}");
            Console.WriteLine($"Towing limit: {WeightCarryLimit}");
            Console.WriteLine("");
            Drive();

        }
    }
}
