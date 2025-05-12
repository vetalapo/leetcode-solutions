using System.Collections;

using NUnit.Framework;

using Problems;
using Problems.Common;

public class InvertBinaryTreeTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public TreeNode InvertTreeTest( TreeNode root ) =>
        new InvertBinaryTree().InvertTree( root );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( TreeNode.CreateBST( [4, 2, 7, 1, 3, 6, 9] ) )
                .Returns( TreeNode.CreateDescBST( [4, 7, 2, 9, 6, 3, 1] ) );

            yield return new TestCaseData( TreeNode.CreateBST( [2, 1, 3] ) )
                .Returns( TreeNode.CreateDescBST( [2, 3, 1] ) );

            yield return new TestCaseData( TreeNode.CreateBST( [] ) )
                .Returns( TreeNode.CreateDescBST( [] ) );
        }
    }
}
