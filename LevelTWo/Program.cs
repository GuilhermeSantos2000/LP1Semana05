using System;
using SixLabors.ImageSharp;
using Spectre.Console;
using SoGoodLib;

namespace LevelTWo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(SoGoodClass.SoGoodMethod());

            if (args.Length == 2)
            {
                string ImageName = args[0];
                int ImageWidth = int.Parse(args[1]);
                
                CanvasImage image = new CanvasImage(ImageName);
                image.MaxWidth(ImageWidth);
                AnsiConsole.Write(image);
            }
            else
            {
                CanvasImage image = new CanvasImage("tux.jpg");
                image.MaxWidth(24);
                AnsiConsole.Write(image);
            }
           
        }
    }
}
