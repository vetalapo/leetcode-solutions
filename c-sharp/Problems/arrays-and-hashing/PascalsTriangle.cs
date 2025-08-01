/**
 * 118
 * Pascal's Triangle
 **
 * Given an integer numRows,
 * return the first numRows of Pascal's triangle.
 *
 * In Pascal's triangle,
 * each number is the sum of the two numbers directly above.
 *
 * Example 1:
 *   Input: numRows = 5
 *   Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
 *
 * Example 2:
 *   Input: numRows = 1
 *   Output: [[1]]
 *
 * Constraints:
 *   • 1 <= numRows <= 30
 **
 * https://leetcode.com/problems/pascals-triangle/
***/

using System.Collections.Generic;

namespace Problems;

public class PascalsTriangle
{
    public IList<IList<int>> Generate( int numRows )
    {
        int[][] result = new int[numRows][];

        result[0] = [1];

        for ( int i = 1; i < numRows; i++ )
        {
            result[i] = new int[i + 1];
            result[i][0] = 1;
            result[i][^1] = 1;

            for ( int j = 1; j < i; j++ )
            {
                result[i][j] = result[i - 1][j - 1] + result[i - 1][j];
            }
        }

        return result;
    }
}
