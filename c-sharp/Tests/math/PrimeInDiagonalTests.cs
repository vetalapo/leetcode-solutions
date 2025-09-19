using System.Collections;

using NUnit.Framework;

using Problems;

public class PrimeInDiagonalTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int DiagonalPrimeTest( int[][] nums ) =>
        new PrimeInDiagonal().DiagonalPrime( nums );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new int[][] { [1, 2, 3], [5, 6, 7], [9, 10, 11] }] )
                .Returns( 11 );

            yield return new TestCaseData( [new int[][] { [1, 2, 3], [5, 17, 7], [9, 11, 10] }] )
                .Returns( 17 );
        }
    }
}
