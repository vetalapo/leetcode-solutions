/**
 * 1800
 * Maximum Ascending Subarray Sum
 **
 * Given an array of positive integers nums,
 * return the maximum possible sum of an strictly increasing subarray in nums.
 *
 * A subarray is defined as a contiguous sequence of numbers in an array.
 *
 * Example 1:
 *   Input: nums = [10,20,30,5,10,50]
 *   Output: 65
 *   Explanation:
 *     [5,10,50] is the ascending subarray
 *     with the maximum sum of 65.
 *
 * Example 2:
 *   Input: nums = [10,20,30,40,50]
 *   Output: 150
 *   Explanation:
 *     [10,20,30,40,50] is the ascending subarray
 *     with the maximum sum of 150.
 *
 * Example 3:
 *   Input: nums = [12,17,15,13,10,11,12]
 *   Output: 33
 *   Explanation:
 *     [10,11,12] is the ascending subarray
 *     with the maximum sum of 33.
 *
 * Constraints:
 *   • 1 <= nums.length <= 100
 *   • 1 <= nums[i] <= 100
 *
 * Hint 1:
 *   It is fast enough to check all possible subarrays
 *
 * Hint 2:
 *   The end of each ascending subarray will be the start of the next
 **
 * https://leetcode.com/problems/maximum-ascending-subarray-sum/
***/

using System;

namespace Problems;

public class MaximumAscendingSubarraySum
{
    public int MaxAscendingSum( int[] nums )
    {
        int maxSum = 0;
        int currSum = nums[0];

        for ( int i = 1; i < nums.Length; i++ )
        {
            if ( nums[i] <= nums[i - 1] )
            {
                maxSum = Math.Max( maxSum, currSum );
                currSum = 0;
            }

            currSum += nums[i];
        }

        return Math.Max( maxSum, currSum );
    }
}
