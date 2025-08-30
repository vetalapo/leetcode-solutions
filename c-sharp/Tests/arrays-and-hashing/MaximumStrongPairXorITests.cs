using NUnit.Framework;

using Problems;

public class MaximumStrongPairXorITests
{
    [TestCase( new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 7 )]
    [TestCase( new int[] { 10, 100 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 5, 6, 25, 30 }, ExpectedResult = 7 )]
    public int MaximumStrongPairXorTest( int[] nums ) =>
        new MaximumStrongPairXorI().MaximumStrongPairXor( nums );
}
