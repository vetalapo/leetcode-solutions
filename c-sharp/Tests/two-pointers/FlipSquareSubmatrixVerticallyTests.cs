using System.Collections;

using NUnit.Framework;

using Problems;

namespace TwoPointers;

public class FlipSquareSubmatrixVerticallyTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int[][] ReverseSubmatrixTest( int[][] grid, int x, int y, int k ) =>
        new FlipSquareSubmatrixVertically().ReverseSubmatrix( grid, x, y, k );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[][] { [1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16] }, 1, 0, 3 )
                .Returns( new int[][] { [1, 2, 3, 4], [13, 14, 15, 8], [9, 10, 11, 12], [5, 6, 7, 16] } );

            yield return new TestCaseData( new int[][] { [3, 4, 2, 3], [2, 3, 4, 2] }, 0, 2, 2 )
                .Returns( new int[][] { [3, 4, 4, 2], [2, 3, 2, 3] } );
        }
    }
}
