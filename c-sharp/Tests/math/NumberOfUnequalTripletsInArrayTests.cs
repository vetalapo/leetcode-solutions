using NUnit.Framework;

using Problems;

public class NumberOfUnequalTripletsInArrayTests
{
    [TestCase( new int[] { 4, 4, 2, 4, 3 }, ExpectedResult = 3 )]
    [TestCase( new int[] { 1, 1, 1, 1, 1 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 1, 2, 3 }, ExpectedResult = 1 )]
    public int UnequalTripletsTest( int[] nums ) =>
        new NumberOfUnequalTripletsInArray().UnequalTriplets( nums );
}
