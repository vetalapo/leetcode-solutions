using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MinimumNumberOfFlipsToReverseBinaryStringTests
{
    [TestCase( 7, ExpectedResult = 0 )]
    [TestCase( 10, ExpectedResult = 4 )]
    public int MinimumFlipsTest( int n ) =>
        new MinimumNumberOfFlipsToReverseBinaryString().MinimumFlips( n );
}
