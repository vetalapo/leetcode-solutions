using NUnit.Framework;

using Problems;

namespace BitManipulation;

public class ReverseBitsSolutionTests
{
    [TestCase( 43261596, ExpectedResult = 964176192 )]
    [TestCase( 2147483644, ExpectedResult = 1073741822 )]
    public int ReverseBitsTest( int n ) =>
        new ReverseBitsSolution().ReverseBits( n );
}
