using NUnit.Framework;

using Problems;

public class LargestPositiveIntegerThatExistsWithItsNegativeTests
{
    [TestCase( new int[] { -1, 2, -3, 3 }, ExpectedResult = 3 )]
    [TestCase( new int[] { -1, 10, 6, 7, -7, 1 }, ExpectedResult = 7 )]
    [TestCase( new int[] { -10, 8, 6, 7, -2, -3 }, ExpectedResult = -1 )]
    public int FindMaxKTest( int[] nums ) =>
        new LargestPositiveIntegerThatExistsWithItsNegative().FindMaxK( nums );
}
