using System.Collections;

using NUnit.Framework;

using Problems;
using Problems.Common;

public class UnivaluedBinaryTreeTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public bool IsUnivalTreeTest( TreeNode root ) =>
        new UnivaluedBinaryTree().IsUnivalTree( root );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( TreeNode.Create( [1, 1, 1, 1, 1, null, 1] ) )
                .Returns( true );

            yield return new TestCaseData( TreeNode.Create( [2, 2, 2, 5, 2] ) )
                .Returns( false );
        }
    }
}
