/**
 * 896
 * Monotonic Array
 **
 * An array is monotonic if it is either
 * monotone increasing or monotone decreasing.
 *
 * An array nums is monotone increasing
 * if for all i <= j, nums[i] <= nums[j].
 *
 * An array nums is monotone decreasing
 * if for all i <= j, nums[i] >= nums[j].
 *
 * Given an integer array nums,
 * return true if the given array is monotonic,
 * or false otherwise.
 *
 * Example 1:
 *   Input: nums = [1,2,2,3]
 *   Output: true
 *
 * Example 2:
 *   Input: nums = [6,5,4,4]
 *   Output: true
 *
 * Example 3:
 *   Input: nums = [1,3,2]
 *   Output: false
 *
 * Constraints:
 *   • 1 <= nums.length <= 10^5
 *   • -10^5 <= nums[i] <= 10^5
 **
 * https://leetcode.com/problems/monotonic-array/
***/

namespace Problems;

public class MonotonicArray
{
    public bool IsMonotonic( int[] nums )
    {
        bool isIncreasing = true;
        bool isDecreasing = true;

        for ( int i = 1; i < nums.Length && ( isIncreasing || isDecreasing ); i++ )
        {
            if ( isIncreasing && nums[i - 1] > nums[i] )
            {
                isIncreasing = false;
            }

            if ( isDecreasing && nums[i - 1] < nums[i] )
            {
                isDecreasing = false;
            }
        }

        return isIncreasing || isDecreasing;
    }
}
