/**
 * 3663
 * Find The Least Frequent Digit
 **
 * Given an integer n,
 * find the digit that occurs least frequently in its decimal representation.
 * If multiple digits have the same frequency,
 * choose the smallest digit.
 *
 * Return the chosen digit as an integer.
 *
 * The frequency of a digit x is the number of times
 * it appears in the decimal representation of n.
 *
 * Example 1:
 *   Input: n = 1553322
 *   Output: 1
 *   Explanation:
 *     The least frequent digit in n is 1,
 *     which appears only once.
 *     All other digits appear twice.
 *
 * Example 2:
 *   Input: n = 723344511
 *   Output: 2
 *   Explanation:
 *     The least frequent digits in n are 7, 2, and 5;
 *     each appears only once.
 *
 * Constraints:
 *   • 1 <= n <= 2^31​​​​​​​ - 1
 **
 * https://leetcode.com/problems/find-the-least-frequent-digit/
***/

namespace Problems;

public class FindTheLeastFrequentDigit
{
    public int GetLeastFrequentDigit( int n )
    {
        int[] map = new int[10];

        while ( n > 0 )
        {
            map[n % 10]++;
            n /= 10;
        }

        int min = 10;
        int result = 0;

        for ( int i = 0; i < map.Length; i++ )
        {
            if ( map[i] > 0 && map[i] < min )
            {
                min = map[i];
                result = i;
            }
        }

        return result;
    }
}
