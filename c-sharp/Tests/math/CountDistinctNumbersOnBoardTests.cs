using NUnit.Framework;

using Problems;

public class CountDistinctNumbersOnBoardTests
{
    [TestCase( 5, ExpectedResult = 4 )]
    [TestCase( 3, ExpectedResult = 2 )]
    [TestCase( 1, ExpectedResult = 1 )]
    public int DistinctIntegersTest( int n ) =>
        new CountDistinctNumbersOnBoard().DistinctIntegers( n );
}
