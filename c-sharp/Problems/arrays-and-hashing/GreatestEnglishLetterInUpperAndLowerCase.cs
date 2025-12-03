/**
 * 2309
 * Greatest English Letter in Upper and Lower Case
 **
 * Given a string of English letters s,
 * return the greatest English letter
 * which occurs as both a lowercase and uppercase letter in s.
 * The returned letter should be in uppercase.
 * If no such letter exists, return an empty string.
 *
 * An English letter b is greater than another letter a
 * if b appears after a in the English alphabet.
 *
 * Example 1:
 *   Input: s = "lEeTcOdE"
 *   Output: "E"
 *   Explanation:
 *     The letter 'E' is the only letter
 *     to appear in both lower and upper case.
 *
 * Example 2:
 *   Input: s = "arRAzFif"
 *   Output: "R"
 *   Explanation:
 *     The letter 'R' is the greatest letter
 *     to appear in both lower and upper case.
 *     Note that 'A' and 'F' also appear in both lower and upper case,
 *     but 'R' is greater than 'F' or 'A'.
 *
 * Example 3:
 *   Input: s = "AbCdEfGhIjK"
 *   Output: ""
 *   Explanation:
 *     There is no letter that appears in both lower and upper case.
 *
 * Constraints:
 *   • 1 <= s.length <= 1000
 *   • s consists of lowercase and uppercase English letters.
 *
 * Hint 1:
 *   Consider iterating through the string
 *   and storing each unique character that occurs in a set.
 *
 * Hint 2:
 *   From Z to A,
 *   check whether both the uppercase and lowercase version occur in the set.
 **
 * https://leetcode.com/problems/greatest-english-letter-in-upper-and-lower-case/
***/

using System;

namespace Problems;

public class GreatestEnglishLetterInUpperAndLowerCase
{
    public string GreatestLetter( string s )
    {
        for ( char i = 'Z'; i >= 'A'; i-- )
        {
            if ( s.Contains( i ) && s.Contains( (char)( i ^ 32 ) ) )
            {
                return i.ToString();
            }
        }

        return string.Empty;
    }

    public string GreatestLetterMap( string s )
    {
        bool[] map = new bool[123];
        int max = 0;

        foreach ( char c in s )
        {
            if ( map[c ^ 32] )
            {
                max = Math.Max( max, c < 97 ? c ^ 32 : c );
            }

            map[c] = true;
        }

        return max == 0
            ? string.Empty
            : ( (char)( max ^ 32 ) ).ToString();
    }
}
