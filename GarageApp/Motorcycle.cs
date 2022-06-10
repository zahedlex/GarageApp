using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Vehicle1
{
    internal class Motorcycle: Vehicle
    {
        public int CylinderVolume { get; set; }

        public Motorcycle(string reg, string color, int wheels,int cylinderVolume) : base(reg, color, wheels)
        {
            cylinderVolume = CylinderVolume;
        }

        public override string Stats()
        {
            return base.Stats() + $"Cylinder Volume : {CylinderVolume}";
        }
    }
}
