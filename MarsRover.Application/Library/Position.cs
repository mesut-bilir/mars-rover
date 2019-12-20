namespace MarsRover.Application.Library
{
    public interface IPosition
    {
        int XCoordinate { get; set; }
        int YCoordinate { get; set; }
    }
    public class Position : IPosition
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public Position(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }
    }
}
