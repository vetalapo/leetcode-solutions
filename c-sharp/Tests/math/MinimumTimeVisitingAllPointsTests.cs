using System.Collections;

using NUnit.Framework;

using Problems;

namespace Mathematics;

public class MinimumTimeVisitingAllPointsTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int MinTimeToVisitAllPointsTest( int[][] points ) =>
        new MinimumTimeVisitingAllPoints().MinTimeToVisitAllPoints( points );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[][] { [1, 1], [3, 4], [-1, 0] }] ).Returns( 7 );
            yield return new TestCaseData( [new int[][] { [3, 2], [-2, 2] }] ).Returns( 5 );
        }
    }
}
