using System.Collections;

using NUnit.Framework;

using Problems;

namespace Graph;

public class FindTheDegreeOfEachVertexTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int[] FindDegrees( int[][] matrix ) =>
        new FindTheDegreeOfEachVertex().FindDegrees( matrix );
    
    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[][] { [0, 1, 1], [1, 0, 1], [1, 1, 0] }] )
                .Returns( new int[] { 2, 2, 2 } );

            yield return new TestCaseData( [new int[][] { [0, 1, 0], [1, 0, 0], [0, 0, 0] }] )
                .Returns( new int[] { 1, 1, 0 } );

            yield return new TestCaseData( [new int[][] { [0] }] )
                .Returns( new int[] { 0 } );
        }
    }
}