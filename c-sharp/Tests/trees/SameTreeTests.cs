using System.Collections;

using NUnit.Framework;

using Problems;
using Problems.Common;

public class SameTreeTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public bool IsSameTreeTest( TreeNode p, TreeNode q ) =>
        new SameTree().IsSameTree( p, q );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( TreeNode.Create( [1, 2, 3] ), TreeNode.Create( [1, 2, 3] ) )
                .Returns( true );

            yield return new TestCaseData( TreeNode.Create( [1, 2] ), TreeNode.Create( [1, null, 2] ) )
                .Returns( false );

            yield return new TestCaseData( TreeNode.Create( [1, 2, 1] ), TreeNode.Create( [1, 1, 2] ) )
                .Returns( false );

            yield return new TestCaseData( TreeNode.Create( [10, 5, 15] ), TreeNode.Create( [10, 5, null, null, 15] ) )
                .Returns( false );
        }
    }
}
