using NUnit.Framework;

using Problems;

public class SumOfDigitsInBaseKTests
{
    [TestCase( 34, 6, ExpectedResult = 9 )]
    [TestCase( 10, 10, ExpectedResult = 1 )]
    public int SumBaseTest( int n, int k ) =>
        new SumOfDigitsInBaseK().SumBase( n, k );
}
