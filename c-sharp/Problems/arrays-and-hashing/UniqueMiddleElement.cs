/**
 * 3978
 * Unique Middle Element
 **
 * You are given an integer array nums of odd length n.
 *
 * Return true if the middle element of nums appears exactly once in the array.
 * Otherwise return false.
 *
 * Example 1:
 *   Input: nums = [1,2,3]
 *   Output: true
 *   Explanation:
 *     The middle element of nums is 2, which appears exactly once.
 *     Thus, the answer is true.
 *
 * Example 2:
 *   Input: nums = [1,2,2]
 *   Output: false
 *   Explanation:
 *     The middle element of nums is 2, which appears twice.
 *     Thus, the answer is false.
 *
 * Constraints:
 *   • 1 <= n == nums.length <= 100
 *   • n is odd.
 *   • 1 <= nums[i] <= 100
 *
 * Hint 1:
 *   The middle index is nums.length / 2.
 *
 * Hint 2:
 *   Count how many times nums[nums.length / 2] appears in nums.
 **
 * https://leetcode.com/problems/unique-middle-element/
***/

namespace Problems;

public class UniqueMiddleElement
{
    public bool IsMiddleElementUnique( int[] nums )
    {
        int middle = nums.Length / 2;

        for ( int i = 0; i < nums.Length; i++ )
        {
            if ( i == middle )
            {
                continue;
            }

            if ( nums[i] == nums[middle] )
            {
                return false;
            }
        }

        return true;
    } 
}