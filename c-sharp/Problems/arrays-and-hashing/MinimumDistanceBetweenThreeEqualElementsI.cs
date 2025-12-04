/**
 * 3740
 * Minimum Distance Between Three Equal Elements I
 **
 * You are given an integer array nums.
 *
 * A tuple (i, j, k) of 3 distinct indices is good
 * if nums[i] == nums[j] == nums[k].
 *
 * The distance of a good tuple is abs(i - j) + abs(j - k) + abs(k - i),
 * where abs(x) denotes the absolute value of x.
 *
 * Return an integer
 * denoting the minimum possible distance of a good tuple.
 * If no good tuples exist, return -1.
 *
 * Example 1:
 *   Input: nums = [1,2,1,1,3]
 *   Output: 6
 *   Explanation:
 *     The minimum distance is achieved by the good tuple (0, 2, 3).
 *     (0, 2, 3) is a good tuple because nums[0] == nums[2] == nums[3] == 1.
 *     Its distance is abs(0 - 2) + abs(2 - 3) + abs(3 - 0) = 2 + 1 + 3 = 6.
 *
 * Example 2:
 *   Input: nums = [1,1,2,3,2,1,2]
 *   Output: 8
 *   Explanation:
 *     The minimum distance is achieved by the good tuple (2, 4, 6).
 *     (2, 4, 6) is a good tuple because nums[2] == nums[4] == nums[6] == 2.
 *     Its distance is abs(2 - 4) + abs(4 - 6) + abs(6 - 2) = 2 + 2 + 4 = 8.
 *
 * Example 3:
 *   Input: nums = [1]
 *   Output: -1
 *   Explanation:
 *     There are no good tuples.
 *     Therefore, the answer is -1.
 *
 * Constraints:
 *   • 1 <= n == nums.length <= 100
 *   • 1 <= nums[i] <= n
 *
 * Hint 1:
 *   Use bruteforce
 **
 * https://leetcode.com/problems/minimum-distance-between-three-equal-elements-i/
***/

using System;

namespace Problems;

public class MinimumDistanceBetweenThreeEqualElementsI
{
    public int MinimumDistance( int[] nums )
    {
        (int first, int second)[] map = new (int, int)[101];

        int min = int.MaxValue;

        for ( int i = 0; i < nums.Length; i++ )
        {
            if ( map[nums[i]].first == 0 )
            {
                map[nums[i]].first = i + 1;
            }
            else if ( map[nums[i]].second == 0 )
            {
                map[nums[i]].second = i + 1;
            }
            else
            {
                min = Math.Min( min, i - map[nums[i]].first + 1 );

                map[nums[i]].first = map[nums[i]].second;
                map[nums[i]].second = i + 1;
            }
        }

        return min == int.MaxValue ? -1 : min * 2;
    }
}
