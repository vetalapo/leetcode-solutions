using NUnit.Framework;

using Problems;

public class SmallestDivisibleDigitProductITests
{
    [TestCase( 10, 2, ExpectedResult = 10 )]
    [TestCase( 15, 3, ExpectedResult = 16 )]
    [TestCase( 1, 1, ExpectedResult = 1 )]
    public int SmallestNumberTest( int n, int t ) =>
        new SmallestDivisibleDigitProductI().SmallestNumber( n, t );
}
