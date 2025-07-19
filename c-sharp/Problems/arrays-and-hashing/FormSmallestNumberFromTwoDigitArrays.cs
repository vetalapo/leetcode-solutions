/**
 * 2605
 * Form Smallest Number From Two Digit Arrays
 **
 * Given two arrays of unique digits nums1 and nums2,
 * return the smallest number that contains at least one digit from each array.
 *
 * Example 1:
 *   Input: nums1 = [4,1,3], nums2 = [5,7]
 *   Output: 15
 *   Explanation:
 *     The number 15 contains the digit 1 from nums1 and the digit 5 from nums2.
 *     It can be proven that 15 is the smallest number we can have.
 *
 * Example 2:
 *   Input: nums1 = [3,5,2,6], nums2 = [3,1,7]
 *   Output: 3
 *   Explanation:
 *     The number 3 contains the digit 3 which exists in both arrays.
 *
 * Constraints:
 *   • 1 <= nums1.length, nums2.length <= 9
 *   • 1 <= nums1[i], nums2[i] <= 9
 *   • All digits in each array are unique.
 *
 * Hint 1:
 *   How many digits will the resulting number have at most?
 *
 * Hint 2:
 *   The resulting number will have either one or two digits.
 *   Try to find when each case is possible.
 **
 * https://leetcode.com/problems/form-smallest-number-from-two-digit-arrays/
***/

using System;
using System.Linq;

namespace Problems;

public class FormSmallestNumberFromTwoDigitArrays
{
    public int MinNumber( int[] nums1, int[] nums2 )
    {
        if ( nums1.Length > nums2.Length )
        {
            return MinNumber( nums2, nums1 );
        }

        int min1 = nums1[0];
        int min2 = nums2[0];
        int min = 10;

        for ( int i = 0; i < nums2.Length; i++ )
        {
            if ( nums1.Contains( nums2[i] ) )
            {
                min = Math.Min( min, nums2[i] );
            }

            if ( i < nums1.Length )
            {
                min1 = Math.Min( min1, nums1[i] );
            }

            min2 = Math.Min( min2, nums2[i] );
        }

        if ( min != 10 )
        {
            return min;
        }

        if ( min1 > min2 )
        {
            return min2 * 10 + min1;
        }

        return min1 * 10 + min2;
    }
}
