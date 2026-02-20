using System.Collections;

using NUnit.Framework;

using Problems;
using Problems.Common;

namespace Tree;

public class RangeSumOfBSTTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int RangeSumBSTTest( TreeNode root, int low, int high ) =>
        new RangeSumOfBST().RangeSumBST( root, low, high );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( TreeNode.Create( [10, 5, 15, 3, 7, null, 18] ), 7, 15 )
                .Returns( 32 );

            yield return new TestCaseData( TreeNode.Create( [10, 5, 15, 3, 7, 13, 18, 1, null, 6] ), 6, 10 )
                .Returns( 23 );
        }
    }
}
