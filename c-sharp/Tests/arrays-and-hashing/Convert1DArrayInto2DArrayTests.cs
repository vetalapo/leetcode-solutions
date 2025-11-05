using System;
using System.Collections;

using NUnit.Framework;

using Problems;

namespace  ArraysAndHashing;

public class Convert1DArrayInto2DArrayTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int[][] Construct2DArrayTest( int[] original, int m, int n ) =>
        new Convert1DArrayInto2DArray().Construct2DArray( original, m, n );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[] { 1, 2, 3, 4 }, 2, 2 )
                .Returns( new int[][] { [1, 2], [3, 4] } );

            yield return new TestCaseData( new int[] { 1, 2, 3 }, 1, 3 )
                .Returns( new int[][] { [1, 2, 3] } );

            yield return new TestCaseData( new int[] { 1, 2 }, 1, 1 )
                .Returns( Array.Empty<int[]>() );
        }
    }
}
