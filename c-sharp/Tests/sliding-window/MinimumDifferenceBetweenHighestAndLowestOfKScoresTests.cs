using NUnit.Framework;

using Problems;

namespace SlidingWindow;

public class MinimumDifferenceBetweenHighestAndLowestOfKScoresTests
{
    [TestCase( new int[] { 90 }, 1, ExpectedResult = 0 )]
    [TestCase( new int[] { 9, 4, 1, 7 }, 2, ExpectedResult = 2 )]
    public int MinimumDifferenceTest( int[] nums, int k ) =>
        new MinimumDifferenceBetweenHighestAndLowestOfKScores().MinimumDifference( nums, k );
}
