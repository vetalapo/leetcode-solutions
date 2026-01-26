using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MinimumAbsoluteDifferenceTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public IList<IList<int>> MinimumAbsDifferenceTest( int[] arr ) =>
        new MinimumAbsoluteDifference().MinimumAbsDifference( arr );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[] { 4, 2, 1, 3 } )
                .Returns( new int[][] { [1, 2], [2, 3], [3, 4] } );

            yield return new TestCaseData( new int[] { 1, 3, 6, 10, 15 } )
                .Returns( new int[][] { [1, 3] } );

            yield return new TestCaseData( new int[] { 3, 8, -10, 23, 19, -4, -14, 27 } )
                .Returns( new int[][] { [-14, -10], [19, 23], [23, 27] } );
        }
    }
}
