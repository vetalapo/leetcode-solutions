using System.Collections;

using NUnit.Framework;

using Problems;

namespace Mathematics;

public class LargestTriangleAreaSolutionTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public double LargestTriangleAreaTest( int[][] points ) =>
        new LargestTriangleAreaSolution().LargestTriangleArea( points );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[][] { [0, 0], [0, 1], [1, 0], [0, 2], [2, 0] }] )
                .Returns( 2.0 );

            yield return new TestCaseData( [new int[][] { [1, 0], [0, 0], [0, 1] }] )
                .Returns( 0.5 );

            yield return new TestCaseData( [new int[][] { [4, 6], [6, 5], [3, 1] }] )
                .Returns( 5.5 );
        }
    }
}
