/**
 * 3300
 * Minimum Element After Replacement With Digit Sum
 **
 * You are given an integer array nums.
 * You replace each element in nums with the sum of its digits.
 *
 * Return the minimum element in nums after all replacements.
 *
 * Example 1:
 *   Input: nums = [10,12,13,14]
 *   Output: 1
 *   Explanation:
 *     nums becomes [1, 3, 4, 5]
 *     after all replacements, with minimum element 1.
 *
 * Example 2:
 *   Input: nums = [1,2,3,4]
 *   Output: 1
 *   Explanation:
 *     nums becomes [1, 2, 3, 4]
 *     after all replacements, with minimum element 1.
 *
 * Example 3:
 *   Input: nums = [999,19,199]
 *   Output: 10
 *   Explanation:
 *     nums becomes [27, 10, 19]
 *     after all replacements, with minimum element 10.
 *
 * Constraints:
 *   • 1 <= nums.length <= 100
 *   • 1 <= nums[i] <= 10^4
 *
 * Hint 1:
 *   Convert to string and calculate the sum for each element.
 **
 * https://leetcode.com/problems/minimum-element-after-replacement-with-digit-sum/
***/

using System;

namespace Problems;

public class MinimumElementAfterReplacementWithDigitSum
{
    public int MinElement( int[] nums )
    {
        int min = int.MaxValue;

        foreach ( int num in nums )
        {
            min = Math.Min( min, DigitSum( num ) );
        }

        return min;
    }

    private int DigitSum( int num )
    {
        if ( num == 0 )
        {
            return 0;
        }

        return num % 10 + DigitSum( num / 10 );
    } 
}