using NUnit.Framework;

using Problems;

public class PassThePillowSolutionTests
{
    [TestCase( 4, 5, ExpectedResult = 2 )]
    [TestCase( 3, 2, ExpectedResult = 3 )]
    [TestCase( 8, 9, ExpectedResult = 6 )]
    [TestCase( 9, 4, ExpectedResult = 5 )]
    [TestCase( 18, 38, ExpectedResult = 5 )]
    [TestCase( 6, 8, ExpectedResult = 3 )]
    [TestCase( 2, 341, ExpectedResult = 2 )]
    [TestCase( 33, 218, ExpectedResult = 27 )]
    public int PassThePillowTest( int n, int time ) =>
        new PassThePillowSolution().PassThePillow( n, time );
}
