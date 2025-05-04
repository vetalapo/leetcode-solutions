using System.Collections;

using NUnit.Framework;

using Problems;

public class NumberOfEquivalentDominoPairsTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int NumEquivDominoPairsTest( int[][] dominoes ) =>
        new NumberOfEquivalentDominoPairs().NumEquivDominoPairs( dominoes );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[][] { [1, 2], [2, 1], [3, 4], [5, 6] }] ).Returns( 1 );

            yield return new TestCaseData( [new int[][] { [1, 2], [1, 2], [1, 1], [1, 2], [2, 2] }] ).Returns( 3 );

            yield return new TestCaseData( [new int[][] { [1, 1], [2, 2], [1, 1], [1, 2], [1, 2], [1, 1] }] ).Returns( 4 );
        }
    }
}
