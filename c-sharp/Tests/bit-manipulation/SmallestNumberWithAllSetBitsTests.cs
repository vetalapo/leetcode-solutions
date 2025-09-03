using NUnit.Framework;

using Problems;

public class SmallestNumberWithAllSetBitsTests
{
    [TestCase( 5, ExpectedResult = 7 )]
    [TestCase( 10, ExpectedResult = 15 )]
    [TestCase( 3, ExpectedResult = 3 )]
    public int SmallestNumberTest( int n ) =>
        new SmallestNumberWithAllSetBits().SmallestNumber( n );
}
