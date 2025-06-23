using NUnit.Framework;

using Problems;

public class MinimumOperationsToExceedThresholdValueITests
{
    [TestCase( new int[] { 2, 11, 10, 1, 3 }, 10, ExpectedResult = 3 )]
    [TestCase( new int[] { 1, 1, 2, 4, 9 }, 1, ExpectedResult = 0 )]
    [TestCase( new int[] { 1, 1, 2, 4, 9 }, 9, ExpectedResult = 4 )]
    public int MinOperationsTest( int[] nums, int k ) =>
        new MinimumOperationsToExceedThresholdValueI().MinOperations( nums, k );
}
