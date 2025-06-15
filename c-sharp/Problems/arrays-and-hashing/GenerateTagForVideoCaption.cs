/**
 * 3582
 * Generate Tag for Video Caption
 **
 * You are given a string caption representing the caption for a video.
 * The following actions must be performed
 * in order to generate a valid tag for the video:
 *   1. Combine all words in the string into a single camelCase string prefixed with '#'.
 *      A camelCase string is one where the first letter of all words
 *      except the first one is capitalized.
 *      All characters after the first character in each word must be lowercase.
 *   2. Remove all characters that are not an English letter, except the first '#'.
 *   3. Truncate the result to a maximum of 100 characters.
 *
 * Return the tag after performing the actions on caption.
 *
 * Example 1:
 *   Input: caption = "Leetcode daily streak achieved"
 *   Output: "#leetcodeDailyStreakAchieved"
 *   Explanation:
 *     The first letter for all words except "leetcode" should be capitalized.
 *
 * Example 2:
 *   Input: caption = "can I Go There"
 *   Output: "#canIGoThere"
 *   Explanation:
 *     The first letter for all words except "can" should be capitalized.
 *
 * Example 3:
 *   Input:
 *     caption =
 *     "hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh"
 *   Output:
 *     "#hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh"
 *   Explanation:
 *     Since the first word has length 101,
 *     we need to truncate the last two letters from the word.
 *
 * Constraints:
 *   • 1 <= caption.length <= 150
 *   • caption consists only of English letters and ' '.
 *
 * Hint 1:
 *   Simulate as described
 **
 * https://leetcode.com/problems/generate-tag-for-video-caption/
***/

using System;

namespace Problems;

public class GenerateTagForVideoCaption
{
    public string GenerateTag( string caption )
    {
        char[] result = new char[100];
        result[0] = '#';

        int rI = 1;
        int i = 0;

        while ( rI < 100 && i < caption.Length )
        {
            while ( i < caption.Length && caption[i] == ' ' )
            {
                i++;
            }

            if ( i == caption.Length )
            {
                break;
            }

            if ( i > 0 && caption[i - 1] == ' ' )
            {
                result[rI] = Char.ToUpperInvariant( caption[i] );
            }
            else
            {
                result[rI] = Char.ToLowerInvariant( caption[i] );
            }

            rI++;
            i++;
        }

        result[1] = Char.ToLowerInvariant( result[1] );

        return new string( result[0..rI] );
    }
}
