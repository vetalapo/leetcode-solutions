using NUnit.Framework;

using Problems;

namespace BitManipulation;

public class HammingDistanceSolutionTests
{
    [TestCase( 1, 4, ExpectedResult = 2 )]
    [TestCase( 3, 1, ExpectedResult = 1 )]
    public int HammingDistanceTest( int x, int y ) =>
        new HammingDistanceSolution().HammingDistance( x, y );
}
