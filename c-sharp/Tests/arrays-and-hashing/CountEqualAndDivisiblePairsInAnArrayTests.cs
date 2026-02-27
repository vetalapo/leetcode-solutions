using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CountEqualAndDivisiblePairsInAnArrayTests
{
    [TestCase( new int[] { 3, 1, 2, 2, 2, 1, 3 }, 2, ExpectedResult = 4 )]
    [TestCase( new int[] { 1, 2, 3, 4 }, 1, ExpectedResult = 0 )]
    public int CountPairsTest( int[] nums, int k ) =>
        new CountEqualAndDivisiblePairsInAnArray().CountPairs( nums, k );
}
