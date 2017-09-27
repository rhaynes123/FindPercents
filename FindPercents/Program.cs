using System;

namespace FindPercents
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double startingBaseNum,removedNum, percentageOutcome, percentageOf, percentageResult;


            Console.WriteLine("Hi! Please enter the starting amount number");
            startingBaseNum = double.Parse(Console.ReadLine());
			Console.WriteLine("Awesome now enter the number being removed amount number");
			removedNum = double.Parse(Console.ReadLine());
            percentageOutcome = removedNum / startingBaseNum * 100;

            Console.WriteLine("Ok tha number makes uo {0}% of{1}",percentageOutcome,startingBaseNum );

            Console.WriteLine("Now to find the value of a percentages! We can kee using the same base so enter in a percentage. Leave off the % sign");
            percentageOf = double.Parse(Console.ReadLine());
            percentageResult = percentageOf * 0.01 * startingBaseNum;
            Console.WriteLine("Ok {0} is {1}% of {2} ",percentageResult, percentageOf, startingBaseNum);
        }
    }
}
