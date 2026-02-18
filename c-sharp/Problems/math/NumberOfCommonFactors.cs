/**
 * 2427
 * Number of Common Factors
 **
 * Given two positive integers a and b,
 * return the number of common factors of a and b.
 *
 * An integer x is a common factor of a and b
 * if x divides both a and b.
 *
 * Example 1:
 *   Input: a = 12, b = 6
 *   Output: 4
 *   Explanation:
 *     The common factors of 12 and 6 are 1, 2, 3, 6.
 *
 * Example 2:
 *   Input: a = 25, b = 30
 *   Output: 2
 *   Explanation:
 *     The common factors of 25 and 30 are 1, 5.
 *
 * Constraints:
 *   • 1 <= a, b <= 1000
 *
 * Hint 1:
 *   For each integer in range [1,1000],
 *   check if it’s divisible by both A and B.
 **
 * https://leetcode.com/problems/number-of-common-factors/
***/

namespace Problems;

public class NumberOfCommonFactors
{
    public int CommonFactors( int a, int b )
    {
        int upperBound = GCD( a, b );

        int count = 1;

        for ( int i = 2; i <= upperBound; i++ )
        {
            if ( a % i == 0 && b % i == 0 )
            {
                count++;
            }
        }

        return count;
    }

    private int GCD( int a, int b )
    {
        if ( b == 0 )
        {
            return a;
        }

        return GCD( b, a % b );
    }
}
