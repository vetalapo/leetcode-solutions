/**
 * 387
 * First Unique Character in a String
 **
 * Given a string s,
 * find the first non-repeating character in it and return its index.
 * If it does not exist, return -1.
 *
 * Example 1:
 *   Input: s = "leetcode"
 *   Output: 0
 *   Explanation:
 *     The character 'l' at index 0
 *     is the first character
 *     that does not occur at any other index.
 *
 * Example 2:
 *   Input: s = "loveleetcode"
 *   Output: 2
 *
 * Example 3:
 *   Input: s = "aabb"
 *   Output: -1
 *
 * Constraints:
 *   • 1 <= s.length <= 10^5
 *   • s consists of only lowercase English letters.
 **
 * https://leetcode.com/problems/first-unique-character-in-a-string/
***/

namespace Problems;

public class FirstUniqueCharacterInAString
{
    public int FirstUniqChar( string s )
    {
        int[] map = new int[26];

        foreach ( char c in s )
        {
            map[c - 'a']++;
        }

        for ( int i = 0; i < s.Length; i++ )
        {
            if ( map[s[i] - 'a'] == 1 )
            {
                return i;
            }
        }

        return -1;
    }
}
