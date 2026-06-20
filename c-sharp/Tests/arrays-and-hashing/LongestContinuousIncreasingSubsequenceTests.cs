using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class LongestContinuousIncreasingSubsequenceTests
{
    [TestCase( new int[] { 1, 3, 5, 4, 7 }, ExpectedResult = 3 )]
    [TestCase( new int[] { 2, 2, 2, 2, 2 }, ExpectedResult = 1 )]
    public int FindLengthOfLCISTest( int[] nums ) =>
        new LongestContinuousIncreasingSubsequence().FindLengthOfLCIS( nums );
}