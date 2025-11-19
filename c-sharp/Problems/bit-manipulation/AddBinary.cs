/**
 * 67
 * Add Binary
 **
 * Given two binary strings a and b,
 * return their sum as a binary string.
 *
 * Example 1:
 *   Input: a = "11", b = "1"
 *   Output: "100"
 *
 * Example 2:
 *   Input: a = "1010", b = "1011"
 *   Output: "10101"
 *
 * Constraints:
 *   • 1 <= a.length, b.length <= 10^4
 *   • a and b consist only of '0' or '1' characters.
 *   • Each string does not contain leading zeros except for the zero itself.
 **
 * https://leetcode.com/problems/add-binary/
***/

using System;
using System.Collections.Generic;

namespace Problems;

public class AddBinarySolution
{
    public string AddBinary( string a, string b )
    {
        int ai = a.Length - 1;
        int bi = b.Length - 1;

        List<char> result = [];

        int carry = 0;

        while ( ai >= 0 || bi >= 0 || carry > 0 )
        {
            if ( ai >= 0 )
            {
                carry += a[ai] - '0';
                ai--;
            }

            if ( bi >= 0 )
            {
                carry += b[bi] - '0';
                bi--;
            }

            result.Insert( 0, (char)( ( carry & 1 ) + '0' ) );
            carry = carry > 1 ? 1 : 0;
        }

        return new String( [.. result] );
    }
}
