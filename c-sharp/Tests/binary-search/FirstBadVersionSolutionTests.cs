using NUnit.Framework;

using Problems;

public class FirstBadVersionSolutionTests
{
    [TestCase( 5, 4, ExpectedResult = 4 )]
    [TestCase( 1, 1, ExpectedResult = 1 )]
    [TestCase( 2147483647, 2147483644, ExpectedResult = 2147483644 )]
    public int FirstBadVersionTest( int n, int bad ) =>
        new FirstBadVersionSolution( bad ).FirstBadVersion( n );
}
