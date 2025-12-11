using System.Collections;

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class EarliestTimeToFinishOneTaskTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int EarliestTimeTest( int[][] tasks ) =>
        new EarliestTimeToFinishOneTask().EarliestTime( tasks );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[][] { [1, 6], [2, 3] }] ).Returns( 5 );

            yield return new TestCaseData( [new int[][] { [100, 100], [100, 100], [100, 100] }] ).Returns( 200 );
        }
    }
}
