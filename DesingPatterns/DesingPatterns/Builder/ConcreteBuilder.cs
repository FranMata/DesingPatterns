namespace DesingPatterns.Builder
{
    public class ConcreteBuilder : IHouseBuilder
    {
        private House _house = new House();

        public ConcreteBuilder() => _Reset();

        private void _Reset() => _house = new House();
        public void BuildDoor(int quantity) => _house.Add(string.Format("Door: {0}", quantity));
        public void BuildFence() => _house.Add("Fence");
        public void BuildGarage() => _house.Add("Garage");
        public void BuildPool() => _house.Add("Pool");
        public void BuildRoof() => _house.Add("Roof");
        public void BuildWalls() => _house.Add("Walls");
        public void BuildWindows(int quantity) => _house.Add(string.Format("Windows: {0}", quantity));

        public House GetHouse()
        {
            House result = _house;
            _Reset();
            return result;
        }
    }
}