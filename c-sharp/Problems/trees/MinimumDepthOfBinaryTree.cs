/**
 * 111
 * Minimum Depth of Binary Tree
 **
 * Given a binary tree, find its minimum depth.
 *
 * The minimum depth is the number of nodes along the shortest path
 * from the root node down to the nearest leaf node.
 *
 * Note: A leaf is a node with no children.
 *
 * Example 1:
 *   Input: root = [3,9,20,null,null,15,7]
 *   Output: 2
 *
 * Example 2:
 *   Input: root = [2,null,3,null,4,null,5,null,6]
 *   Output: 5
 *
 * Constraints:
 *   • The number of nodes in the tree is in the range [0, 10^5].
 *   • -1000 <= Node.val <= 1000
 **
 * https://leetcode.com/problems/minimum-depth-of-binary-tree/
***/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
***/

using System.Collections.Generic;

using Problems.Common;

namespace Problems;

public class MinimumDepthOfBinaryTree
{
    public int MinDepth( TreeNode root )
    {
        if ( root is null )
        {
            return 0;
        }

        Queue<(TreeNode, int)> queue = [];
        queue.Enqueue( (root, 1) );

        while ( queue.Count > 0 )
        {
            (TreeNode currNode, int currNodeDepth) = queue.Dequeue();

            if ( currNode.left is null && currNode.right is null )
            {
                return currNodeDepth;
            }

            if ( currNode.left is not null )
            {
                queue.Enqueue( (currNode.left, currNodeDepth + 1) );
            }

            if ( currNode.right is not null )
            {
                queue.Enqueue( (currNode.right, currNodeDepth + 1) );
            }
        }

        return 0;
    }
}
