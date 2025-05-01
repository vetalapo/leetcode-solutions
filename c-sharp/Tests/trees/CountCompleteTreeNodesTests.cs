using System.Collections;

using NUnit.Framework;

using Problems;
using Problems.Common;

public class CountCompleteTreeNodesTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int CountNodesTest( TreeNode root ) =>
        new CountCompleteTreeNodes().CountNodes( root );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( TreeNode.CreateBST( [1, 2, 3, 4, 5, 6] ) ).Returns( 6 );

            yield return new TestCaseData( TreeNode.CreateBST( [] ) ).Returns( 0 );

            yield return new TestCaseData( TreeNode.CreateBST( [1] ) ).Returns( 1 );

            yield return new TestCaseData( TreeNode.CreateBST( [1, 2, 3, 4] ) ).Returns( 4 );
        }
    }
}
