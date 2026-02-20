using System.Collections.Generic;

namespace Problems.Common;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode( int val = 0, TreeNode left = null, TreeNode right = null )
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public static TreeNode Create( int?[] values )
    {
        if ( values.Length == 0 || values[0] is null )
        {
            return null;
        }

        TreeNode root = new( (int)values[0] );

        Queue<TreeNode> queue = [];
        queue.Enqueue( root );

        for ( int i = 1; i < values.Length; i += 2 )
        {
            TreeNode node = queue.Dequeue();

            node.left = values[i] is null
                ? null
                : new TreeNode( (int)values[i] );

            node.right = i + 1 >= values.Length || values[i + 1] is null
                ? null
                : new TreeNode( (int)values[i + 1] );

            if ( node.left is not null )
            {
                queue.Enqueue( node.left );
            }

            if ( node.right is not null )
            {
                queue.Enqueue( node.right );
            }
        }

        return root;
    }

    // BST: Binary Search Tree
    public static TreeNode CreateBST( int[] values )
    {
        if ( values.Length == 0 )
        {
            return null;
        }

        TreeNode result = new()
        {
            val = values[0]
        };

        for ( int i = 1; i < values.Length; i++ )
        {
            TreeNode temp = result;

            while ( true )
            {
                if ( values[i] == temp.val )
                {
                    break;
                }
                else if ( values[i] > temp.val )
                {
                    if ( temp.right is null )
                    {
                        temp.right = new TreeNode( values[i] );

                        break;
                    }
                    else
                    {
                        temp = temp.right;
                    }
                }
                else
                {
                    if ( temp.left is null )
                    {
                        temp.left = new TreeNode( values[i] );

                        break;
                    }
                    else
                    {
                        temp = temp.left;
                    }
                }
            }
        }

        return result;
    }

    // BST: Binary Search Tree
    public static TreeNode CreateDescBST( int[] values )
    {
        if ( values.Length == 0 )
        {
            return null;
        }

        TreeNode result = new()
        {
            val = values[0]
        };

        for ( int i = 1; i < values.Length; i++ )
        {
            TreeNode temp = result;

            while ( true )
            {
                if ( values[i] == temp.val )
                {
                    break;
                }
                else if ( values[i] < temp.val )
                {
                    if ( temp.right is null )
                    {
                        temp.right = new TreeNode( values[i] );

                        break;
                    }
                    else
                    {
                        temp = temp.right;
                    }
                }
                else
                {
                    if ( temp.left is null )
                    {
                        temp.left = new TreeNode( values[i] );

                        break;
                    }
                    else
                    {
                        temp = temp.left;
                    }
                }
            }
        }

        return result;
    }

    public override bool Equals( object? obj )
    {
        return obj is TreeNode treeNode &&
            val == treeNode.val &&
            EqualityComparer<TreeNode>.Default.Equals( left, treeNode.left ) &&
            EqualityComparer<TreeNode>.Default.Equals( right, treeNode.right );
    }

    public override string ToString()
    {
        List<int> values = [];

        // Level Order Traversal
        // TODO: Check correctness, probably there's no need in nested loops
        Queue<TreeNode> treeQueue = [];
        treeQueue.Enqueue( this );

        while ( treeQueue.Count > 0 )
        {
            for ( int i = 0; i < treeQueue.Count; i++ )
            {
                TreeNode currNode = treeQueue.Dequeue();

                values.Add( currNode.val );

                if ( currNode.left is not null )
                {
                    treeQueue.Enqueue( currNode.left );
                }

                if ( currNode.right is not null )
                {
                    treeQueue.Enqueue( currNode.right );
                }
            }
        }

        return $"[{string.Join( ", ", values )}]";
    }
}
