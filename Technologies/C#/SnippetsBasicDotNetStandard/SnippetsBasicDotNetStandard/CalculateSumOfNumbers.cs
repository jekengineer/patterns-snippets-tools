using System;
using System.Collections.Generic;

namespace SnippetsBasicDotNetStandard
{
    public class CalculateSumOfNumbers
    {
        // This will calculate the sum of numbers in a list or in an array

        public long Calculate(List<long> numbersToAdd)
        {
            return Addition(numbersToAdd);
        }

        public long Calculate(long[] numbersToAdd)
        {
            List<long> numbersToAddConversionList = new List<long>(numbersToAdd);
            return Addition(numbersToAddConversionList);
        }


        protected long Addition(List<long> numbersToAdd)
        {
            long sumOfNumbers = 0;
            for(int i = 0; i < numbersToAdd.Count; i++) {
                sumOfNumbers += numbersToAdd[i];
            }

            return sumOfNumbers;
        }


        // Tests

        public long AdditionTest(List<long> numbersToAdd)
        {
            return Addition(numbersToAdd);
        }

        public long AdditionTest(long[] numbersToAdd)
        {
            List<long> numbersToAddConversionList = new List<long>();
            numbersToAddConversionList.AddRange(numbersToAdd);
            return Addition(numbersToAddConversionList);
        }

        

    }
}
