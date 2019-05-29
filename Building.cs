using System;

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
}
