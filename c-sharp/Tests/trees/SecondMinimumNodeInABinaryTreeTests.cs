using System.Collections;

using NUnit.Framework;

using Problems;
using Problems.Common;

public class SecondMinimumNodeInABinaryTreeTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int FindSecondMinimumValueTest( TreeNode root ) =>
        new SecondMinimumNodeInABinaryTree().FindSecondMinimumValue( root );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( TreeNode.Create( [2, 2, 5, null, null, 5, 7] ) ).Returns( 5 );

            yield return new TestCaseData( TreeNode.Create( [2, 2, 2] ) ).Returns( -1 );

            yield return new TestCaseData( TreeNode.Create( [2, 2, 2147483647] ) ).Returns( 2147483647 );
        }
    }
}
