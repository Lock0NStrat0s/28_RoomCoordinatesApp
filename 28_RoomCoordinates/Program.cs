namespace _28_RoomCoordinates;

public class Program
{
    static void Main(string[] args)
    {
        Coordinate coord = new Coordinate(3,3);
        Coordinate coord2 = new Coordinate(2,3);
        Coordinate coord3 = new Coordinate(2,2);

        Console.WriteLine(Coordinate.CheckAdjacent(coord, coord2));
        Console.WriteLine(Coordinate.CheckAdjacent(coord2, coord3));
        Console.WriteLine(Coordinate.CheckAdjacent(coord, coord3));

        Console.ReadLine();
    }
}

