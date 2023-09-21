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

public struct Coordinate
{
    public readonly int Row { get; }
    public readonly int Column { get; }
    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public static bool CheckAdjacent(Coordinate c1, Coordinate c2)
    {
        if (Math.Abs(c1.Row - c2.Row) <= 1 && Math.Abs(c1.Column - c2.Column) == 0)
        {
            return true;
        }

        if (Math.Abs(c1.Row - c2.Row) == 0 && Math.Abs(c1.Column - c2.Column) <= 1)
        {
            return true;
        }

        return false;
    }
}