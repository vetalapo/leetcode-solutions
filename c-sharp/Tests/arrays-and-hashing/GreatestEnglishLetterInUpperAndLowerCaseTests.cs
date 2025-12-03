using System.Collections;

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class GreatestEnglishLetterInUpperAndLowerCaseTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public string GreatestLetterTest( string s ) =>
        new GreatestEnglishLetterInUpperAndLowerCase().GreatestLetter( s );

    [TestCaseSource( nameof( TestCases ) )]
    public string GreatestLetterMapTest( string s ) =>
        new GreatestEnglishLetterInUpperAndLowerCase().GreatestLetterMap( s );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( "lEeTcOdE" ).Returns( "E" );

            yield return new TestCaseData( "arRAzFif" ).Returns( "R" );

            yield return new TestCaseData( "AbCdEfGhIjK" ).Returns( string.Empty );

            yield return new TestCaseData( "nzmguNAEtJHkQaWDVSKxRCUivXpGLBcsjeobYPFwTZqrhlyOIfdM" ).Returns( "Z" );
        }
    }
}
