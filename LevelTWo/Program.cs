using System;
using SixLabors.ImageSharp;
using Spectre.Console;

namespace LevelTWo
{
    public class Program
    {
        private static void Main(string[] args)
        {
           string ImageName = args[0];
           int ImageWidth = int.Parse(args[1]);

           
           CanvasImage image = new CanvasImage("tux.jpg");
           image.MaxWidth(24);
           AnsiConsole.Write(image);
        }
    }
}
