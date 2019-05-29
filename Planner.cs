using System;
using System.Collections.Generic;

namespace planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEight = new Building("512 8th Avenue"){
                Width = 6942.91,
                Depth = 4189.64,
                Stories = 4
            };

            Building FiveFourNineSix = new Building("549 6th Avenue"){
                Width = 8143.32,
                Depth = 12853.21,
                Stories = 10
            };

            Building FiveSevenEightFour = new Building("578 4th Avenue"){
                Width = 5903.41,
                Depth = 15938.12,
                Stories = 14
            };

            FiveOneTwoEight.Construct();
            FiveFourNineSix.Construct();
            FiveSevenEightFour.Construct();

            FiveOneTwoEight.Purchase("John");
            FiveFourNineSix.Purchase("Chris");
            FiveSevenEightFour.Purchase("Mary");

            List<Building> listOfBuildings = new List<Building>(){
                FiveOneTwoEight, FiveFourNineSix, FiveSevenEightFour
            };


            City megalopolis = new City("Megalopolis", "Blue", new DateTime (2017, 09, 27));

           foreach(Building building in listOfBuildings){
               megalopolis.AddBuildingToCity(building);
           }

            List<City> listOfCities = new List<City>(){
                megalopolis
            };


            foreach(City city in listOfCities){
                Console.WriteLine(city.Name);
                Console.WriteLine($"Established in {city.Established}");
                Console.WriteLine($"Mayor name: {city.Mayor}");
                Console.WriteLine($"- - - List of Buildings in {city.Name} - - -");
                foreach(Building building in city.BuildingsInCity){
                    Console.WriteLine(building.GetAddress());
                    Console.WriteLine("- - - - - - - - - -");
                    Console.WriteLine($"Designed by {building.GetDesigner()}");
                    Console.WriteLine($"Cosnstruced on {building.GetDate()}");
                    Console.WriteLine($"Owned by {building.GetOwner()}");
                    Console.WriteLine($"{building.Volume} cubic meters of space");
                    Console.WriteLine(" ");
                }
            }

        }
    }
}
