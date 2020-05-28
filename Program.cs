using System;

namespace Planner
{
    class Planner
    {

        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Width = .22;
            FiveOneTwoEigth.Depth = .42;
            FiveOneTwoEigth.Stories = 2;
            FiveOneTwoEigth.Constuct();
            FiveOneTwoEigth.Purchase("Jon Howton");

            Building FiveOneThreeEigth = new Building("513 8th Avenue");
            FiveOneThreeEigth.Width = .24;
            FiveOneThreeEigth.Depth = .46;
            FiveOneThreeEigth.Stories = 4;
            FiveOneThreeEigth.Constuct();
            FiveOneThreeEigth.Purchase("Riley Howton");

            Building FiveOneFourEigth = new Building("514 8th Avenue");
            FiveOneFourEigth.Width = .26;
            FiveOneFourEigth.Depth = .48;
            FiveOneFourEigth.Stories = 6;
            FiveOneFourEigth.Constuct();
            FiveOneFourEigth.Purchase("Zoe Howton");
            Console.WriteLine(FiveOneTwoEigth.Address);
            Console.WriteLine("---------------");
            Console.WriteLine($"Designed by {FiveOneTwoEigth.Designer}");
            Console.WriteLine($"Construced on {FiveOneTwoEigth.DateConstucted}");
            Console.WriteLine($"{FiveOneTwoEigth.Volume} cubic meters of space");
            Console.WriteLine(FiveOneThreeEigth.Address);
            Console.WriteLine("---------------");
            Console.WriteLine($"Designed by {FiveOneThreeEigth.Designer}");
            Console.WriteLine($"Construced on {FiveOneThreeEigth.DateConstucted}");
            Console.WriteLine($"{FiveOneThreeEigth.Volume} cubic meters of space");
            Console.WriteLine(FiveOneFourEigth.Address);
            Console.WriteLine("---------------");
            Console.WriteLine($"Designed by {FiveOneFourEigth.Designer}");
            Console.WriteLine($"Construced on {FiveOneFourEigth.DateConstucted}");
            Console.WriteLine($"{FiveOneFourEigth.Volume} cubic meters of space");
        }
    }
}