/**
 * 1952
 * Three Divisors
 **
 * Given an integer n,
 * return true if n has exactly three positive divisors.
 * Otherwise, return false.
 *
 * An integer m is a divisor of n
 * if there exists an integer k such that n = k * m.
 *
 * Example 1:
 *   Input: n = 2
 *   Output: false
 *   Explanation:
 *     2 has only two divisors: 1 and 2.
 *
 * Example 2:
 *   Input: n = 4
 *   Output: true
 *   Explanation:
 *     4 has three divisors: 1, 2, and 4.
 *
 * Constraints:
 *   • 1 <= n <= 10^4
 *
 * Hint 1:
 *   You can count the number of divisors and just check that they are 3
 *
 * Hint 2:
 *   Beware of the case of n equal 1 as some solutions might fail in it
 *
 * Hint 3:
 *   The squares of all prime numbers have exactly 3 divisors
 **
 * https://leetcode.com/problems/three-divisors/
***/

using System;

namespace Problems;

public class ThreeDivisors
{
    public bool IsThree( int n )
    {
        if ( n < 4 )
        {
            return false;
        }

        int root = (int)Math.Sqrt( n );

        if ( root * root < n )
        {
            return false;
        }

        for ( int i = 2; i * i <= root; i++ )
        {
            if ( root % i == 0 )
            {
                return false;
            }
        }

        return true;
    }
}
