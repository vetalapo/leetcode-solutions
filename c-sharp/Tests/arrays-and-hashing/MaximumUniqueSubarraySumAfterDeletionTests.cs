using NUnit.Framework;

using Problems;

public class MaximumUniqueSubarraySumAfterDeletionTests
{
    [TestCase( new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 15 )]
    [TestCase( new int[] { 1, 1, 0, 1, 1 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 1, 2, -1, -2, 1, 0, -1 }, ExpectedResult = 3 )]
    public int MaxSumTest( int[] nums ) =>
        new MaximumUniqueSubarraySumAfterDeletion().MaxSum( nums );
}
