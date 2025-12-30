using System.Collections;

using NUnit.Framework;

using Problems;

namespace BinarySearch;

[TestFixture()]
public class KthMissingPositiveNumberTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int FindKthPositiveTest( int[] arr, int k )
        => new KthMissingPositiveNumber().FindKthPositive( arr, k );

    [TestCaseSource( nameof( TestCases ) )]
    public int FindKthPositiveOnTest( int[] arr, int k )
        => new KthMissingPositiveNumber().FindKthPositiveOn( arr, k );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[] { 2, 3, 4, 7, 11 }, 5 ).Returns( 9 );

            yield return new TestCaseData( new int[] { 1, 2, 3, 4 }, 2 ).Returns( 6 );

            yield return new TestCaseData( new int[] { 1, 2 }, 1 ).Returns( 3 );
        }
    }
}
