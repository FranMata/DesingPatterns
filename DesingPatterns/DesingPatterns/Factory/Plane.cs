using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns.Factory
{
    public class Plane : ICalculatePriceTransport
    {
        public float GetPriceTransport(float distance)
        {
            return distance * 80 + 200 + 20 + 904;
        }        
    }

}
