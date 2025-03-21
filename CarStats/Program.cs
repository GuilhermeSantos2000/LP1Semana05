using System;
using Spectre.Console;
using System.Collections.Generic;
using Bogus;

namespace CarStats
{
    public class Program
    {
       private static void Main(string[] args)
        {
            int numberOfBrands = int.Parse(args[0]);
            Randomizer.Seed = new Random(numberOfBrands);
            
            Faker faker = new Faker();
            List<string> brands = new List<string>();
            Random random = new Random();

            for (int i = 0; i < numberOfBrands; i++)
            {
                brands.Add(faker.Vehicle.Manufacturer());
            }

            BarChart barChart = new BarChart()
                .Width(60)
                .Label("[blue bold underline]Car Sales[/]")
                .CenterLabel();

            foreach (string brand in brands)
            {
                barChart.AddItem(brand, random.Next(1, 20), Color.Teal);
            }

            AnsiConsole.Write(barChart);
        }
    }
}
