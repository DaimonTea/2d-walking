public class Render
{
    public readonly int xFieldSize = 30;
    public readonly int yFieldSize = 30;

    public void RenderField()
    {
        Console.Clear();
        int xCurrent = 0, yCurrent = 0;
        int[] coordinates = Moving.coordinates;
        for (int i = 0; i < xFieldSize; i++)
        {
            Console.Write("#");
        }
        Console.Write("\n");
        for (int y = yFieldSize - 1; y > 0; y--)
        {
            Console.Write("#");
            for (int x = 1; x < xFieldSize - 1; x++)
            {
                Console.Write(x == coordinates[0] && y == coordinates[1] ? "+" : " ");
            }
            Console.Write("#\n");
        }
        for (int i = 0; i < xFieldSize; i++)
        {
            Console.Write("#");
        }

        Console.WriteLine($"\nx = {coordinates[0]}\ny = {coordinates[1]}");
    }
}