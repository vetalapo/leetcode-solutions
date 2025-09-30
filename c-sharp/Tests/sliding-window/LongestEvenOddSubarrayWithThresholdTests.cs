using NUnit.Framework;

using Problems;

namespace SlidingWindow;

public class LongestEvenOddSubarrayWithThresholdTests
{
    [TestCase( new int[] { 3, 2, 5, 4 }, 5, ExpectedResult = 3 )]
    [TestCase( new int[] { 1, 2 }, 2, ExpectedResult = 1 )]
    [TestCase( new int[] { 2, 3, 4, 5 }, 4, ExpectedResult = 3 )]
    public int LongestAlternatingSubarrayTest( int[] nums, int threshold ) =>
        new LongestEvenOddSubarrayWithThreshold().LongestAlternatingSubarray( nums, threshold );
}
