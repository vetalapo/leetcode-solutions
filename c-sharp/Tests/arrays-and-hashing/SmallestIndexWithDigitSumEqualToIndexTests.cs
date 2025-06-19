using NUnit.Framework;

using Problems;

public class SmallestIndexWithDigitSumEqualToIndexTests
{
    [TestCase( new int[] { 1, 3, 2 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 1, 10, 11 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 1, 2, 3 }, ExpectedResult = -1 )]
    public int SmallestIndexTest( int[] nums ) =>
        new SmallestIndexWithDigitSumEqualToIndex().SmallestIndex( nums );
}
