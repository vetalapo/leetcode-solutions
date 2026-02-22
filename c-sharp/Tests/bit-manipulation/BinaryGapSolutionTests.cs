using NUnit.Framework;

using Problems;

namespace BitManipulation;

public class BinaryGapSolutionTests
{
    [TestCase( 22, ExpectedResult = 2 )]
    [TestCase( 8, ExpectedResult = 0 )]
    [TestCase( 5, ExpectedResult = 2 )]
    [TestCase( 6, ExpectedResult = 1 )]
    public int BinaryGapTest( int n ) =>
        new BinaryGapSolution().BinaryGap( n );
}
