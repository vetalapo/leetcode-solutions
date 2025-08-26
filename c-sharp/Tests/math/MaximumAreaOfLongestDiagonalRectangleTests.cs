using System.Collections;

using NUnit.Framework;

using Problems;

public class MaximumAreaOfLongestDiagonalRectangleTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int AreaOfMaxDiagonalTest( int[][] dimensions ) =>
        new MaximumAreaOfLongestDiagonalRectangle().AreaOfMaxDiagonal( dimensions );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[][] { [9, 3], [8, 6] }] )
                .Returns( 48 );

            yield return new TestCaseData( [new int[][] { [3, 4], [4, 3] }] )
                .Returns( 12 );

            yield return new TestCaseData( [new int[][] { [2, 6], [5, 1], [3, 10], [8, 4] }] )
                .Returns( 30 );
        }
    }
}
