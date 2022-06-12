using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns.Factory
{
    public class Ship : ICalculatePriceTransport
    {
        public float GetPriceTransport(float distance)
        {
            return (90 * distance + 178 / 2) * 100;
        }
    }
}
