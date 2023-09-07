﻿/*
 * 153
 * Find Minimum in Rotated Sorted Array
 * 
 * Suppose an array of length n sorted in ascending order is rotated between 1 and n times.
 * For example, the array nums = [0,1,2,4,5,6,7] might become:
 *   [4,5,6,7,0,1,2] if it was rotated 4 times.
 *   [0,1,2,4,5,6,7] if it was rotated 7 times.
 *   
 * Notice that rotating an array [a[0], a[1], a[2], ..., a[n-1]] 1 time 
 *        results in the array [a[n-1], a[0], a[1], a[2], ..., a[n-2]].
 * 
 * Given the sorted rotated array nums of unique elements, return the minimum element of this array.
 * 
 * You must write an algorithm that runs in O(log n) time.
 * 
 * https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
 */

namespace leet_code_csharp.binary_search;

public class FindMinimumInRotatedSortedArray
{
    public int FindMin( int[] nums )
    {
        int left = 0;
        int right = nums.Length - 1;

        while ( left < right )
        {
            int middle = left + ( ( right - left ) / 2 );

            if ( nums[middle] > nums[right] )
            {
                left = middle + 1;
            }
            else
            {
                right = middle;
            }
        }

        return nums[left];
    }
}
