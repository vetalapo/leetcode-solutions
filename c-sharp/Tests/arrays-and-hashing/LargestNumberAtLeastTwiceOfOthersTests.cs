using NUnit.Framework;

using Problems;

public class LargestNumberAtLeastTwiceOfOthersTests
{
    [TestCase( new int[] { 3, 6, 1, 0 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 1, 2, 3, 4 }, ExpectedResult = -1 )]
    [TestCase( new int[] { 0, 0, 0, 1 }, ExpectedResult = 3 )]
    public int DominantIndexTest( int[] nums ) =>
        new LargestNumberAtLeastTwiceOfOthers().DominantIndex( nums );
}
