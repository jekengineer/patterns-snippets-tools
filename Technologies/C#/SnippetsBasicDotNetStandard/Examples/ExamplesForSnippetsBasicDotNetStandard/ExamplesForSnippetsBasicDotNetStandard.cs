using System;
using System.Collections.Generic;

using SnippetsBasicDotNetStandard;

namespace Examples
{
    class ExamplesForSnippetsBasicDotNetStandard
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting Examples for Snippiets Basic Dot Net Standard!");

            CalculateSumOfNumbersExample();
            FindNumberOfJewelsInStoneExample();

        }


        protected static void CalculateSumOfNumbersExample()
        {
            int numA = 67;
            int numB = 90;
            int numC = 99;

            long[] numbersToSumArray = { numA, numB, numC };
            List<long> numbersToSumList = new List<long> { numA, numB, numC };

            CalculateSumOfNumbers calculateSumOfNumbers = new CalculateSumOfNumbers();
            long sumToUse = calculateSumOfNumbers.Calculate(numbersToSumArray);
            Console.WriteLine("The array sum of numA, numB, and numC is " + sumToUse);

            sumToUse = calculateSumOfNumbers.Calculate(numbersToSumList);
            Console.WriteLine("The list sum of numA, numB, and numC is " + sumToUse);


        }



        protected static void FindNumberOfJewelsInStoneExample()
        {
            string jewels = "aA";
            string stones = "aAAbbbb";

            FindNumberOfJewelsInStone findNumberOfJewelsInStone = new FindNumberOfJewelsInStone();

            int jewelsInStones = findNumberOfJewelsInStone.NumJewelsInStones(jewels, stones);
            Console.WriteLine("The number of Jewels in this Stone is " + jewelsInStones);       // Correct answer should be 3

            jewels = "z";
            stones = "ZZZZZ";
            jewelsInStones = findNumberOfJewelsInStone.NumJewelsInStones(jewels, stones);
            Console.WriteLine("The number of Jewels in this Stone is " + jewelsInStones);   // Correct answer should be 0

        }






    }
}
