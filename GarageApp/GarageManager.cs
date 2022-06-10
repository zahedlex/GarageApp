using GarageApp.Vehicle1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    internal class GarageManager
    {
        private GarageHandler handler;

        //public GarageManager(int size)
        //{
        //    handler = new GarageHandler(size);
        //}

        public void Navigate()
        {
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by entering the number \n(1, 2, 3 ,4, 5, 6, 7, 8, 0) of your choice"
                    + "\n1. List all parked vehicles"
                    + "\n2. List each type of vehicles"
                    + "\n3. Park vehicle"
                    + "\n4. Unpark Vehicle"
                    + "\n5. Put initial capacity of The Garage"
                    + "\n6. Set first vehicles to park"
                     + "\n7. Find Vehicle Throug registration number"
                     + "\n8. Search vehicle throug features"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        handler.PrintAllVehicles();
                        break;
                    case '2':
                        handler.EnlistTypeAndCount();
                        break;
                    case '3':
                        //var testCar = new Car("BIL111", "White", 4, "Electric");
                        Console.WriteLine("Enter vehicle reg number to park");
                        var regnr = Console.ReadLine();
                        var testCar = new Car("BIL111", "Red", 4, "Gasoline");
                        handler.Park(testCar);
                        break;
                    case '4':
                        Console.WriteLine("Enter vehicle reg number to unpark");
                        
                         var regnrToUnpark = Console.ReadLine();
                        //var regnr = "BIL222";
                        handler.Unpark(regnrToUnpark);
                        break;
                    case '5':
                        handler.SetSize();
                        break;
                    case '6':

                        handler.SeedData();
                        break;
                    case '7':

                        Console.WriteLine("Enter vehicle reg number to find");
                        var regnrToFind = Console.ReadLine();
                        //var regnrToFind = "BIL111";
                        handler.FindByRegNr(regnrToFind);
                        break;
                    case '8':
                       // SearchVehicle();
                        break;

                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5, 6, 7, 8)");
                        break;
                }
            }
        }

        
    }
}
