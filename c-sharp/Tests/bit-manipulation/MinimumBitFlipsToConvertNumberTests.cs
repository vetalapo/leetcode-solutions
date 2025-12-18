using NUnit.Framework;

using Problems;

namespace BitManipulation;

public class MinimumBitFlipsToConvertNumberTests
{
    [TestCase( 10, 7, ExpectedResult = 3 )]
    [TestCase( 3, 4, ExpectedResult = 3 )]
    public int MinBitFlipsTest( int start, int goal ) =>
        new MinimumBitFlipsToConvertNumber().MinBitFlips( start, goal );
}
