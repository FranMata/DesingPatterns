namespace DesingPatterns.Builder
{
    public interface IHouseBuilder
    {
        void BuildWalls();
        void BuildWindows(int quantity);
        void BuildRoof();
        void BuildDoor(int quantity);
        void BuildGarage();
        void BuildPool();
        void BuildFence();
    }
}
