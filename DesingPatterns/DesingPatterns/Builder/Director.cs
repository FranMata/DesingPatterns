namespace DesingPatterns.Builder
{
    public class Director
    {
        private IHouseBuilder _houseBuilder;
        public IHouseBuilder HouseBuilder { set { _houseBuilder = value; } }

        public void BuildBasicHouse()
        {
            _houseBuilder.BuildDoor(2);
            _houseBuilder.BuildWalls();
            _houseBuilder.BuildRoof();
            _houseBuilder.BuildWindows(4);
        }

        public void BuildBasicHouseWithGarage()
        {
            _houseBuilder.BuildDoor(3);
            _houseBuilder.BuildWalls();
            _houseBuilder.BuildRoof();
            _houseBuilder.BuildWindows(6);
            _houseBuilder.BuildGarage();
        }

        public void BuildBasicHouseWithGarageAndPool()
        {
            _houseBuilder.BuildDoor(5);
            _houseBuilder.BuildWalls();
            _houseBuilder.BuildRoof();
            _houseBuilder.BuildWindows(5);
            _houseBuilder.BuildGarage();
            _houseBuilder.BuildPool();
        }
    }
}