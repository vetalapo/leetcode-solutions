/**
 * 1446
 * Consecutive Characters
 **
 * The power of the string is the maximum length of a non-empty substring
 * that contains only one unique character.
 *
 * Given a string s, return the power of s.
 *
 * Example 1:
 *   Input: s = "leetcode"
 *   Output: 2
 *   Explanation:
 *     The substring "ee" is of length 2 with the character 'e' only.
 *
 * Example 2:
 *   Input: s = "abbcccddddeeeeedcba"
 *   Output: 5
 *   Explanation:
 *     The substring "eeeee" is of length 5 with the character 'e' only.
 *
 * Constraints:
 *   • 1 <= s.length <= 500
 *   • s consists of only lowercase English letters.
 *
 * Hint 1:
 *   Keep an array power where
 *   power[i] is the maximum power of the i-th character.
 *
 * Hint 2:
 *   The answer is max(power[i]).
 **
 * https://leetcode.com/problems/consecutive-characters/
***/

using System;

namespace Problems;

public class ConsecutiveCharacters
{
    public int MaxPower( string s )
    {
        int max = 0;

        for ( int i = 0; i < s.Length; i++ )
        {
            int j = i + 1;

            while ( j < s.Length && s[i] == s[j] )
            {
                j++;
            }

            max = Math.Max( max, j - i );

            i = j - 1;
        }

        return max;
    }
}
