using NUnit.Framework;

using Problems;

public class SmallestIndexWithEqualValueTests
{
    [TestCase( new int[] { 0, 1, 2 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 4, 3, 2, 1 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, ExpectedResult = -1 )]
    public int SmallestEqualTest( int[] nums ) =>
        new SmallestIndexWithEqualValue().SmallestEqual( nums );
}
