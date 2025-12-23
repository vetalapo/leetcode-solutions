/**
 * 3774
 * Absolute Difference Between Maximum and Minimum K Elements
 **
 * You are given an integer array nums and an integer k.
 *
 * Find the absolute difference between:
 *   • the sum of the k largest elements in the array; and
 *   • the sum of the k smallest elements in the array.
 *
 * Return an integer denoting this difference.
 *
 * Example 1:
 *   Input: nums = [5,2,2,4], k = 2
 *   Output: 5
 *   Explanation:
 *     The k = 2 largest elements are 4 and 5. Their sum is 4 + 5 = 9.
 *     The k = 2 smallest elements are 2 and 2. Their sum is 2 + 2 = 4.
 *     The absolute difference is abs(9 - 4) = 5.
 *
 * Example 2:
 *   Input: nums = [100], k = 1
 *   Output: 0
 *   Explanation:
 *     The largest element is 100.
 *     The smallest element is 100.
 *     The absolute difference is abs(100 - 100) = 0.
 *
 * Constraints:
 *   • 1 <= n == nums.length <= 100
 *   • 1 <= nums[i] <= 100
 *   • 1 <= k <= n
 *
 * Hint 1:
 *   Sort the array and
 *   find the difference between the first and last k values.
 **
 * https://leetcode.com/problems/absolute-difference-between-maximum-and-minimum-k-elements/
***/

using System;

namespace Problems;

public class AbsoluteDifferenceBetweenMaximumAndMinimumKElements
{
    public int AbsDifference( int[] nums, int k )
    {
        Span<int> countMap = stackalloc int[101];

        // Sort
        foreach ( int num in nums )
        {
            countMap[num]++;
        }

        int sum = 0;
        int tempK = k;

        // Summing minimums
        for ( int i = 1; i < countMap.Length; i++ )
        {
            if ( countMap[i] > 0 )
            {
                int currCount = Math.Min( tempK, countMap[i] );

                sum -= i * currCount;
                tempK -= currCount;

                if ( tempK == 0 )
                {
                    break;
                }
            }
        }

        tempK = k;

        // Summing maximums
        for ( int i = countMap.Length - 1; i >= 0; i-- )
        {
            if ( countMap[i] > 0 )
            {
                int currCount = Math.Min( tempK, countMap[i] );

                sum += i * currCount;
                tempK -= currCount;

                if ( tempK == 0 )
                {
                    break;
                }
            }
        }

        return sum;
    }
}
