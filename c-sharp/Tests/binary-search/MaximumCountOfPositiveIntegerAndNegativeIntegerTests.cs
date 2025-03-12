using NUnit.Framework;

using Problems;

public class MaximumCountOfPositiveIntegerAndNegativeIntegerTests
{
    [TestCase( new int[] { -2, -1, -1, 1, 2, 3 }, ExpectedResult = 3 )]
    [TestCase( new int[] { -3, -2, -1, 0, 0, 1, 2 }, ExpectedResult = 3 )]
    [TestCase( new int[] { 5, 20, 66, 1314 }, ExpectedResult = 4 )]
    [TestCase( new int[] { -1563, -236, -114, -55, 427, 447, 687, 752, 1021, 1636 }, ExpectedResult = 6 )]
    [TestCase( new int[] { -1 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 0 }, ExpectedResult = 0 )]
    public int MaximumCountTest( int[] nums ) =>
        new MaximumCountOfPositiveIntegerAndNegativeInteger().MaximumCount( nums );
}
