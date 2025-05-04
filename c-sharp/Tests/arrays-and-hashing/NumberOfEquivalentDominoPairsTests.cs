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
            yield return TestCaseData( new int[][] { [] } ).Returns( 0 );
        }
    }
}
