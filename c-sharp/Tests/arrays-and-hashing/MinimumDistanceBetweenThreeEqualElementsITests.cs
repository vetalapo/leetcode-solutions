using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MinimumDistanceBetweenThreeEqualElementsITests
{
    [TestCase( new int[] { 1, 2, 1, 1, 3 }, ExpectedResult = 6 )]
    [TestCase( new int[] { 1, 1, 2, 3, 2, 1, 2 }, ExpectedResult = 8 )]
    [TestCase( new int[] { 1 }, ExpectedResult = -1 )]
    [TestCase( new int[] { 5, 3, 5, 5, 5 }, ExpectedResult = 4 )]
    public int MinimumDistanceTest( int[] nums ) =>
        new MinimumDistanceBetweenThreeEqualElementsI().MinimumDistance( nums );
}
