using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MaximumNumberOfPairsInArrayTests
{
    [TestCase( new int[] { 1, 3, 2, 1, 3, 2, 2 }, ExpectedResult = new int[] { 3, 1 } )]
    [TestCase( new int[] { 1, 1 }, ExpectedResult = new int[] { 1, 0 } )]
    [TestCase( new int[] { 0 }, ExpectedResult = new int[] { 0, 1 } )]
    public int[] NumberOfPairsTest( int[] nums ) =>
        new MaximumNumberOfPairsInArray().NumberOfPairs( nums );
}