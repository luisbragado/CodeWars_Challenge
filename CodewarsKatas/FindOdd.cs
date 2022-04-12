/* 11-Abril-2022

Given an array of integers, find the one that appears an odd number of times.

There will always be only one integer that appears an odd number of times.

Examples
[7] should return 7, because it occurs 1 time (which is odd).
[0] should return 0, because it occurs 1 time (which is odd).
[1,1,2] should return 2, because it occurs 1 time (which is odd).
[0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).
[1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd).

Kata: https://www.codewars.com/kata/54da5a58ea159efa38000836/
*/

using System;

namespace CodewarsKatas
{
    public class FindOdd
    {
        public static int find_it(int[] seq)
        {
            int result = 0;

            for (int i = 0; i < seq.Length; i++)
            {
                result = 0;

                foreach (var item in seq)
                {
                    if (seq[i] == item)
                        result++;
                }

                if (result == 1 || result % 2 != 0)
                    return seq[i];
            }

            return result;

            //*******************************************
            //Solution with Linq
            //return seq.ToList()
            //      .GroupBy(x => x) //Group by each element in the array
            //      .Where(x => (x.Count() % 2) != 0) //Find grouped odd numbers
            //      .Select(x => x.First())
            //      .FirstOrDefault(); //since array will only contain 1 odd number, get first one
            //*******************************************
        }
    }
}
