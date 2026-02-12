using System.Collections;

using NUnit.Framework;

using Problems;

namespace Mathematics;

public class ValidBoomerangTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public bool IsBoomerangTest( int[][] points ) =>
        new ValidBoomerang().IsBoomerang( points );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[][] { [1, 1], [2, 3], [3, 2] }] ).Returns( true );

            yield return new TestCaseData( [new int[][] { [1, 1], [2, 2], [3, 3] }] ).Returns( false );

            yield return new TestCaseData( [new int[][] { [0, 0], [0, 2], [2, 1] }] ).Returns( true );

            yield return new TestCaseData( [new int[][] { [0, 0], [1, 1], [1, 1] }] ).Returns( false );

            yield return new TestCaseData( [new int[][] { [73, 31], [73, 19], [73, 45] }] ).Returns( false );
        }
    }
}
