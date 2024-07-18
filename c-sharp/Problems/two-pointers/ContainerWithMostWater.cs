﻿/**
 * 11
 * Container With Most Water
 **
 * You are given an integer array height of length n.
 * There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
 * Find two lines that together with the x-axis form a container, such that the container contains the most water.
 *
 * Return the maximum amount of water a container can store.
 * Notice that you may not slant the container.
 *
 * Example 1:
 *   Input: height = [1,8,6,2,5,4,8,3,7]
 *   Output: 49
 *   Explanation:
 *     The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7].
 *     In this case, the max area of water (blue section) the container can contain is 49.
 *
 * Example 2:
 *   Input: height = [1,1]
 *   Output: 1
 *
 * Constraints:
 *   • n == height.length
 *   • 2 <= n <= 10^5
 *   • 0 <= height[i] <= 10^4
 *
 * Hint 1:
 *   If you simulate the problem, it will be O(n^2) which is not efficient.
 *
 * Hint 2:
 *   Try to use two-pointers.
 *   Set one pointer to the left and one to the right of the array.
 *   Always move the pointer that points to the lower line.
 *
 * Hint 3:
 *   How can you calculate the amount of water at each step?
 **
 * https://leetcode.com/problems/container-with-most-water/
***/

using System;

namespace Problems;

public class ContainerWithMostWater
{
    public int MaxArea( int[] height )
    {
        int maxArea = 0;

        int left = 0;
        int right = height.Length - 1;

        while ( left < right )
        {
            int diff = right - left;
            int currentMinHeight;

            if ( height[left] > height[right] )
            {
                currentMinHeight = height[right];
                right--;
            }
            else
            {
                currentMinHeight = height[left];
                left++;
            }

            maxArea = Math.Max( maxArea, currentMinHeight * diff );
        }

        return maxArea;
    }
}
