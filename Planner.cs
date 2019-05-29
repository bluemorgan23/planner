using System;
using System.Collections.Generic;

namespace planner
{
    class Building {
        private string _designer = "Chris Morgan";

        public string GetDesigner() {
            return _designer;
        }

        private DateTime _dateConstructed {get; set;}

        public DateTime GetDate() {
            return _dateConstructed;
        }

        private string _address {get; set;}

        public string GetAddress() {
            return _address;
        }

        private string _owner {get; set;}

        public string GetOwner() {
            return _owner;
        }

        public int Stories {get; set;}

        public double Width {get; set;}

        public double Depth {get; set;}

        public double Volume 
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public Building(string address) {
            _address = address;
        }

        public void Construct() {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string buyerName) {
            _owner = buyerName;
        }
     }
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

            foreach(Building building in listOfBuildings){
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
