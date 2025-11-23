/**
 * 3754
 * Concatenate Non-Zero Digits and Multiply by Sum I
 **
 * You are given an integer n.
 * Form a new integer x
 * by concatenating all the non-zero digits
 * of n in their original order.
 * If there are no non-zero digits, x = 0.
 *
 * Let sum be the sum of digits in x.
 *
 * Return an integer representing the value of x * sum.
 *
 * Example 1:
 *   Input: n = 10203004
 *   Output: 12340
 *   Explanation:
 *     The non-zero digits are 1, 2, 3, and 4. Thus, x = 1234.
 *     The sum of digits is sum = 1 + 2 + 3 + 4 = 10.
 *     Therefore, the answer is x * sum = 1234 * 10 = 12340.
 *
 * Example 2:
 *   Input: n = 1000
 *   Output: 1
 *   Explanation:
 *     The non-zero digit is 1, so x = 1 and sum = 1.
 *     Therefore, the answer is x * sum = 1 * 1 = 1.
 *
 * Constraints:
 *   • 0 <= n <= 10^9
 *
 * Hint 1:
 *   Simulate as described
 **
 * https://leetcode.com/problems/concatenate-non-zero-digits-and-multiply-by-sum-i/
***/

namespace Problems;

public class ConcatenateNonZeroDigitsAndMultiplyBySumI
{
    public long SumAndMultiply( int n )
    {
        long resultNum = 0;
        long sum = 0;
        long pow = 1;

        while ( n > 0 )
        {
            if ( n % 10 > 0 )
            {
                resultNum = ( n % 10 ) * pow + resultNum;
                sum += n % 10;
                pow *= 10;
            }

            n /= 10;
        }

        return resultNum * sum;
    }
}
