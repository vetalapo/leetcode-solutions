using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CountNumberOfPairsWithAbsoluteDifferenceKTests
{
    [TestCase( new int[] { 1, 2, 2, 1 }, 1, ExpectedResult = 4 )]
    [TestCase( new int[] { 1, 3 }, 3, ExpectedResult = 0 )]
    [TestCase( new int[] { 3, 2, 1, 5, 4 }, 2, ExpectedResult = 3 )]
    public int CountKDifferenceTest( int[] nums, int k ) =>
        new CountNumberOfPairsWithAbsoluteDifferenceK().CountKDifference( nums, k );
}
