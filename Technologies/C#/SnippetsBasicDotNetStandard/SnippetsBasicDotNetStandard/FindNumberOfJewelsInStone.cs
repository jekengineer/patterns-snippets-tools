using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnippetsBasicDotNetStandard
{
    public class FindNumberOfJewelsInStone
    {

        public int NumJewelsInStones(string J, string S)
        {

            int numOfJewelStones = 0;

            List<string> listOfJewels = J.Select(c => c.ToString()).ToList();
            List<string> listOfStones = S.Select(c => c.ToString()).ToList();

            for (int i = 0; i < listOfJewels.Count; i++) {
                numOfJewelStones += listOfStones.Count(s => s.Contains(listOfJewels[i]));
            }

            return numOfJewelStones;


        }

    }
}
