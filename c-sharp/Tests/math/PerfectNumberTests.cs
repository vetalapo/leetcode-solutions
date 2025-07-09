using System.Collections;

using NUnit.Framework;

using Problems;

public class PerfectNumberTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public bool CheckPerfectNumberTest( int num ) =>
        new PerfectNumber().CheckPerfectNumber( num );

    [TestCaseSource( nameof( TestCases ) )]
    public bool CheckPerfectNumberBFTest( int num ) =>
        new PerfectNumber().CheckPerfectNumberBF( num );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( 28 ).Returns( true );

            yield return new TestCaseData( 6 ).Returns( true );

            yield return new TestCaseData( 7 ).Returns( false );

            yield return new TestCaseData( 9 ).Returns( false );
        }
    }
}
