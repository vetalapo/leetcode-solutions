using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class FindValidPairOfAdjacentDigitsInStringTests
{
    [TestCase( "2523533", ExpectedResult = "23" )]
    [TestCase( "221", ExpectedResult = "21" )]
    [TestCase( "22", ExpectedResult = "" )]
    public string FindValidPairTest( string s ) =>
        new FindValidPairOfAdjacentDigitsInString().FindValidPair( s );
}
