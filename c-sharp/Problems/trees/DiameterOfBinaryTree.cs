/**
 * 543
 * Diameter of Binary Tree
 **
 * Given the root of a binary tree,
 * return the length of the diameter of the tree.
 *
 * The diameter of a binary tree
 * is the length of the longest path between any two nodes in a tree.
 * This path may or may not pass through the root.
 *
 * The length of a path between two nodes
 * is represented by the number of edges between them.
 *
 * Example 1:
 *   Input: root = [1,2,3,4,5]
 *   Output: 3
 *   Explanation:
 *     3 is the length of the path [4,2,1,3] or [5,2,1,3].
 *
 * Example 2:
 *   Input: root = [1,2]
 *   Output: 1
 *
 * Constraints:
 *   • The number of nodes in the tree is in the range [1, 10^4].
 *   • -100 <= Node.val <= 100
 **
 * https://leetcode.com/problems/diameter-of-binary-tree/
***/

using System;

using Problems.Common;

namespace Problems;

public class DiameterOfBinaryTreeSolution
{
    public int DiameterOfBinaryTree( TreeNode root )
    {
        int max = 0;

        int maxWidth( TreeNode node )
        {
            if ( node is null )
            {
                return 0;
            }

            int left = maxWidth( node.left );
            int right = maxWidth( node.right );

            max = Math.Max( max, left + right );

            return 1 + Math.Max( left, right );
        }

        maxWidth( root );

        return max;
    }
}
