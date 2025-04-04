/**
 * 917
 * Reverse Only Letters
 **
 * Given a string s,
 * reverse the string according to the following rules:
 *   • All the characters that are not English letters remain in the same position.
 *   • All the English letters (lowercase or uppercase) should be reversed.
 *
 * Return s after reversing it.
 *
 * Example 1:
 *   Input: s = "ab-cd"
 *   Output: "dc-ba"
 *
 * Example 2:
 *   Input: s = "a-bC-dEf-ghIj"
 *   Output: "j-Ih-gfE-dCba"
 *
 * Example 3:
 *   Input: s = "Test1ng-Leet=code-Q!"
 *   Output: "Qedo1ct-eeLg=ntse-T!"
 *
 * Constraints:
 *   • 1 <= s.length <= 100
 *   • s consists of characters with ASCII values in the range [33, 122].
 *   • s does not contain '\"' or '\\'.
 *
 * Hint 1:
 *   This problem is exactly like reversing a normal string
 *   except that there are certain characters
 *   that we have to simply skip.
 *   That should be easy enough to do
 *   if you know how to reverse a string using the two-pointer approach.
 **
 * https://leetcode.com/problems/reverse-only-letters/
***/

using System;

namespace Problems;

public class ReverseOnlyLettersSolution
{
    public string ReverseOnlyLetters( string s )
    {
        char[] result = s.ToCharArray();

        int left = 0;
        int right = s.Length - 1;

        while ( left < right )
        {
            while ( !IsLetter( result[left] ) && left < right )
            {
                left++;
            }

            while ( !IsLetter( result[right] ) && left < right )
            {
                right--;
            }

            (result[left], result[right]) = (result[right], result[left]);

            left++;
            right--;
        }

        return new String( result );
    }

    private static bool IsLetter( char c )
    {
        return ( c >= 'A' && c <= 'Z' ) ||
               ( c >= 'a' && c <= 'z' );
    }
}
