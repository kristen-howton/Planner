using System;

namespace Planner
{
    class Building
    {
        private string _designer;
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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}