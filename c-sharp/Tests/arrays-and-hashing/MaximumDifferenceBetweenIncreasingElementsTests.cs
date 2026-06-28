using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MaximumDifferenceBetweenIncreasingElementsTests
{
    [TestCase( new int[] { 7, 1, 5, 4 }, ExpectedResult = 4 )]
    [TestCase( new int[] { 9, 4, 3, 2 }, ExpectedResult = -1 )]
    [TestCase( new int[] { 1, 5, 2, 10 }, ExpectedResult = 9 )]
    [TestCase( new int[] { 999, 997, 980, 976, 735, 45, 26, 26, 23, 15 }, ExpectedResult = -1 )]
    public int MaximumDifferenceTest( int[] nums ) =>
        new MaximumDifferenceBetweenIncreasingElements().MaximumDifference( nums );
}