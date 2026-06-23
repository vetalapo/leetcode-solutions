/**
 * 1189
 * Maximum Number of Balloons
 **
 * Given a string text,
 * you want to use the characters of text
 * to form as many instances of the word "balloon" as possible.
 *
 * You can use each character in text at most once.
 * Return the maximum number of instances that can be formed.
 *
 * Example 1:
 *   Input: text = "nlaebolko"
 *   Output: 1
 *
 * Example 2:
 *   Input: text = "loonbalxballpoon"
 *   Output: 2
 *
 * Example 3:
 *   Input: text = "leetcode"
 *   Output: 0
 *
 * Constraints:
 *   • 1 <= text.length <= 10^4
 *   • text consists of lower case English letters only.
 *
 * Note:
 *   This question is the same as
 *   2287: Rearrange Characters to Make Target String.
 *   https://leetcode.com/problems/rearrange-characters-to-make-target-string/
 *
 * Hint 1:
 *   Count the frequency of letters in the given string.
 *
 * Hint 2:
 *   Find the letter than can make the minimum number of instances of the word "balloon".
 **
 * https://leetcode.com/problems/maximum-number-of-balloons/
***/

using System;

namespace Problems;

public class MaximumNumberOfBalloons
{
    public int MaxNumberOfBalloons( string text )
    {
        int[] countMap = new int[26];

        foreach ( char c in text )
        {
            countMap[c - 'a']++;
        }

        int min = countMap[1];
        string word = "balon";

        for ( int i = 1; i < word.Length; i++ )
        {
            if ( word[i] == 'l' || word[i] == 'o' )
            {
                min = Math.Min( min, countMap[word[i] - 'a'] >> 1 );
            }
            else
            {
                min = Math.Min( min, countMap[word[i] - 'a'] );
            }
        }

        return min;
    }
}