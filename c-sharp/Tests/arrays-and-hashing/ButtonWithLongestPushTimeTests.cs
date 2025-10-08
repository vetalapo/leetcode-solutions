using System.Collections;

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class ButtonWithLongestPushTimeTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int ButtonWithLongestTimeTest( int[][] events ) =>
        new ButtonWithLongestPushTime().ButtonWithLongestTime( events );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[][] { [1, 2], [2, 5], [3, 9], [1, 15] }] )
                .Returns( 1 );

            yield return new TestCaseData( [new int[][] { [10, 5], [1, 7] }] )
                .Returns( 10 );

            yield return new TestCaseData( [new int[][] { [9, 4], [19, 5], [2, 8], [3, 11], [2, 15] }] )
                .Returns( 2 );

            yield return new TestCaseData( [new int[][] { [1, 4], [18, 5], [15, 7], [12, 9], [1, 11], [18, 13], [16, 17] }] )
                .Returns( 1 );
        }
    }
}
