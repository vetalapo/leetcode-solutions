using System.Collections;

using NUnit.Framework;

using Problems;

public class RowWithMaximumOnesTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int[] RowAndMaximumOnesTest( int[][] mat ) =>
        new RowWithMaximumOnes().RowAndMaximumOnes( mat );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[][] { [0, 1], [1, 0] }] ).Returns( new int[] { 0, 1 } );

            yield return new TestCaseData( [new int[][] { [0, 0, 0], [0, 1, 1] }] ).Returns( new int[] { 1, 2 } );

            yield return new TestCaseData( [new int[][] { [0, 0], [1, 1], [0, 0] }] ).Returns( new int[] { 1, 2 } );
        }
    }
}
