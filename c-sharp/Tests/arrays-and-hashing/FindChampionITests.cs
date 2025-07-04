using System.Collections;

using NUnit.Framework;

using Problems;

public class FindChampionITests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int FindChampionTest( int[][] grid ) =>
        new FindChampionI().FindChampion( grid );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[][] { [0, 1], [0, 0] }] )
                .Returns( 0 );

            yield return new TestCaseData( [new int[][] { [0, 0, 1], [1, 0, 1], [0, 0, 0] }] )
                .Returns( 1 );
        }
    }
}
