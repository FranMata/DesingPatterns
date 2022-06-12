namespace DesingPatterns.Factory
{
    public class PlaneCreator : Creator
    {
        public override ICalculatePriceTransport GetFactory() => new Plane();
    }
}