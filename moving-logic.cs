using System;

public class Moving
{
    public static int[] coordinates = new int[2];

    public void SetStartPos()
    {
        Render fieldSize = new();
        coordinates[0] = fieldSize.xFieldSize / 2;
        coordinates[1] = fieldSize.yFieldSize / 2;
    }

    private string MovingInput()
    {
        var key = Console.ReadKey(intercept: true);
        switch (key.Key)
        {
            case ConsoleKey.UpArrow: return "up";
            case ConsoleKey.DownArrow: return "down";
            case ConsoleKey.LeftArrow: return "left";
            case ConsoleKey.RightArrow: return "right";
            default: return string.Empty;
        }
    }

    public void MovingLogic(ref sbyte xChange, ref sbyte yChange)
    {
        Moving coordinates = new();
        string key = MovingInput();

        switch (key)
        {
            case "up": yChange++; break;
            case "down": yChange--; break;
            case "right": xChange++; break;
            case "left": xChange--; break;
        }
        return;
    }

    public void CoordinatesLogic()
    {
        Render fieldSize = new();
        sbyte xChange = 0, yChange = 0;
        MovingLogic(ref xChange, ref yChange);
        int prevX = coordinates[0];
        int prevY = coordinates[1];
        switch (xChange)
        {
            case 1: coordinates[0]++; break;
            case -1: coordinates[0]--; break;
        }
        switch (yChange)
        {
            case 1: coordinates[1]++; break;
            case -1: coordinates[1]--; break;
        }

        coordinates[0] = coordinates[0] == fieldSize.xFieldSize-1 || coordinates[0] == 0 ? prevX : coordinates[0];
        coordinates[1] = coordinates[1] == fieldSize.yFieldSize || coordinates[1] == 0 ? prevY : coordinates[1];
    }
}