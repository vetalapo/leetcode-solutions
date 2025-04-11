/**
 * 1556
 * Thousand Separator
 **
 * Given an integer n,
 * add a dot (".") as the thousands separator
 * and return it in string format.
 *
 * Example 1:
 *   Input: n = 987
 *   Output: "987"
 *
 * Example 2:
 *   Input: n = 1234
 *   Output: "1.234"
 *
 * Constraints:
 *   • 0 <= n <= 2^31 - 1
 *
 * Hint 1:
 *   Scan from the back of the integer
 *   and use dots to connect blocks with length 3 except the last block.
 **
 * https://leetcode.com/problems/thousand-separator/
***/

namespace Problems;

public class ThousandSeparatorSolution
{
    public string ThousandSeparator( int n )
    {
        if ( n <= 999 )
        {
            return n.ToString();
        }

        string result = string.Empty;

        int i = 1;

        while ( n > 0 )
        {
            result = ( i % 3 == 0 && n > 10 ? "." : "" ) + n % 10 + result;

            n /= 10;
            i++;
        }

        return result;
    }
}
