using GarageApp.Vehicle1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    internal class GarageHandler
    {
        private Garage<Vehicle> garage;

        public GarageHandler(int size)
        {
            garage = new Garage<Vehicle>(size);
        }


        public void SetSize()
        {
            do
            {
                Console.WriteLine("Enter size of garage ");       
                var input = Console.ReadLine();



                if (!Int32.TryParse(input, out int size) && size < 0)
                {
                    Console.WriteLine("Size must be a positive number!");
                }

                else
                {
                    var handler = new GarageHandler(size);
                    Console.WriteLine($"Size of garage set to {size}");
                    return;
                } 

            } while (true);
        }

        public void PrintAllVehicles()
        {
            foreach(var vehicle in garage)
            {
                Console.WriteLine(vehicle.Stats());
            }
        }

        public void EnlistTypeAndCount()
        {

            //Alt 1: skapa varibaler som räknar varje typ
            //Alt 2: kolla upp hur man använder LINQ-funktionen GroupBy

            var GroupByV = garage.GroupBy(v => v.Reg.Count());


            foreach(var vehicle in GroupByV)
            {
                Console.WriteLine(vehicle.GetType().Name);
                

            }
        }


        public void Park(Vehicle vehicle)
        {
            if (garage.Park(vehicle))
            {
                Console.WriteLine($"Successfully parked {vehicle.GetType().Name}");
            }
            else
            {
                Console.WriteLine($"Unable to park {vehicle.GetType().Name}, garage is full!");
            }
        }


        public void Unpark(string regnr)
        {
            if (garage.Unpark(regnr))
            {
                Console.WriteLine($"Sucesfully unparked {regnr.GetType().Name}");
            }
            else
            {
                Console.WriteLine($"Unable to unpark {regnr.GetType().Name}");
            }
        }

        public void FindByRegNr(string regnr)
        {
            foreach(var vehicle in garage)
            {
                if(vehicle.Reg == regnr)
                {   
                    Console.WriteLine(vehicle.Stats());
                }
            }

            //Console.WriteLine(garage.First(v => v.Reg == regnr).Stats());
        }

        public void SearchVehicle()
        {



            var searchResult = garage.Where(v => v.Color == "Black");

            searchResult = searchResult.Where(v => v.Wheels == 4);

            



        }






        public void SeedData()
        {
            Park(new Airplane("ABC123", "red", 4, 100));
            Park(new Airplane("ABE125", "blue", 4, 150));

            Park(new Boat("BAB221", "red", 0, 20));

            Park(new Bus("BBC321", "grren", 4, 4));
            Park(new Bus("BBD322", "blue", 4, 4));

            Park(new Car("CAA322", "Black", 4, "Gasoline"));
            Park(new Car("CAB323", "Blue", 4, "Gasoline"));

            Park(new Motorcycle("MAC423", "Black", 2, 750));


        }
    }
}
