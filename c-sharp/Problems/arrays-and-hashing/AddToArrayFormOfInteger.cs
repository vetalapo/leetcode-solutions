/**
 * 989
 * Add to Array-Form of Integer
 **
 * The array-form of an integer num is an array
 * representing its digits in left to right order.
 *   • For example, for num = 1321, the array form is [1,3,2,1].
 *
 * Given num,
 * the array-form of an integer,
 * and an integer k,
 * return the array-form of the integer num + k.
 *
 * Example 1:
 *   Input: num = [1,2,0,0], k = 34
 *   Output: [1,2,3,4]
 *   Explanation: 1200 + 34 = 1234
 *
 * Example 2:
 *   Input: num = [2,7,4], k = 181
 *   Output: [4,5,5]
 *   Explanation: 274 + 181 = 455
 *
 * Example 3:
 *   Input: num = [2,1,5], k = 806
 *   Output: [1,0,2,1]
 *   Explanation: 215 + 806 = 1021
 *
 * Constraints:
 *   • 1 <= num.length <= 10^4
 *   • 0 <= num[i] <= 9
 *   • num does not contain any leading zeros except for the zero itself.
 *   • 1 <= k <= 10^4
 **
 * https://leetcode.com/problems/add-to-array-form-of-integer/
***/

using System;
using System.Collections.Generic;

namespace Problems;

public class AddToArrayFormOfInteger
{
    public IList<int> AddToArrayForm( int[] num, int k )
    {
        int i = num.Length - 1;
        int carry = 0;

        while ( i >= 0 && ( carry > 0 || k > 0 ) )
        {
            int currSum = carry + num[i] + ( k % 10 );
            num[i] = currSum % 10;
            carry = currSum / 10;

            i--;
            k /= 10;
        }

        carry += k;

        if ( carry == 0 )
        {
            return num;
        }

        int[] former = new int[(int)Math.Log10( carry ) + 1];

        int j = former.Length - 1;

        while ( carry > 0 )
        {
            former[j] = carry % 10;
            carry /= 10;

            j--;
        }

        List<int> result = new( former );
        result.AddRange( num );

        return result;
    }
}
