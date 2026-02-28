using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class FindTheDifferenceSolutionTests
{
    [TestCase( "abcd", "abcde", ExpectedResult = 'e' )]
    [TestCase( "", "y", ExpectedResult = 'y' )]
    public char FindTheDifferenceTest( string s, string t ) =>
        new FindTheDifferenceSolution().FindTheDifference( s, t );
}
