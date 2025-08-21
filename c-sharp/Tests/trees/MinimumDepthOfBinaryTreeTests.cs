using System.Collections;

using NUnit.Framework;

using Problems;
using Problems.Common;

public class MinimumDepthOfBinaryTreeTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int MinDepthTest( TreeNode root ) =>
        new MinimumDepthOfBinaryTree().MinDepth( root );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( TreeNode.Create( [3, 9, 20, null, null, 15, 7] ) )
                .Returns( 2 );

            yield return new TestCaseData( TreeNode.Create( [2, null, 3, null, 4, null, 5, null, 6] ) )
                .Returns( 5 );

            yield return new TestCaseData( TreeNode.Create( [] ) )
                .Returns( 0 );
        }
    }
}
