using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns.Factory
{
    public abstract class Creator
    {
        public abstract ICalculatePriceTransport GetFactory();
    }
}
