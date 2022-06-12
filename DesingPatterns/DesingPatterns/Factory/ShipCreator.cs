namespace DesingPatterns.Factory
{
    public class ShipCreator : Creator
    {
        public override ICalculatePriceTransport GetFactory() => new Ship();
    }
}