using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    class CarBuilder
    {

        private string name;
        private string bodyType;
        private string color;
        private int power;
        private string series;

        private static CarBuilder carBuilder = new CarBuilder();

        public CarBuilder withName(string name)
        {

            this.name = name;

            return carBuilder;
        }

        public CarBuilder withBodyType(String type)
        {

            bodyType = type;
            return carBuilder;
        }


        public Car build()
        {
            Car car = new Car
            {
                BodyType = bodyType,
                Name = name
            };

            return car;
        
        }
    }
}
