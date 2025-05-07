/**
 * 520
 * Detect Capital
 **
 * We define the usage of capitals in a word to be right
 * when one of the following cases holds:
 *   • All letters in this word are capitals, like "USA".
 *   • All letters in this word are not capitals, like "leetcode".
 *   • Only the first letter in this word is capital, like "Google".
 *
 * Given a string word,
 * return true if the usage of capitals in it is right.
 *
 * Example 1:
 *   Input: word = "USA"
 *   Output: true
 *
 * Example 2:
 *   Input: word = "FlaG"
 *   Output: false
 *
 * Constraints:
 *   • 1 <= word.length <= 100
 *   • word consists of lowercase and uppercase English letters.
 **
 * https://leetcode.com/problems/detect-capital/
***/

namespace Problems;

public class DetectCapital
{
    public bool DetectCapitalUse( string word )
    {
        bool isAllCapitals = char.IsUpper( word[0] );
        bool isAllNotCapitals = char.IsLower( word[0] );
        bool isFirstOnlyCapital = char.IsUpper( word[0] );

        for ( int i = 1; i < word.Length; i++ )
        {
            if ( isAllCapitals && char.IsLower( word[i] ) )
            {
                isAllCapitals = false;
            }

            if ( isAllNotCapitals && char.IsUpper( word[i] ) )
            {
                isAllNotCapitals = false;
            }

            if ( isFirstOnlyCapital && char.IsUpper( word[i] ) )
            {
                isFirstOnlyCapital = false;
            }

            if ( !isAllCapitals && !isAllNotCapitals && !isFirstOnlyCapital )
            {
                return false;
            }
        }

        return true;
    }
}
