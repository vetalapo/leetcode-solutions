using NUnit.Framework;

using Problems;

public class NeitherMinimumNorMaximumTests
{
    [TestCase( new int[] { 3, 2, 1, 4 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 1, 2 }, ExpectedResult = -1 )]
    [TestCase( new int[] { 2, 1, 3 }, ExpectedResult = 2 )]
    public int FindNonMinOrMaxTest( int[] nums ) =>
        new NeitherMinimumNorMaximum().FindNonMinOrMax( nums );
}
