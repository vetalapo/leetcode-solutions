using System.Collections;

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class FlippingAnImageTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int[][] FlipAndInvertImageTest( int[][] image ) =>
        new FlippingAnImage().FlipAndInvertImage( image );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[][] { [1, 1, 0], [1, 0, 1], [0, 0, 0] }] )
                .Returns( new int[][] { [1, 0, 0], [0, 1, 0], [1, 1, 1] } );

            yield return new TestCaseData( [new int[][] { [1, 1, 0, 0], [1, 0, 0, 1], [0, 1, 1, 1], [1, 0, 1, 0] }] )
                .Returns( new int[][] { [1, 1, 0, 0], [0, 1, 1, 0], [0, 0, 0, 1], [1, 0, 1, 0] } );
        }
    }
}
