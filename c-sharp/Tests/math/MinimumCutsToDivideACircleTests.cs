using NUnit.Framework;

using Problems;

public class MinimumCutsToDivideACircleTests
{
    [TestCase( 4, ExpectedResult = 2 )]
    [TestCase( 3, ExpectedResult = 3 )]
    [TestCase( 1, ExpectedResult = 0 )]
    public int NumberOfCutsTest( int n ) =>
        new MinimumCutsToDivideACircle().NumberOfCuts( n );
}
