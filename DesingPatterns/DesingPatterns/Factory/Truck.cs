using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns.Factory
{
    public class Truck : ICalculatePriceTransport
    {
        public float GetPriceTransport(float distance)
        {
            return (float)(distance * 0.15 + 290);
        }
    }
}
