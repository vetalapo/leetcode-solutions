/**
 * 1399
 * Count Largest Group
 **
 * You are given an integer n.
 * Each number from 1 to n is grouped according to the sum of its digits.
 *
 * Return the number of groups that have the largest size.
 *
 * Example 1:
 *   Input: n = 13
 *   Output: 4
 *   Explanation:
 *     There are 9 groups in total,
 *     they are grouped according sum of its digits of numbers from 1 to 13:
 *     [1,10], [2,11], [3,12], [4,13], [5], [6], [7], [8], [9].
 *     There are 4 groups with largest size.
 *
 * Example 2:
 *   Input: n = 2
 *   Output: 2
 *   Explanation:
 *     There are 2 groups [1], [2] of size 1.
 *
 * Constraints:
 *   1 <= n <= 10^4
 *
 * Hint 1:
 *   Count the digit sum for each integer in the range and find out the largest groups.
 **
 * https://leetcode.com/problems/count-largest-group/
***/

using System;

namespace Problems;

public class CountLargestGroupSolution
{
    public int CountLargestGroup( int n )
    {
        int[] groups = new int[37];

        while ( n > 0 )
        {
            int sum = 0;
            int temp = n;

            while ( temp > 0 )
            {
                sum += temp % 10;
                temp /= 10;
            }

            groups[sum]++;
            n--;
        }

        int max = 0;

        foreach ( int group in groups )
        {
            max = Math.Max( max, group );
        }

        int result = 0;

        foreach ( int group in groups )
        {
            if ( group == max )
            {
                result++;
            }
        }

        return result;
    }
}
