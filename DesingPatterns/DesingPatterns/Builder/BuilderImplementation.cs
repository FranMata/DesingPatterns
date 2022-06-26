using System;

namespace DesingPatterns.Builder
{
    public class BuilderImplementation
    {
        public void Implementation()
        {
            Director director = new Director();
            ConcreteBuilder concreteBuilder = new ConcreteBuilder();
            director.HouseBuilder = concreteBuilder;

            Console.WriteLine("BASIC HOUSE");
            director.BuildBasicHouse();
            Console.WriteLine(concreteBuilder.GetHouse().GetPartsList());

            Console.WriteLine("BASIC HOUSE WITH GARAGE");
            director.BuildBasicHouseWithGarage();
            Console.WriteLine(concreteBuilder.GetHouse().GetPartsList());

            Console.WriteLine("BASIC HOUSE WITH GARAGE AND POOL");
            director.BuildBasicHouseWithGarageAndPool();
            Console.WriteLine(concreteBuilder.GetHouse().GetPartsList());
        }
    }
}
