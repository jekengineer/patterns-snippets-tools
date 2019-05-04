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


    }
}
