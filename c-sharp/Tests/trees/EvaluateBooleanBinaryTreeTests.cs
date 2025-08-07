using System.Collections;

using NUnit.Framework;

using Problems;
using Problems.Common;

public class EvaluateBooleanBinaryTreeTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public bool EvaluateTreeTest( TreeNode root ) =>
        new EvaluateBooleanBinaryTree().EvaluateTree( root );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( TreeNode.Create( [2, 1, 3, null, null, 0, 1] ) ).Returns( true );

            yield return new TestCaseData( TreeNode.Create( [0] ) ).Returns( false );

            yield return new TestCaseData( TreeNode.Create( [3, 3, 2, 2, 3, 3, 3, 0, 1, 0, 0, 1, 0, 0, 0] ) ).Returns( false );

            yield return new TestCaseData( TreeNode.Create( [2, 3, 1, 1, 2, null, null, null, null, 0, 1] ) ).Returns( true );
        }
    }
}
