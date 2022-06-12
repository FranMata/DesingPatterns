using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesingPatterns.Factory
{
    public class FactoryImplementation
    {
        public void Implementation()
        {
            var transports = new[]
            {
                new {name = "Truck", creator = (Creator) new TruckCreator()},
                new {name = "Ship", creator = (Creator) new ShipCreator()},
                new {name = "Plane", creator = (Creator) new PlaneCreator()}
            }.ToList();

            transports.ForEach(
                e => Console.WriteLine(
                    "{0} price shipping is: {1}", 
                    e.name, 
                    e.creator.GetFactory().GetPriceTransport(
                        new Random().Next()
                    )
                )
            );            
        }
    }
}
