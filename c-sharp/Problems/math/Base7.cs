/**
 * 504
 * Base 7
 **
 * Given an integer num,
 * return a string of its base 7 representation.
 *
 * Example 1:
 *   Input: num = 100
 *   Output: "202"
 *
 * Example 2:
 *   Input: num = -7
 *   Output: "-10"
 *
 * Constraints:
 *   • -10^7 <= num <= 10^7
 **
 * https://leetcode.com/problems/base-7/
***/

using System;

namespace Problems;

public class Base7
{
    public string ConvertToBase7( int num )
    {
        if ( num == 0 )
        {
            return "0";
        }

        bool isNegative = num < 0;
        num = Math.Abs( num );

        string result = string.Empty;

        while ( num != 0 )
        {
            result = ( num % 7 ).ToString() + result;
            num /= 7;
        }

        return isNegative ? $"-{result}" : result;
    }
}
