/**
 * 3136
 * Valid Word
 **
 * A word is considered valid if:
 *   • It contains a minimum of 3 characters.
 *   • It contains only digits (0-9), and English letters (uppercase and lowercase).
 *   • It includes at least one vowel.
 *   • It includes at least one consonant.
 *
 * You are given a string word.
 * Return true if word is valid,
 * otherwise, return false.
 *
 * Notes:
 *   • 'a', 'e', 'i', 'o', 'u', and their uppercases are vowels.
 *   • A consonant is an English letter that is not a vowel.
 *
 * Example 1:
 *   Input: word = "234Adas"
 *   Output: true
 *   Explanation:
 *     This word satisfies the conditions.
 *
 * Example 2:
 *   Input: word = "b3"
 *   Output: false
 *   Explanation:
 *     The length of this word is fewer than 3,
 *     and does not have a vowel.
 *
 * Example 3:
 *   Input: word = "a3$e"
 *   Output: false
 *   Explanation:
 *     This word contains a '$' character
 *     and does not have a consonant.
 *
 * Constraints:
 *   • 1 <= word.length <= 20
 *   • word consists of English uppercase and lowercase letters, digits, '@', '#', and '$'.
 *
 * Hint 1:
 *   Use if-else to check all the conditions.
 **
 * https://leetcode.com/problems/valid-word/
***/

namespace Problems;

public class ValidWord
{
    public bool IsValid( string word )
    {
        if ( word.Length < 3 )
        {
            return false;
        }

        bool containsVowel = false;
        bool containsConsonant = false;

        foreach ( char c in word )
        {
            if ( !IsInRange( c ) )
            {
                return false;
            }

            if ( !containsVowel )
            {
                containsVowel = IsVowel( c );
            }

            if ( !containsConsonant )
            {
                containsConsonant = IsConsonant( c );
            }
        }

        return containsVowel && containsConsonant;
    }

    private static bool IsInRange( char c )
    {
        return ( c >= '0' && c <= '9' ) || ( c >= 'A' && c <= 'z' );
    }

    private static bool IsVowel( char c )
    {
        if ( c < 'A' )
        {
            return false;
        }

        switch ( c )
        {
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                return true;
        }

        return false;
    }

    private static bool IsConsonant( char c )
    {
        return c >= 'A' && !IsVowel( c );
    }
}
