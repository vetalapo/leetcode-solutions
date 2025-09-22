using NUnit.Framework;

namespace Problems.ArraysAndHashing;

public class SmallestMissingIntegerGreaterThanSequentialPrefixSumTests
{
    [TestCase( new int[] { 1, 2, 3, 2, 5 }, ExpectedResult = 6 )]
    [TestCase( new int[] { 3, 4, 5, 1, 12, 14, 13 }, ExpectedResult = 15 )]
    [TestCase( new int[] { 29, 30, 31, 32, 33, 34, 35, 36, 37 }, ExpectedResult = 297 )]
    [TestCase( new int[] { 38 }, ExpectedResult = 39 )]
    public int MissingIntegerTest( int[] nums ) =>
        new SmallestMissingIntegerGreaterThanSequentialPrefixSum().MissingInteger( nums );
}
