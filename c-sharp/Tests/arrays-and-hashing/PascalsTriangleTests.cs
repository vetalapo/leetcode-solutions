using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;

using Problems;

public class PascalsTriangleTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public IList<IList<int>> GenerateTest( int numRows ) =>
        new PascalsTriangle().Generate( numRows );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( 5 ).Returns( new int[][] { [1], [1, 1], [1, 2, 1], [1, 3, 3, 1], [1, 4, 6, 4, 1] } );

            yield return new TestCaseData( 1 ).Returns( new int[][] { [1] } );
        }
    }
}
