using System;

namespace _2d_moving
{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            Moving moving = new();
            Render render = new();

            moving.SetStartPos();
            while (true)
            {
                render.RenderField();
                moving.CoordinatesLogic();
            }
        }
    }
}
