using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class PrimeNumberOfSetBitsInBinaryRepresentationTests
{
    [TestCase( 6, 10, ExpectedResult = 4 )]
    [TestCase( 10, 15, ExpectedResult = 5 )]
    public int CountPrimeSetBitsTest( int left, int right ) =>
        new PrimeNumberOfSetBitsInBinaryRepresentation().CountPrimeSetBits( left, right );
}
