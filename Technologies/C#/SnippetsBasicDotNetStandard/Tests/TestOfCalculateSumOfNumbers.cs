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
        public void TestCalculateSumOfNumbers()
        {

            // Tests Manually
            long[] numbersToSumArrayManual = { 1, 2, 3 };    
            List<long> numbersToSumListManual = new List<long> { 1, 2, 3 };  
            long answerManual = 6;

            CalculateSumOfNumbers calculateSumOfNumbers = new CalculateSumOfNumbers();

            long sumResult = calculateSumOfNumbers.Calculate(numbersToSumArrayManual);
            Assert.Equal(sumResult, answerManual);

            sumResult = calculateSumOfNumbers.Calculate(numbersToSumListManual);
            Assert.Equal(sumResult, answerManual);

            sumResult = calculateSumOfNumbers.AdditionTest(numbersToSumArrayManual);
            Assert.Equal(sumResult, answerManual);

            sumResult = calculateSumOfNumbers.AdditionTest(numbersToSumListManual);
            Assert.Equal(sumResult, answerManual);



            // Tests Randomly
            Random randomNumbers = new Random();
            int numberOfRandomNumbers = randomNumbers.Next();

            long[] numbersToSumArrayRandom = new long[numberOfRandomNumbers];
            List<long> numbersToSumListRandom = new List<long> { };

            for (int i = 0; i < numberOfRandomNumbers; i++) {
                int currentRandomNumber = randomNumbers.Next();
                numbersToSumArrayRandom[i] = currentRandomNumber;
                numbersToSumListRandom.Add(currentRandomNumber);
            }

            long answerRandom = numbersToSumArrayRandom.Sum();

            sumResult = calculateSumOfNumbers.Calculate(numbersToSumArrayRandom);
            Assert.Equal(sumResult, answerRandom);

            sumResult = calculateSumOfNumbers.Calculate(numbersToSumListRandom);
            Assert.Equal(sumResult, answerRandom);

            sumResult = calculateSumOfNumbers.AdditionTest(numbersToSumArrayRandom);
            Assert.Equal(sumResult, answerRandom);

            sumResult = calculateSumOfNumbers.AdditionTest(numbersToSumListRandom);
            Assert.Equal(sumResult, answerRandom);











        }






    }
}
