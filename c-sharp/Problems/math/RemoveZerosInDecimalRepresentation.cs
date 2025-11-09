/**
 * 3726
 * Remove Zeros in Decimal Representation
 **
 * You are given a positive integer n.
 *
 * Return the integer
 * obtained by removing all zeros
 * from the decimal representation of n.
 *
 * Example 1:
 *   Input: n = 1020030
 *   Output: 123
 *   Explanation:
 *     After removing all zeros from 1020030,
 *     we get 123.
 *
 * Example 2:
 *   Input: n = 1
 *   Output: 1
 *   Explanation:
 *     1 has no zero in its decimal representation.
 *     Therefore, the answer is 1.
 *
 * Constraints:
 *   • 1 <= n <= 10^15
 **
 * https://leetcode.com/problems/remove-zeros-in-decimal-representation/
***/

namespace Problems;

public class RemoveZerosInDecimalRepresentation
{
    public long RemoveZeros( long n )
    {
        long result = 0;
        long pow = 1;

        while ( n > 0 )
        {
            long lastDigit = n % 10;

            if ( lastDigit != 0 )
            {
                result = lastDigit * pow + result;
                pow *= 10;
            }

            n /= 10;
        }

        return result;
    }
}
