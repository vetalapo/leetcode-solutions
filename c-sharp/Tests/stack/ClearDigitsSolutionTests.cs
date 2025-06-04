using System.Collections;

using NUnit.Framework;

using Problems;

public class ClearDigitsSolutionTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public string ClearDigitsTest( string s ) =>
        new ClearDigitsSolution().ClearDigits( s );

    [TestCaseSource( nameof( TestCases ) )]
    public string ClearDigitsStackTest( string s ) =>
        new ClearDigitsSolution().ClearDigitsStack( s );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( "abc" ).Returns( "abc" );

            yield return new TestCaseData( "cb34" ).Returns( string.Empty );

            yield return new TestCaseData( "a0id5" ).Returns( "i" );
        }
    }
}
