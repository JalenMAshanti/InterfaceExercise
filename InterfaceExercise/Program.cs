using InterfaceExercise.Models;
using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            PopulateCarLot();
            CarLot.DisplayVehiclesData();


            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }

        public static void PopulateCarLot() 
        {
            Car suburu = new Car(true, "Leather", "Suburu", "Crosstrek Premium", 2024, "SuburuLogo.Png", "It's what makes Subaru, Subaru");
            Car mazda = new Car(true, "Leather", "Mazda", "MX-5 Miata", 2023, "MazdaLogo.Png", "Driving Matters");
            Truck ford = new Truck(98.4, 22000, "Ford", "F-250", 2022, "FordLogo.Png", "Built Ford Tough");
            SUV jeep = new SUV(3, true, "Jeep", "Grand Cherokee L", 2024, "JeepLogo.Png", "Go Anywhere, Do Anything");

            CarLot.vehicles.Add(suburu);
            CarLot.vehicles.Add(mazda);
            CarLot.vehicles.Add(ford);
            CarLot.vehicles.Add(jeep);
        }
    }
}
