/**
 * 3745
 * Maximize Expression of Three Elements
 **
 * You are given an integer array nums.
 *
 * Choose three elements a, b, and c
 * from nums at distinct indices such
 * that the value of the expression a + b - c is maximized.
 *
 * Return an integer denoting
 * the maximum possible value of this expression.
 *
 * Example 1:
 *   Input: nums = [1,4,2,5]
 *   Output: 8
 *   Explanation:
 *     We can choose a = 4, b = 5, and c = 1.
 *     The expression value is 4 + 5 - 1 = 8,
 *     which is the maximum possible.
 *
 * Example 2:
 *   Input: nums = [-2,0,5,-2,4]
 *   Output: 11
 *   Explanation:
 *     We can choose a = 5, b = 4, and c = -2.
 *     The expression value is 5 + 4 - (-2) = 11,
 *     which is the maximum possible.
 *
 * Constraints:
 *   • 3 <= nums.length <= 100
 *   • -100 <= nums[i] <= 100
 *
 * Hint 1:
 *   a and b should be the two largest values in nums
 *
 * Hint 2:
 *   c should be the smallest value in nums
 **
 * https://leetcode.com/problems/maximize-expression-of-three-elements/
***/

using System;

namespace Problems;

public class MaximizeExpressionOfThreeElements
{
    public int MaximizeExpressionOfThree( int[] nums )
    {
        int max = int.MinValue;
        int max2 = int.MinValue;
        int min = int.MaxValue;

        foreach ( int num in nums )
        {
            if ( num > max )
            {
                max2 = max;
                max = num;
            }
            else if ( num > max2 )
            {
                max2 = num;
            }

            min = Math.Min( min, num );
        }

        return max + max2 - min;
    }
}
