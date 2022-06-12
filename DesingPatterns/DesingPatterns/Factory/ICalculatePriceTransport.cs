using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns.Factory
{
    public interface ICalculatePriceTransport
    {
        float GetPriceTransport(float distance);
    }
}
