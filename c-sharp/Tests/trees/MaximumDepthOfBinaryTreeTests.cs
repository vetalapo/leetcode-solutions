using System.Collections;

using NUnit.Framework;

using Problems;
using Problems.Common;

public class MaximumDepthOfBinaryTreeTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int MaxDepthTest( TreeNode root ) =>
        new MaximumDepthOfBinaryTree().MaxDepth( root );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( TreeNode.Create( [3, 9, 20, null, null, 15, 7] ) ).Returns( 3 );

            yield return new TestCaseData( TreeNode.Create( [1, null, 2] ) ).Returns( 2 );

            yield return new TestCaseData( TreeNode.Create( [] ) ).Returns( 0 );
        }
    }
}
