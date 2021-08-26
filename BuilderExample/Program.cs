using System;

namespace BuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new CarBuilder().withBodyType("cupe").withName("Opel").build();
            Car car2 = new CarBuilder().withBodyType("sport").withName("ferrary").build();

            Console.WriteLine(car.Name);
            Console.WriteLine(car2.Name);
        }
    }
}
