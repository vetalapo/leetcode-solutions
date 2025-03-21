using NUnit.Framework;

using Problems;

public class MaximumSumWithExactlyKElementsTests
{
    [TestCase( new int[] { 1, 2, 3, 4, 5 }, 3, ExpectedResult = 18 )]
    [TestCase( new int[] { 5, 5, 5 }, 2, ExpectedResult = 11 )]
    [TestCase( new int[] { 4, 4, 9, 10, 10, 9, 3, 8, 4 }, 6, ExpectedResult = 75 )]
    public int MaximizeSumTest( int[] nums, int k ) =>
        new MaximumSumWithExactlyKElements().MaximizeSum( nums, k );
}
