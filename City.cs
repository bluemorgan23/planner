using System;
using System.Collections.Generic;

namespace planner
{
    class City {
        public City(string name, string mayor, DateTime est) {
            Name = name;
            Mayor = mayor;
            Established = est;
        }

        public string Name {get; set;}
        public string Mayor {get; set;}
        public DateTime Established {get; set;}
        public List<Building> BuildingsInCity = new List<Building>();
        public void AddBuildingToCity(Building building){
            BuildingsInCity.Add(building);
        }
        
    }
}