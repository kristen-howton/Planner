using System;

namespace Planner
{
    class Building
    {
        private string _designer = "Kristen Howton";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }

        }
        //access private
        public string Designer
        {
            get
            {
                return _designer;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
        }

        public DateTime DateConstucted
        {
            get
            {
                return _dateConstructed;
            }
        }
        //this is a constructor
        public Building(string address)
        {
            _address = address;
        }
        //these are methods
        public void Purchase(string name)
        {
            _owner = name;
        }

        public void Constuct()
        {
            _dateConstructed = DateTime.Now;
        }
    }
}