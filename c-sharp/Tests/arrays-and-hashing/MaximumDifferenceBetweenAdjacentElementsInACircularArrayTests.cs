using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MaximumDifferenceBetweenAdjacentElementsInACircularArrayTests
{
    [TestCase( new int[] { 1, 2, 4 }, ExpectedResult = 3 )]
    [TestCase( new int[] { -5, -10, -5 }, ExpectedResult = 5 )]
    public int MaxAdjacentDistanceTest( int[] nums ) =>
        new MaximumDifferenceBetweenAdjacentElementsInACircularArray().MaxAdjacentDistance( nums );
}