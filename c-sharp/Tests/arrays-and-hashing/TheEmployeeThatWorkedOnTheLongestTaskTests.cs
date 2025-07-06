using System.Collections;

using NUnit.Framework;

using Problems;

public class TheEmployeeThatWorkedOnTheLongestTaskTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int HardestWorkerTest( int n, int[][] logs ) =>
        new TheEmployeeThatWorkedOnTheLongestTask().HardestWorker( n, logs );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( 10, new int[][] { [0, 3], [2, 5], [0, 9], [1, 15] } )
                .Returns( 1 );

            yield return new TestCaseData( 26, new int[][] { [1, 1], [3, 7], [2, 12], [7, 17] } )
                .Returns( 3 );

            yield return new TestCaseData( 2, new int[][] { [0, 10], [1, 20] } )
                .Returns( 0 );

            yield return new TestCaseData( 70, new int[][] { [36, 3], [1, 5], [12, 8], [25, 9], [53, 11], [29, 12], [52, 14] } )
                .Returns( 12 );
        }
    }
}
