/**
 * 367
 * Valid Perfect Square
 **
 * Given a positive integer num,
 * return true if num is a perfect square
 * or false otherwise.
 *
 * A perfect square is an integer that is the square of an integer.
 * In other words, it is the product of some integer with itself.
 *
 * You must not use any built-in library function, such as sqrt.
 *
 * Example 1:
 *   Input: num = 16
 *   Output: true
 *   Explanation:
 *     We return true because 4 * 4 = 16 and 4 is an integer.
 *
 * Example 2:
 *   Input: num = 14
 *   Output: false
 *   Explanation:
 *     We return false because 3.742 * 3.742 = 14 and 3.742 is not an integer.
 *
 * Constraints:
 *   • 1 <= num <= 2^31 - 1
 **
 * https://leetcode.com/problems/valid-perfect-square/
***/

namespace Problems;

public class ValidPerfectSquare
{
    public bool IsPerfectSquare( int num )
    {
        int sq = Sqrt( num );

        return sq * sq == num;
    }

    private int Sqrt( int n )
    {
        int temp = n;
        int result = 0;

        int d = 1 << 30;

        while ( d > n )
        {
            d >>= 2;
        }

        while ( d != 0 )
        {
            if ( temp >= result + d )
            {
                temp -= result + d;
                result = ( result >> 1 ) + d;
            }
            else
            {
                result >>= 1;
            }

            d >>= 2;
        }

        return result;
    }
}
