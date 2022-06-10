using GarageApp.Vehicle1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GarageApp;


class Tester
{
    static void Main(string[] args)
    {

        //var garage = new Garage<Vehicle>(5);

        //Airplane airplane1 = new Airplane("ABC123", "red", 4,100);
        //Airplane airplane2 = new Airplane("ABD124", "green", 4, 200);
        //Airplane airplane3 = new Airplane("ABE125", "blue", 4, 150);

        //Boat boat1 = new Boat("BAB221", "red", 0, 20);

        //Bus bus1 = new Bus("BBC321", "grren", 4, 4);
        //Bus bus2 = new Bus("BBD322", "blue", 4, 4);

        //Car car1 = new Car("CAA322", "Black", 4, "Gasoline");
        //Car car2 = new Car("CAB323", "Blue", 4, "Gasoline");

        //Motorcycle motorcycle1 = new Motorcycle("MAC423", "Black", 2, 750);







        //var searchResult = garage.Where(v => v.Color == "Black").ToList();

        

        var manager = new GarageManager();
        //manager.SetSize();

        manager.Navigate();

    }
}

