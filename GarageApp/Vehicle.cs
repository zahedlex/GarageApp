using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Vehicle1
{
    public abstract class Vehicle
    {
        public string Reg { get; set; }
        public string Color { get; set; }
        public int Wheels { get; set; }

        public Vehicle( string reg, string color, int wheels)
        {
            Reg = reg;
            Color = color;
            Wheels = wheels;
        }

        public virtual string Stats()
        {
            return $"Registration Number {Reg} | Color {Color} | Wheels {Wheels}";
        }
        

        public interface IVehicle
        {

            void Navigate();
            void EnlistVehicles();
            void EnlistTypeAndCount();
            void MaxCapacityGarage();
            void AddInitial();
            void FindReg();
            void SearchVehicle();
        }
    }
}






















        

