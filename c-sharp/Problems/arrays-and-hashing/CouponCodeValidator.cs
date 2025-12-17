/**
 * 3606
 * Coupon Code Validator
 **
 * You are given three arrays of length n
 * that describe the properties of n coupons:
 * code, businessLine, and isActive.
 *
 * The ith coupon has:
 *   • code[i]: a string representing the coupon identifier.
 *   • businessLine[i]: a string denoting the business category of the coupon.
 *   • isActive[i]: a boolean indicating whether the coupon is currently active.
 *
 * A coupon is considered valid
 * if all of the following conditions hold:
 *   1. code[i] is non-empty and consists only of
 *      alphanumeric characters (a-z, A-Z, 0-9) and underscores (_).
 *   2. businessLine[i] is one of the following four categories:
 *      "electronics", "grocery", "pharmacy", "restaurant".
 *   3. isActive[i] is true.
 *
 * Return an array of the codes of all valid coupons,
 * sorted first by their businessLine in the order:
 * "electronics", "grocery", "pharmacy", "restaurant",
 * and then by code in lexicographical (ascending) order within each category.
 *
 * Example 1:
 *   Input:
 *     code = ["SAVE20","","PHARMA5","SAVE@20"],
 *     businessLine = ["restaurant","grocery","pharmacy","restaurant"],
 *     isActive = [true,true,true,true]
 *   Output:
 *     ["PHARMA5","SAVE20"]
 *   Explanation:
 *     • First coupon is valid.
 *     • Second coupon has empty code (invalid).
 *     • Third coupon is valid.
 *     • Fourth coupon has special character @ (invalid).
 *
 * Example 2:
 *   Input:
 *     code = ["GROCERY15","ELECTRONICS_50","DISCOUNT10"],
 *     businessLine = ["grocery","electronics","invalid"],
 *     isActive = [false,true,true]
 *   Output:
 *     ["ELECTRONICS_50"]
 *   Explanation:
 *     • First coupon is inactive (invalid).
 *     • Second coupon is valid.
 *     • Third coupon has invalid business line (invalid).
 *
 * Constraints:
 *   • n == code.length == businessLine.length == isActive.length
 *   • 1 <= n <= 100
 *   • 0 <= code[i].length, businessLine[i].length <= 100
 *   • code[i] and businessLine[i] consist of printable ASCII characters.
 *   • isActive[i] is either true or false.
 *
 * Hint 1:
 *   Filter out any coupon where isActive[i] is false,
 *   code[i] is empty or contains non‑alphanumeric/underscore chars,
 *   or businessLine[i] is not in the allowed set
 *
 * Hint 2:
 *   Store each remaining coupon as a pair (businessLine[i], code[i])
 *
 * Hint 3:
 *   Define a priority map,
 *   e.g. {"electronics":0, "grocery":1, "pharmacy":2, "restaurant":3}
 *
 * Hint 4:
 *   Sort the list of pairs by (priority[businessLine], code)
 *   and return the code values in order
 **
 * https://leetcode.com/problems/coupon-code-validator/
***/

using System;
using System.Collections.Generic;

namespace Problems;

public class CouponCodeValidator
{
    public IList<string> ValidateCoupons( string[] code, string[] businessLine, bool[] isActive )
    {
        List<string>[] groups = new List<string>[4];

        for ( int i = 0; i < groups.Length; i++ )
        {
            groups[i] = new List<string>();
        }

        for ( int i = 0; i < code.Length; i++ )
        {
            if (
                isActive[i] &&
                GetCategoryOrder( businessLine[i], out int catIndex ) &&
                IsValidCoupon( code[i] )
            )
            {
                groups[catIndex].Add( code[i] );
            }
        }

        List<string> result = [];

        for ( int i = 0; i < groups.Length; i++ )
        {
            groups[i].Sort( StringComparer.Ordinal );
            result.AddRange( groups[i] );
        }

        return result;
    }

    private bool IsValidCoupon( string coupon )
    {
        if ( String.IsNullOrWhiteSpace( coupon ) )
        {
            return false;
        }

        foreach ( char c in coupon )
        {
            if ( !( c == '_' || Char.IsLetterOrDigit( c ) ) )
            {
                return false;
            }
        }

        return true;
    }

    private bool GetCategoryOrder( string category, out int index )
    {
        index = category switch
        {
            "electronics" => 0,
            "grocery" => 1,
            "pharmacy" => 2,
            "restaurant" => 3,
            _ => 4
        };

        return index < 4;
    }
}
