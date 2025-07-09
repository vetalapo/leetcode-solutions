/**
 * 507
 * Perfect Number
 **
 * A perfect number (https://en.wikipedia.org/wiki/Perfect_number)
 * is a positive integer that is equal to the sum of its positive divisors,
 * excluding the number itself.
 * A divisor of an integer x is an integer that can divide x evenly.
 *
 * Given an integer n,
 * return true if n is a perfect number, otherwise return false.
 *
 * Example 1:
 *   Input: num = 28
 *   Output: true
 *   Explanation:
 *     28 = 1 + 2 + 4 + 7 + 14
 *     1, 2, 4, 7, and 14 are all divisors of 28.
 *
 * Example 2:
 *   Input: num = 7
 *   Output: false
 *
 * Constraints:
 *   • 1 <= num <= 10^8
 **
 * https://leetcode.com/problems/perfect-number/
***/

namespace Problems;

public class PerfectNumber
{
    public bool CheckPerfectNumber( int num )
    {
        return num == 6 || num == 28 || num == 496 || num == 8128 || num == 33550336;
    }

    public bool CheckPerfectNumberBF( int num )
    {
        if ( ( num & 1 ) != 0 )
        {
            return false;
        }

        int divisorSum = num >> 1;
        int tmp = divisorSum - 1;

        while ( tmp > 0 )
        {
            if ( num % tmp == 0 )
            {
                divisorSum += tmp;
            }

            tmp--;
        }

        return divisorSum == num;
    }
}
