﻿/**
 * 128
 * Longest Consecutive Sequence
 **
 * Given an unsorted array of integers nums,
 * return the length of the longest consecutive elements sequence.
 *
 * You must write an algorithm that runs in O(n) time.
 *
 * Example 1:
 *   Input: nums = [100,4,200,1,3,2]
 *   Output: 4
 *   Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
 *
 * Example 2:
 *   Input: nums = [0,3,7,2,5,8,4,6,0,1]
 *   Output: 9
 *
 * Constraints:
 *   • 0 <= nums.length <= 10^5
 *   • -10^9 <= nums[i] <= 10^9
 **
 * https://leetcode.com/problems/longest-consecutive-sequence/
***/

using System;
using System.Collections.Generic;

namespace Problems;

public class LongestConsecutiveSequence
{
    public int LongestConsecutive( int[] nums )
    {
        HashSet<int> numSet = new( nums );
        int longestConsecutive = 0;

        foreach ( int num in numSet )
        {
            if ( !numSet.Contains( num - 1 ) )
            {
                int currentLength = 1;

                while ( numSet.Contains( num + currentLength ) )
                {
                    currentLength++;
                }

                longestConsecutive = Math.Max( longestConsecutive, currentLength );
            }
        }

        return longestConsecutive;
    }
}
