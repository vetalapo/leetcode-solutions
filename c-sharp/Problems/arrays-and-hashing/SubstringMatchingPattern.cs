/**
 * 3407
 * Substring Matching Pattern
 **
 * You are given a string s and a pattern string p,
 * where p contains exactly one '*' character.
 * The '*' in p can be replaced with any sequence of zero or more characters.
 *
 * Return true if p can be made a substring of s, and false otherwise.
 *
 * Example 1:
 *   Input: s = "leetcode", p = "ee*e"
 *   Output: true
 *   Explanation:
 *     By replacing the '*' with "tcod",
 *     the substring "eetcode" matches the pattern.
 *
 * Example 2:
 *   Input: s = "car", p = "c*v"
 *   Output: false
 *   Explanation:
 *     There is no substring matching the pattern.
 *
 * Example 3:
 *   Input: s = "luck", p = "u*"
 *   Output: true
 *   Explanation:
 *     The substrings "u", "uc", and "uck" match the pattern.
 *
 * Constraints:
 *   • 1 <= s.length <= 50
 *   • 1 <= p.length <= 50
 *   • s contains only lowercase English letters.
 *   • p contains only lowercase English letters and exactly one '*'
 *
 * Hint 1:
 *   Divide the pattern in two strings and search in the string.
 **
 * https://leetcode.com/problems/substring-matching-pattern/
***/

using System;

namespace Problems;

public class SubstringMatchingPattern
{
    public bool HasMatch( ReadOnlySpan<char> s, ReadOnlySpan<char> p )
    {
        int i = p.IndexOf( '*' );

        ReadOnlySpan<char> p1 = p[..i];

        int first = s.IndexOf( p1 );

        if ( first == -1 )
        {
            return false;
        }

        return s[( first + p1.Length )..]
            .IndexOf( p[( i + 1 )..] ) != -1;
    }
}
