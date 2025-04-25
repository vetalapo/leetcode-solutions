/**
 * 1941
 * Check if All Characters Have Equal Number of Occurrences
 **
 * Given a string s,
 * return true if s is a good string,
 * or false otherwise.
 *
 * A string s is good
 * if all the characters that appear in s
 * have the same number of occurrences
 * (i.e., the same frequency).
 *
 * Example 1:
 *   Input: s = "abacbc"
 *   Output: true
 *   Explanation:
 *     The characters that appear in s are 'a', 'b', and 'c'.
 *     All characters occur 2 times in s.
 *
 * Example 2:
 *   Input: s = "aaabb"
 *   Output: false
 *   Explanation:
 *     The characters that appear in s are 'a' and 'b'.
 *     'a' occurs 3 times while 'b' occurs 2 times,
 *     which is not the same number of times.
 *
 * Constraints:
 *   • 1 <= s.length <= 1000
 *   • s consists of lowercase English letters.
 *
 * Hint 1:
 *   Build a dictionary containing the frequency of each character appearing in s
 *
 * Hint 2:
 *   Check if all values in the dictionary are the same.
 **
 * https://leetcode.com/problems/check-if-all-characters-have-equal-number-of-occurrences/
***/

namespace Problems;

public class CheckIfAllCharactersHaveEqualNumberOfOccurrences
{
    public bool AreOccurrencesEqual( string s )
    {
        int[] freqMap = new int[26];

        foreach ( char c in s )
        {
            freqMap[c - 'a']++;
        }

        int firstElementFrequency = freqMap[s[0] - 'a'];

        foreach ( int freq in freqMap )
        {
            if ( freq != 0 && freq != firstElementFrequency )
            {
                return false;
            }
        }

        return true;
    }
}
