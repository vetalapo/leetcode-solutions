using NUnit.Framework;

using Problems;

public class SignOfTheProductOfAnArrayTests
{
    [TestCase( new int[] { -1, -2, -3, -4, 3, 2, 1 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 1, 5, 0, 2, -3 }, ExpectedResult = 0 )]
    [TestCase( new int[] { -1, 1, -1, 1, -1 }, ExpectedResult = -1 )]
    [TestCase( new int[] { 7, 36, 96, 70, 85, 23, 5, 18, 4, 12, 89, 92, 9, 30, 53, 14, 96, 32, 13, 43, 37, 60, 75, 7, 83, 68, 20, 8, -24, -80, -27, -92, -96, -20, -16, -52, -49, -38 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 9, 72, 34, 29, -49, -22, -77, -17, -66, -75, -44, -30, -24 }, ExpectedResult = -1 )]
    public int ArraySignTest( int[] nums ) =>
        new SignOfTheProductOfAnArray().ArraySign( nums );
}
