using NUnit.Framework;

using Problems;

public class GuessNumberHigherOrLowerTests
{
    [TestCase( 10, 6, ExpectedResult = 6 )]
    [TestCase( 1, 1, ExpectedResult = 1 )]
    [TestCase( 2, 1, ExpectedResult = 1 )]
    public int GuessNumberTest( int n, int pick ) =>
        new GuessNumberHigherOrLower( pick ).GuessNumber( n );
}
