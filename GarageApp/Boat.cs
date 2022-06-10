using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Vehicle1
{
    internal class Boat: Vehicle
    {
        public int Length { get; set; }

        public Boat(string reg, string color, int wheels, int length) : base(reg, color, wheels)
        {
            length = Length;
        }

        public override string Stats()
        {
            return base.Stats() + $"Length: {Length}";
        }
    }
}
