using System;
using System.Collections.Generic;

namespace SnippetsBasicDotNetStandard
{
    public class CalculateSumOfNumbers
    {
        // Given three numbers A, B, C you have to write a function named calcSum() which takes these 3 numbers as arguments and returns their sum.

        // given two or more numbers

        public long Calculate(List<long> numbersToAdd)
        {
            return Addition(numbersToAdd);
        }

        public long Calculate(long[] numbersToAdd)
        {
            List<long> numbersToAddConversionList = new List<long>();
            numbersToAddConversionList.AddRange(numbersToAdd);
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
