using InterfaceExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Models
{
    internal class Car : IVehicleCompany
    {
        public bool IsFourDoor { get; set; }
        public string SeatMaterial { get; set; }

        // Interface Members / IVehicle
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        //Interface Members / ICompany
        public string Logo { get; set; }
        public string Slogan { get; set; }


        public Car()
        {

        }

        public Car(bool isFourDoor, string seatMaterial, string make, string model, int year, string logo, string slogan)
        {
            IsFourDoor = isFourDoor;
            SeatMaterial = seatMaterial;
            Make = make;
            Model = model;
            Year = year;
            Logo = logo;
            Slogan = slogan;
        }

        public void Drive()
        {
            Console.WriteLine("Driving a Car");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Logo: {Logo}");
            Console.WriteLine($"Slogan: {Slogan}");
            Console.WriteLine($"Four Door: {IsFourDoor}");
            Console.WriteLine($"Seat Material: {SeatMaterial}");
            Console.WriteLine("");
            Drive();

        }
    }
}
