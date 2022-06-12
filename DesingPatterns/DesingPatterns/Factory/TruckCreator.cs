namespace DesingPatterns.Factory
{
    public class TruckCreator : Creator
    {
        public override ICalculatePriceTransport GetFactory() => new Truck();
    }
}