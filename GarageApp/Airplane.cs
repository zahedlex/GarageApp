using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Vehicle1
{
    internal class Airplane: Vehicle
    {
        public int NumbeOfSeats { get; set; }

        public Airplane(string reg, string color, int wheels, int numberOfSeats): base(reg,color,wheels)
        { 
            NumbeOfSeats = numberOfSeats;
        
        }

        public override string Stats()
        {
            return base.Stats() + $"Number of Seats: {NumbeOfSeats}";
        }
    }

    


}
