using System.Collections;

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MatrixDiagonalSumTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int DiagonalSumTest( int[][] mat ) =>
        new MatrixDiagonalSum().DiagonalSum( mat );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[][] { [1, 2, 3], [4, 5, 6], [7, 8, 9] }] ).Returns( 25 );

            yield return new TestCaseData( [new int[][] { [1, 1, 1, 1], [1, 1, 1, 1], [1, 1, 1, 1], [1, 1, 1, 1] }] ).Returns( 8 );

            yield return new TestCaseData( [new int[][] { [5] }] ).Returns( 5 );
        }
    }
}