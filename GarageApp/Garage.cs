using GarageApp.Vehicle1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {

        private T[] vehicles;
        public int MaxCapacity { get; }

        public Garage(int capacity)
        {
            //Validate
            vehicles = new T[capacity];
            MaxCapacity = capacity;
        }



        public bool Park(T vehicle)
        {
            for(var i = 0; i < vehicles.Length; i++)
            {
                if(vehicles[i] is null)
                {
                    vehicles[i] = vehicle; // här sker parkering
                    return true; 
                }
            }
            return false;
        }

       

        public bool Unpark(string regnr)
        {
            for(int i = 0; i < vehicles.Length; i++)
            {
                if(vehicles[i].Reg == regnr)
                {
                    vehicles[i] = null;
                    return true;
                }
            }
            return false;


        }


        public IEnumerator<T> GetEnumerator()
        {
            for(var i = 0; i < vehicles.Length; i++)
            {
                if(vehicles[i] is not null)
                {
                    yield return vehicles[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



    }

    

}
