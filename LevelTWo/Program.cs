using System;
using Spectre.Console;

namespace LevelTWo
{
    public class Program
    {
        private static void Main(string[] args)
        {
           CanvasImage image = new CanvasImage("tux.jpg");
           image.MaxWidth(24);
           AnsiConsole.Write(image);
        }
    }
}
