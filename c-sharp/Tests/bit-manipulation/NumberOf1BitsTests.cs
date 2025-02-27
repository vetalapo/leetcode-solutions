using System.Collections;

using NUnit.Framework;

using Problems;

public class NumberOf1BitsTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int HammingWeightTest( int n ) =>
        new NumberOf1Bits().HammingWeight( n );

    [TestCaseSource( nameof( TestCases ) )]
    public int HammingWeightOptimizedTest( int n ) =>
        new NumberOf1Bits().HammingWeightOptimized( n );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( 11 ).Returns( 3 );

            yield return new TestCaseData( 128 ).Returns( 1 );

            yield return new TestCaseData( 2147483645 ).Returns( 30 );
        }
    }
}
