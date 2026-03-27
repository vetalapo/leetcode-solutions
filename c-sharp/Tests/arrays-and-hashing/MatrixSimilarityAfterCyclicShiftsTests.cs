using System.Collections;

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MatrixSimilarityAfterCyclicShiftsTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public bool AreSimilarTest( int[][] mat, int k ) =>
        new MatrixSimilarityAfterCyclicShifts().AreSimilar( mat, k );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[][] { [1, 2, 3], [4, 5, 6], [7, 8, 9] }, 4 ).Returns( false );

            yield return new TestCaseData( new int[][] { [1, 2, 1, 2], [5, 5, 5, 5], [6, 3, 6, 3] }, 2 ).Returns( true );

            yield return new TestCaseData( new int[][] { [2, 2], [2, 2] }, 3 ).Returns( true );

            yield return new TestCaseData( new int[][] { [9, 5, 3, 10], [4, 7, 10, 7], [1, 7, 9, 4], [8, 8, 1, 6], [6, 7, 6, 1], [3, 1, 1, 8], [9, 2, 8, 3], [1, 9, 7, 6] }, 4 ).Returns( true );
        }
    }
}
