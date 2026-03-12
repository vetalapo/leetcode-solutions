/**
 * 925
 * Long Pressed Name
 **
 * Your friend is typing his name into a keyboard.
 * Sometimes, when typing a character c,
 * the key might get long pressed,
 * and the character will be typed 1 or more times.
 *
 * You examine the typed characters of the keyboard.
 * Return True if it is possible that it was your friends name,
 * with some characters (possibly none) being long pressed.
 *
 * Example 1:
 *   Input: name = "alex", typed = "aaleex"
 *   Output: true
 *   Explanation:
 *     'a' and 'e' in 'alex' were long pressed.
 *
 * Example 2:
 *   Input: name = "saeed", typed = "ssaaedd"
 *   Output: false
 *   Explanation:
 *     'e' must have been pressed twice,
 *     but it was not in the typed output.
 *
 * Constraints:
 *   • 1 <= name.length, typed.length <= 1000
 *   • name and typed consist of only lowercase English letters.
 **
 * https://leetcode.com/problems/long-pressed-name/
***/

namespace Problems;

public class LongPressedName
{
    public bool IsLongPressedName( string name, string typed )
    {
        if ( name.Length > typed.Length )
        {
            return false;
        }

        int j = 0;

        for ( int i = 0; i < name.Length; i++ )
        {
            if ( j == typed.Length || name[i] != typed[j] )
            {
                return false;
            }

            int temp = i++;

            while ( i < name.Length && name[i] == name[temp] )
            {
                i++;
            }

            i--;

            int count = 0;

            while ( j < typed.Length && typed[j] == name[temp] )
            {
                count++;
                j++;
            }

            if ( i - temp + 1 > count )
            {
                return false;
            }
        }

        return j == typed.Length;
    }
}
