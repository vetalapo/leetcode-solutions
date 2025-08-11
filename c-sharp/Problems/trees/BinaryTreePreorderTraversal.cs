/**
 * 144
 * Binary Tree Preorder Traversal
 **
 * Given the root of a binary tree,
 * return the preorder traversal of its nodes' values.
 *
 * Example 1:
 *   Input: root = [1,null,2,3]
 *   Output: [1,2,3]
 *
 * Example 2:
 *   Input: root = [1,2,3,4,5,null,8,null,null,6,7,9]
 *   Output: [1,2,4,5,6,7,3,8,9]
 *
 * Example 3:
 *   Input: root = []
 *   Output: []
 *
 * Example 4:
 *   Input: root = [1]
 *   Output: [1]
 *
 * Constraints:
 *   • The number of nodes in the tree is in the range [0, 100].
 *   • -100 <= Node.val <= 100
 *
 * Follow up:
 *   Recursive solution is trivial,
 *   could you do it iteratively?
 **
 * https://leetcode.com/problems/binary-tree-preorder-traversal/
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

public class BinaryTreePreorderTraversal
{
    public IList<int> PreorderTraversal( TreeNode root )
    {
        List<int> result = [];

        void helper( TreeNode node )
        {
            if ( node is null )
            {
                return;
            }

            result.Add( node.val );

            helper( node.left );
            helper( node.right );
        }

        helper( root );

        return result;
    }

    public IList<int> PreorderTraversalIterative( TreeNode root )
    {
        // Morris Traversal
        List<int> result = [];

        while ( root is not null )
        {
            if ( root.left is null )
            {
                result.Add( root.val );
                root = root.right;
            }
            else
            {
                TreeNode current = root.left;

                while ( current.right is not null && current.right != root )
                {
                    current = current.right;
                }

                if ( current.right == root )
                {
                    current.right = null;
                    root = root.right;
                }
                else
                {
                    result.Add( root.val );

                    current.right = root;
                    root = root.left;
                }
            }
        }

        return result;
    }
}
