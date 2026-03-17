using NUnit.Framework;

using Problems;

namespace Mathematics;

public class ClimbingStairsTests
{
    [TestCase( 2, ExpectedResult = 2 )]
    [TestCase( 3, ExpectedResult = 3 )]
    [TestCase( 4, ExpectedResult = 5 )]
    [TestCase( 5, ExpectedResult = 8 )]
    public int ClimbStairsTest( int n ) =>
        new ClimbingStairs().ClimbStairs( n );
}
