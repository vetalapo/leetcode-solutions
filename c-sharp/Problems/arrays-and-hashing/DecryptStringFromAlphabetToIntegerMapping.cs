/**
 * 1309
 * Decrypt String from Alphabet to Integer Mapping
 **
 * You are given a string s formed by digits and '#'.
 * We want to map s to English lowercase characters as follows:
 *   • Characters ('a' to 'i')
 *     are represented by ('1' to '9') respectively.
 *   • Characters ('j' to 'z')
 *     are represented by ('10#' to '26#') respectively.
 *
 * Return the string formed after mapping.
 *
 * The test cases are generated
 * so that a unique mapping will always exist.
 *
 * Example 1:
 *   Input: s = "10#11#12"
 *   Output: "jkab"
 *   Explanation:
 *     "j" -> "10#" , "k" -> "11#" , "a" -> "1" , "b" -> "2".
 *
 * Example 2:
 *   Input: s = "1326#"
 *   Output: "acz"
 *
 * Constraints:
 *   • 1 <= s.length <= 1000
 *   • s consists of digits and the '#' letter.
 *   • s will be a valid string such that mapping is always possible.
 *
 * Hint 1:
 *   Scan from right to left,
 *   in each step of the scanning check
 *   whether there is a trailing "#" 2 indexes away.
 **
 * https://leetcode.com/problems/decrypt-string-from-alphabet-to-integer-mapping/
***/

using System.Text;

namespace Problems;

public class DecryptStringFromAlphabetToIntegerMapping
{
    public string FreqAlphabets( string s )
    {
        StringBuilder result = new();

        for ( int i = s.Length - 1; i >= 0; i-- )
        {
            if ( s[i] == '#' )
            {
                result.Insert( 0, (char)( 96 + ( s[i - 2] - '0' ) * 10 + ( s[i - 1] - '0' ) ) );

                i -= 2;
            }
            else
            {
                result.Insert( 0, (char)( 48 + s[i] ) );
            }
        }

        return result.ToString();
    }
}
