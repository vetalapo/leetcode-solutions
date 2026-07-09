/**
 * 3954
 * Sum of Compatible Numbers in Range I
 **
 * You are given two integers n and k.
 *
 * A positive integer x is called compatible
 * if it satisfies both of the following conditions:
 *   • abs(n - x) <= k
 *   • (n & x) == 0
 *
 * Return the sum of all compatible integers x.
 *
 * Note:
 *   • Here, & denotes the bitwise AND operator.
 *   • The absolute difference between integers i and j is defined as abs(i - j).
 *
 * Example 1:
 *   Input: n = 2, k = 3
 *   Output: 10
 *   Explanation:
 *     The compatible integers are:
 *       • x = 1, since abs(2 - 1) = 1 and 2 & 1 = 0.
 *       • x = 4, since abs(2 - 4) = 2 and 2 & 4 = 0.
 *       • x = 5, since abs(2 - 5) = 3 and 2 & 5 = 0.
 *     Thus, the answer is 1 + 4 + 5 = 10.
 *
 * Example 2:
 *   Input: n = 5, k = 1
 *   Output: 0
 *   Explanation:
 *     There are no compatible integers in the range [4, 6].
 *     Thus, the answer is 0.
 *
 * Constraints:
 *   • 1 <= n <= 100
 *   • 1 <= k <= 100
 *
 * Hint 1:
 *   The condition abs(n - x) <= k means x is in the range [n - k, n + k].
 *
 * Hint 2:
 *   Since x must be positive, start checking from max(1, n - k).
 *
 * Hint 3:
 *   Iterate through all values in this range
 *   and add x to the answer when (n & x) == 0.
 **
 * https://leetcode.com/problems/sum-of-compatible-numbers-in-range-i/
***/

using System;

namespace Problems;

public class SumOfCompatibleNumbersInRangeI
{
    public int SumOfGoodIntegers( int n, int k )
    {
        int sum = 0;

        int start = Math.Max( 1, n - k );
        int end = n + k;

        for ( int x = start; x <= end; x++ )
        {
            if ( ( n & x ) == 0 )
            {
                sum += x;
            }
        }

        return sum;
    } 
}