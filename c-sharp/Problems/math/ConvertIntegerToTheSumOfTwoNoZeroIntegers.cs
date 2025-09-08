/**
 * 1317
 * Convert Integer to the Sum of Two No-Zero Integers
 **
 * No-Zero integer is a positive integer
 * that does not contain any 0 in its decimal representation.
 *
 * Given an integer n,
 * return a list of two integers [a, b] where:
 *   • a and b are No-Zero integers.
 *   • a + b = n
 *
 * The test cases are generated so
 * that there is at least one valid solution.
 * If there are many valid solutions,
 * you can return any of them.
 *
 * Example 1:
 *   Input: n = 2
 *   Output: [1,1]
 *   Explanation:
 *     Let a = 1 and b = 1.
 *     Both a and b are no-zero integers,
 *     and a + b = 2 = n.
 *
 * Example 2:
 *   Input: n = 11
 *   Output: [2,9]
 *   Explanation:
 *     Let a = 2 and b = 9.
 *     Both a and b are no-zero integers,
 *     and a + b = 11 = n.
 *     Note that there are other valid answers
 *     as [8, 3] that can be accepted.
 *
 * Constraints:
 *   • 2 <= n <= 10^4
 *
 * Hint 1:
 *   Loop through all elements from 1 to n.
 *
 * Hint 2:
 *   Choose A = i and B = n - i
 *   then check if A and B are both No-Zero integers.
 **
 * https://leetcode.com/problems/convert-integer-to-the-sum-of-two-no-zero-integers/
***/

namespace Problems;

public class ConvertIntegerToTheSumOfTwoNoZeroIntegers
{
    public int[] GetNoZeroIntegers( int n )
    {
        int left = 1;
        int right = n - 1;

        while ( ContainsZero( left ) || ContainsZero( right ) )
        {
            left++;
            right--;
        }

        return [left, right];
    }

    private bool ContainsZero( int num )
    {
        while ( num > 0 )
        {
            if ( num % 10 == 0 )
            {
                return true;
            }

            num /= 10;
        }

        return false;
    }
}
