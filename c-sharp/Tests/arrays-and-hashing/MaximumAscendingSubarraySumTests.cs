using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MaximumAscendingSubarraySumTests
{
    [TestCase( new int[] { 10, 20, 30, 5, 10, 50 }, ExpectedResult = 65 )]
    [TestCase( new int[] { 10, 20, 30, 40, 50 }, ExpectedResult = 150 )]
    [TestCase( new int[] { 12, 17, 15, 13, 10, 11, 12 }, ExpectedResult = 33 )]
    [TestCase( new int[] { 3, 6, 10, 1, 8, 9, 9, 8, 9 }, ExpectedResult = 19 )]
    public int MaxAscendingSumTest( int[] nums ) =>
        new MaximumAscendingSubarraySum().MaxAscendingSum( nums );
}