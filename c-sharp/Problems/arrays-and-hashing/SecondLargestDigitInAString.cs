/**
 * 1796
 * Second Largest Digit in a String
 **
 * Given an alphanumeric string s,
 * return the second largest numerical digit
 * that appears in s,
 * or -1 if it does not exist.
 *
 * An alphanumeric string
 * is a string consisting of lowercase English letters and digits.
 *
 * Example 1:
 *   Input: s = "dfa12321afd"
 *   Output: 2
 *   Explanation:
 *     The digits that appear in s are [1, 2, 3].
 *     The second largest digit is 2.
 *
 * Example 2:
 *   Input: s = "abc1111"
 *   Output: -1
 *   Explanation:
 *     The digits that appear in s are [1].
 *     There is no second largest digit.
 *
 * Constraints:
 *   • 1 <= s.length <= 500
 *   • s consists of only lowercase English letters and digits.
 *
 * Hint 1:
 *   First of all,
 *   get the distinct characters since we are only interested in those
 *
 * Hint 2:
 *   Let's note that there might not be any digits.
 **
 * https://leetcode.com/problems/second-largest-digit-in-a-string/
***/

namespace Problems;

public class SecondLargestDigitInAString
{
    public int SecondHighest( string s )
    {
        int largest = -1;
        int secondLargest = -1;

        foreach ( char c in s.ToCharArray() )
        {
            if ( c >= '0' && c <= '9' )
            {
                int currNum = c - '0';

                if ( currNum > largest )
                {
                    secondLargest = largest;
                    largest = currNum;
                }
                else if ( currNum != largest && currNum > secondLargest )
                {
                    secondLargest = currNum;
                }
            }
        }

        return secondLargest;
    }
}
