/**
 * 3794
 * Reverse String Prefix
 **
 * You are given a string s and an integer k.
 * Reverse the first k characters of s and return the resulting string.
 *
 * Example 1:
 *   Input: s = "abcd", k = 2
 *   Output: "bacd"
 *   Explanation:​​​​​​​
 *     The first k = 2 characters "ab" are reversed to "ba".
 *     The final resulting string is "bacd".
 *
 * Example 2:
 *   Input: s = "xyz", k = 3
 *   Output: "zyx"
 *   Explanation:
 *     The first k = 3 characters "xyz" are reversed to "zyx".
 *     The final resulting string is "zyx".
 *
 * Example 3:
 *   Input: s = "hey", k = 1
 *   Output: "hey"
 *   Explanation:
 *     The first k = 1 character "h" remains unchanged on reversal.
 *     The final resulting string is "hey".
 *
 * Constraints:
 *   • 1 <= s.length <= 100
 *   • s consists of lowercase English letters.
 *   • 1 <= k <= s.length
 *
 * Hint 1:
 *   Simulate as described
 **
 * https://leetcode.com/problems/reverse-string-prefix/
***/

using System;

namespace Problems;

public class ReverseStringPrefix
{
    public string ReversePrefix( string s, int k )
    {
        char[] chars = s.ToCharArray();

        int left = 0;
        int right = k - 1;

        while ( left < right )
        {
            (chars[left], chars[right]) = (chars[right], chars[left]);

            left++;
            right--;
        }

        return new String( chars );
    }
}
