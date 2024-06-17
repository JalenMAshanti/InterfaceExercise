using InterfaceExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Models
{
    internal class SUV : IVehicleCompany
    {
        public int RowsAmount { get; set; }
        public bool HasSunRoof { get; set; }

        // Interface Members / IVehicle
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        //Interface Members / ICompany
        public string Logo { get; set; }
        public string Slogan { get; set; }


        public SUV()
        {

        }

        public SUV(int rowsAmount, bool hasSunRoof, string make, string model, int year, string logo, string slogan)
        {
            RowsAmount = rowsAmount;
            HasSunRoof = hasSunRoof;
            Make = make;
            Model = model;
            Year = year;
            Logo = logo;
            Slogan = slogan;
        }

        public void Drive()
        {
            Console.WriteLine("Driving an SUV");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Logo: {Logo}");
            Console.WriteLine($"Slogan: {Slogan}");
            Console.WriteLine($"Amount of Rows: {RowsAmount}");
            Console.WriteLine($"Has a Sun Roof: {HasSunRoof}");
            Console.WriteLine("");
            Drive();

        }
    }
}
