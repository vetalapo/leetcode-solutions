using System.Collections;

using NUnit.Framework;

using Problems;

public class FindSmallestLetterGreaterThanTargetTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public char NextGreatestLetterTest( char[] letters, char target ) =>
        new FindSmallestLetterGreaterThanTarget().NextGreatestLetter( letters, target );

    [TestCaseSource( nameof( TestCases ) )]
    public char NextGreatestLetterBFTest( char[] letters, char target ) =>
        new FindSmallestLetterGreaterThanTarget().NextGreatestLetterBF( letters, target );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new char[] { 'c', 'f', 'j' }, 'a' ).Returns( 'c' );

            yield return new TestCaseData( new char[] { 'c', 'f', 'j' }, 'j' ).Returns( 'c' );

            yield return new TestCaseData( new char[] { 'c', 'f', 'j' }, 'c' ).Returns( 'f' );

            yield return new TestCaseData( new char[] { 'x', 'x', 'y', 'y' }, 'z' ).Returns( 'x' );
        }
    }
}
