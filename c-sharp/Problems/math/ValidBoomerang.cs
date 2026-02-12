/**
 * 1037
 * Valid Boomerang
 **
 * Given an array points where points[i] = [Xi, Yi]
 * represents a point on the X-Y plane,
 * return true if these points are a boomerang.
 *
 * A boomerang is a set of three points
 * that are all distinct and not in a straight line.
 *
 * Example 1:
 *   Input: points = [[1,1],[2,3],[3,2]]
 *   Output: true
 *
 * Example 2:
 *   Input: points = [[1,1],[2,2],[3,3]]
 *   Output: false
 *
 * Constraints:
 *   • points.length == 3
 *   • points[i].length == 2
 *   • 0 <= Xi, Yi <= 100
 *
 * Hint 1:
 *   3 points form a boomerang
 *   if and only if the triangle formed from them
 *   has non-zero area.
 **
 * https://leetcode.com/problems/valid-boomerang/
***/

namespace Problems;

public class ValidBoomerang
{
    public bool IsBoomerang( int[][] points )
    {
        // We can check if the area of a triangle is 0
        // (Ax(By − Cy) + Bx(Cy − Ay) + Cx(Ay − By)) / 2
        // No need to divide by 2 to check if the triangle is valid
        return points[0][0] * ( points[1][1] - points[2][1] ) +
            points[1][0] * ( points[2][1] - points[0][1] ) +
            points[2][0] * ( points[0][1] - points[1][1] ) != 0;
    }
}
