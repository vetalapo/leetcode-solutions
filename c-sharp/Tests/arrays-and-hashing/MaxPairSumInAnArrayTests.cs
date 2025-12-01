using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MaxPairSumInAnArrayTests
{
    [TestCase( new int[] { 112, 131, 411 }, ExpectedResult = -1 )]
    [TestCase( new int[] { 2536, 1613, 3366, 162 }, ExpectedResult = 5902 )]
    [TestCase( new int[] { 51, 71, 17, 24, 42 }, ExpectedResult = 88 )]
    public int MaxSumTest( int[] nums ) =>
        new MaxPairSumInAnArray().MaxSum( nums );
}
