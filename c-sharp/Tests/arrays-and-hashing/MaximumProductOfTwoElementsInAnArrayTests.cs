using NUnit.Framework;

using Problems;

public class MaximumProductOfTwoElementsInAnArrayTests
{
    [TestCase( new int[] { 3, 4, 5, 2 }, ExpectedResult = 12 )]
    [TestCase( new int[] { 1, 5, 4, 5 }, ExpectedResult = 16 )]
    [TestCase( new int[] { 3, 7 }, ExpectedResult = 12 )]
    public int MaxProductTest( int[] nums ) =>
        new MaximumProductOfTwoElementsInAnArray().MaxProduct( nums );
}
