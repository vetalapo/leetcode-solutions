using NUnit.Framework;

using Problems;

public class MinimumOperationsToMakeArraySumDivisibleByKTests
{
    [TestCase( new int[] { 3, 9, 7 }, 5, ExpectedResult = 4 )]
    [TestCase( new int[] { 4, 1, 3 }, 4, ExpectedResult = 0 )]
    [TestCase( new int[] { 3, 2 }, 6, ExpectedResult = 5 )]
    public int MinOperationsTest( int[] nums, int k ) =>
        new MinimumOperationsToMakeArraySumDivisibleByK().MinOperations( nums, k );
}
