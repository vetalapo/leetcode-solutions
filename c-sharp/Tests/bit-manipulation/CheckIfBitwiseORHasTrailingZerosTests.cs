using NUnit.Framework;

using Problems;

public class CheckIfBitwiseORHasTrailingZerosTests
{
    [TestCase( new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = true )]
    [TestCase( new int[] { 2, 4, 8, 16 }, ExpectedResult = true )]
    [TestCase( new int[] { 1, 3, 5, 7, 9 }, ExpectedResult = false )]
    [TestCase( new int[] { 1, 2, 3, 5, 7, 9 }, ExpectedResult = false )]
    public bool HasTrailingZerosTest( int[] nums ) =>
        new CheckIfBitwiseORHasTrailingZeros().HasTrailingZeros( nums );
}
