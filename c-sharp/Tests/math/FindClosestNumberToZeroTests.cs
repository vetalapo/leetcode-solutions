using NUnit.Framework;

using Problems;

public class FindClosestNumberToZeroTests
{
    [TestCase( new int[] { -4, -2, 1, 4, 8 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 2, -1, 1 }, ExpectedResult = 1 )]
    public int FindClosestNumberTest( int[] nums ) =>
        new FindClosestNumberToZero().FindClosestNumber( nums );
}
