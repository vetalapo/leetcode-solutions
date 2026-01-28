/**
 * 3769
 * Sort Integers by Binary Reflection
 **
 * You are given an integer array nums.
 *
 * The binary reflection of a positive integer
 * is defined as the number obtained by reversing the order of its binary digits
 * (ignoring any leading zeros)
 * and interpreting the resulting binary number as a decimal.
 *
 * Sort the array in ascending order
 * based on the binary reflection of each element.
 * If two different numbers have the same binary reflection,
 * the smaller original number should appear first.
 *
 * Return the resulting sorted array.
 *
 * Example 1:
 *   Input: nums = [4,5,4]
 *   Output: [4,4,5]
 *   Explanation:
 *     Binary reflections are:
 *       4 -> (binary) 100 -> (reversed) 001 -> 1
 *       5 -> (binary) 101 -> (reversed) 101 -> 5
 *       4 -> (binary) 100 -> (reversed) 001 -> 1
 *     Sorting by the reflected values gives [4, 4, 5].
 *
 * Example 2:
 *   Input: nums = [3,6,5,8]
 *   Output: [8,3,6,5]
 *   Explanation:
 *     Binary reflections are:
 *       3 -> (binary) 11 -> (reversed) 11 -> 3
 *       6 -> (binary) 110 -> (reversed) 011 -> 3
 *       5 -> (binary) 101 -> (reversed) 101 -> 5
 *       8 -> (binary) 1000 -> (reversed) 0001 -> 1
 *     Sorting by the reflected values gives [8, 3, 6, 5].
 *     Note that 3 and 6 have the same reflection,
 *     so we arrange them in increasing order of original value.
 *
 * Constraints:
 *   • 1 <= nums.length <= 100
 *   • 1 <= nums[i] <= 10^9
 *
 * Hint 1:
 *   Simulate and sort as described
 **
 * https://leetcode.com/problems/sort-integers-by-binary-reflection/
***/

using System;

namespace Problems;

public class SortIntegersByBinaryReflection
{
    public int[] SortByReflection( int[] nums )
    {
        (int num, int reflection)[] reflections = new (int num, int reflection)[nums.Length];

        for ( int i = 0; i < nums.Length; i++ )
        {
            reflections[i] = (nums[i], ReverseBinary( nums[i] ));
        }

        Array.Sort( reflections, ( a, b ) =>
        {
            if ( a.reflection == b.reflection )
            {
                return a.num - b.num;
            }

            return a.reflection - b.reflection;
        } );

        int[] result = new int[nums.Length];

        for ( int i = 0; i < nums.Length; i++ )
        {
            result[i] = reflections[i].num;
        }

        return result;
    }

    private int ReverseBinary( int num )
    {
        int result = 0;

        while ( num > 0 )
        {
            result = result * 2 + ( num & 1 );
            num >>= 1;
        }

        return result;
    }
}
