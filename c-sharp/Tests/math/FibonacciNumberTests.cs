using NUnit.Framework;

using Problems;

public class FibonacciNumberTests
{
    [TestCase( 2, ExpectedResult = 1 )]
    [TestCase( 3, ExpectedResult = 2 )]
    [TestCase( 4, ExpectedResult = 3 )]
    [TestCase( 0, ExpectedResult = 0 )]
    public int FibTest( int n ) =>
        new FibonacciNumber().Fib( n );
}
