using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    class Car
    {

        private string name;
        private string bodyType;
        private string color;
        private int power;
        private string series;

        public string Name { get => name; set => name = value; }
        public string BodyType { get => bodyType; set => bodyType = value; }
        public string Color { get => color; set => color = value; }
        public int Power { get => power; set => power = value; }
        public string Series { get => series; set => series = value; }
    }
}
