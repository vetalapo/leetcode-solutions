using NUnit.Framework;

using Problems;

public class FindTheXorOfNumbersWhichAppearTwiceTests
{
    [TestCase( new int[] { 1, 2, 1, 3 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 1, 2, 3 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 1, 2, 2, 1 }, ExpectedResult = 3 )]
    public int DuplicateNumbersXORTest( int[] nums ) =>
        new FindTheXorOfNumbersWhichAppearTwice().DuplicateNumbersXOR( nums );
}
