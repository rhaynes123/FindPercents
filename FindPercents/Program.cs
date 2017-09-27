using System;

namespace FindPercents
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double startingBaseNum = 0;
            double removedNum = 0;

            Console.WriteLine("Hi! Please enter the starting amount number");
            startingBaseNum = double.Parse(Console.ReadLine());
			Console.WriteLine("Awesome now enter the number being removed amount number");
			removedNum = double.Parse(Console.ReadLine());
            double percentageOutcome = removedNum / startingBaseNum * 100;

            Console.WriteLine("Ok tha number makes uo {0}% of{1}",percentageOutcome,startingBaseNum );

            Console.WriteLine("Now to find the value of a percentages! We can kee using the same base so enter in a percentage. Leave off the % sign");
            double percentageOf = double.Parse(Console.ReadLine());
            double percentageResult = percentageOf * 0.01 * startingBaseNum;
            Console.WriteLine(percentageResult);
        }
    }
}
