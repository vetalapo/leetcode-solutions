using NUnit.Framework;

using Problems;

public class FindGreatestCommonDivisorOfArrayTests
{
    [TestCase( new int[] { 2, 5, 6, 9, 10 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 7, 5, 6, 8, 3 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 3, 3 }, ExpectedResult = 3 )]
    public int FindGCDTest( int[] nums ) =>
        new FindGreatestCommonDivisorOfArray().FindGCD( nums );
}
