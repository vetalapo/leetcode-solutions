using System.Collections;

using NUnit.Framework;

using Problems;
using Problems.Common;

public class DiameterOfBinaryTreeSolutionTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int DiameterOfBinaryTreeTest( TreeNode root ) =>
        new DiameterOfBinaryTreeSolution().DiameterOfBinaryTree( root );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( TreeNode.Create( [1, 2, 3, 4, 5] ) ).Returns( 3 );

            yield return new TestCaseData( TreeNode.Create( [1, 2] ) ).Returns( 1 );

            yield return new TestCaseData( TreeNode.Create( [4, -7, -3, null, null, -9, -3, 9, -7, -4, null, 6, null, -6, -6, null, null, 0, 6, 5, null, 9, null, null, -1, -4, null, null, null, -2] ) ).Returns( 8 );
        }
    }
}
