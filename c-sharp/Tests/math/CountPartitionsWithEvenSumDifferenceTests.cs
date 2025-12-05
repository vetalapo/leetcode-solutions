using NUnit.Framework;

using Problems;

namespace Mathematics;

public class CountPartitionsWithEvenSumDifferenceTests
{
    [TestCase( new int[] { 10, 10, 3, 7, 6 }, ExpectedResult = 4 )]
    [TestCase( new int[] { 1, 2, 2 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 2, 4, 6, 8 }, ExpectedResult = 3 )]
    public int CountPartitionsTest( int[] nums ) =>
        new CountPartitionsWithEvenSumDifference().CountPartitions( nums );
}
