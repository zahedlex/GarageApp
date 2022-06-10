using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Vehicle1
{
    internal class Bus: Vehicle
    {
        public int NumberOfEngines { get; set; }
        
        public Bus (string reg, string color, int wheels,int numberOfEnginees) : base(reg, color, wheels)
        {
            NumberOfEngines = numberOfEnginees;
        }

        public override string Stats()
        {
            return base.Stats() + $"Number of Enginees: {NumberOfEngines}";
        }

    }
}
