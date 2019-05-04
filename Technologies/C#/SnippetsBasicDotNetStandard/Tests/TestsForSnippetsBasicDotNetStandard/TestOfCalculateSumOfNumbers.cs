using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

using SnippetsBasicDotNetStandard;

namespace Tests
{
    public class TestOfCalculateSumOfNumbers
    {
        [Fact]
        protected void TestCalculateSumOfNumbers()
        {
            long[] numbersToSumArray = { 1, 2, 3 };
            List<long> numbersToSumList = new List<long> { 1, 2, 3 };
            long answerOfSum = 6;
            CalculateSumOfNumbers calculateSumOfNumbers = new CalculateSumOfNumbers();

            TestCalculateSumOfNumbersTest(numbersToSumArray, numbersToSumList, answerOfSum, calculateSumOfNumbers);
            TestCalculateSumOfNumbersRandom(numbersToSumArray, numbersToSumList, answerOfSum, calculateSumOfNumbers);

        }




        protected void TestCalculateSumOfNumbersTest(long[] numbersToSumArray, List<long> numbersToSumList, long answerOfSum, CalculateSumOfNumbers calculateSumOfNumbers)
        {
            CalculateComparisonTest(numbersToSumArray, calculateSumOfNumbers, answerOfSum);
            CalculateComparisonTest(numbersToSumList, calculateSumOfNumbers, answerOfSum);

            AdditionComparisonTest(numbersToSumArray, calculateSumOfNumbers, answerOfSum);
            AdditionComparisonTest(numbersToSumList, calculateSumOfNumbers, answerOfSum);

        }




        protected void TestCalculateSumOfNumbersRandom(long[] numbersToSumArray, List<long> numbersToSumList, long answerOfSum, CalculateSumOfNumbers calculateSumOfNumbers)
        {
            // Tests Randomly
            Random randomNumbers = new Random();
            int numberOfRandomNumbers = randomNumbers.Next(1000);

            numbersToSumArray = new long[numberOfRandomNumbers];
            numbersToSumList = new List<long> { };

            for (int i = 0; i < numberOfRandomNumbers; i++) {
                int currentRandomNumber = randomNumbers.Next(1000);
                numbersToSumArray[i] = currentRandomNumber;
                numbersToSumList.Add(currentRandomNumber);
            }

            answerOfSum = numbersToSumArray.Sum();

            TestCalculateSumOfNumbersTest(numbersToSumArray, numbersToSumList, answerOfSum, calculateSumOfNumbers);
        }






        protected void CalculateComparisonTest(List<long> numbersToSumList, CalculateSumOfNumbers calculateSumOfNumbers, long answerOfSum)
        {
            long sumResult = calculateSumOfNumbers.Calculate(numbersToSumList);

            Assert.Equal(sumResult, answerOfSum);


        }


        protected void CalculateComparisonTest(long[] numbersToSumArray, CalculateSumOfNumbers calculateSumOfNumbers, long answerOfSum)
        {
            List<long> numbersToAddConversionList = new List<long>();
            numbersToAddConversionList.AddRange(numbersToSumArray);
            CalculateComparisonTest(numbersToAddConversionList, calculateSumOfNumbers, answerOfSum);
        }



        protected void AdditionComparisonTest(List<long> numbersToSumList, CalculateSumOfNumbers calculateSumOfNumbers, long answerOfSum)
        {
            long sumResult = calculateSumOfNumbers.AdditionTest(numbersToSumList);
            Assert.Equal(sumResult, answerOfSum);
        }


        protected void AdditionComparisonTest(long[] numbersToSumArray, CalculateSumOfNumbers calculateSumOfNumbers, long answerOfSum)
        {
            List<long> numbersToAddConversionList = new List<long>();
            numbersToAddConversionList.AddRange(numbersToSumArray);
            CalculateComparisonTest(numbersToAddConversionList, calculateSumOfNumbers, answerOfSum);
        }

    }
}
