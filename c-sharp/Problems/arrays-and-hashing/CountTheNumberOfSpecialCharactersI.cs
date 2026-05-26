/**
 * 3120
 * Count the Number of Special Characters I
 **
 * You are given a string word.
 * A letter is called special
 * if it appears both in lowercase and uppercase in word.
 *
 * Return the number of special letters in word.
 *
 * Example 1:
 *   Input: word = "aaAbcBC"
 *   Output: 3
 *   Explanation:
 *     The special characters in word are 'a', 'b', and 'c'.
 *
 * Example 2:
 *   Input: word = "abc"
 *   Output: 0
 *   Explanation:
 *     No character in word appears in uppercase.
 *
 * Example 3:
 *   Input: word = "abBCab"
 *   Output: 1
 *   Explanation:
 *     The only special character in word is 'b'.
 *
 * Constraints:
 *   • 1 <= word.length <= 50
 *   • word consists of only lowercase and uppercase English letters.
 *
 * Hint 1:
 *   The constraints are small.
 *   For all 52 characters,
 *   check if they are present in word.
 **
 * https://leetcode.com/problems/count-the-number-of-special-characters-i/
***/

namespace Problems;

public class CountTheNumberOfSpecialCharactersI
{
    public int NumberOfSpecialChars( string word )
    {
        int count = 0;
        bool[] map = new bool['z' + 1];

        foreach ( char c in word )
        {
            if ( !map[c] && map[c ^ 32] )
            {
                count++;
            }

            map[c] = true;
        }

        return count;
    }
}
