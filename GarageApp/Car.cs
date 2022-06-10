using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Vehicle1

{
    internal class Car : Vehicle
    {
        public string FuelType { get; set; }

        public Car(string reg, string color, int wheels,string fuelType ) : base(reg, color, wheels)
        {
            FuelType = fuelType;
        }

        public override string Stats()
        {
            return base.Stats() + $"Fuel Type: {FuelType}";
        }
    }
}
