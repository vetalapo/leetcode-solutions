/**
 * 345
 * Reverse Vowels of a String
 **
 * Given a string s,
 * reverse only all the vowels in the string and return it.
 *
 * The vowels are 'a', 'e', 'i', 'o', and 'u',
 * and they can appear in both lower and upper cases,
 * more than once.
 *
 * Example 1:
 *   Input: s = "IceCreAm"
 *   Output: "AceCreIm"
 *   Explanation:
 *     The vowels in s are ['I', 'e', 'e', 'A'].
 *     On reversing the vowels, s becomes "AceCreIm".
 *
 * Example 2:
 *   Input: s = "leetcode"
 *   Output: "leotcede"
 *
 * Constraints:
 *   • 1 <= s.length <= 3 * 10^5
 *   • s consist of printable ASCII characters.
 **
 * https://leetcode.com/problems/reverse-vowels-of-a-string/
***/

using System;

namespace Problems;

public class ReverseVowelsOfAString
{
    public string ReverseVowels( string s )
    {
        char[] resultArr = s.ToCharArray();

        int left = 0;
        int right = s.Length - 1;

        while ( left < right )
        {
            while ( !IsVowel( resultArr[left] ) && left < right )
            {
                left++;
            }

            while ( !IsVowel( resultArr[right] ) && left < right )
            {
                right--;
            }

            (resultArr[left], resultArr[right]) = (resultArr[right], resultArr[left]);

            left++;
            right--;
        }

        return new String( resultArr );
    }

    private static bool IsVowel( char c )
    {
        switch ( c )
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                return true;
        }

        return false;
    }
}
