using NUnit.Framework;

using Problems;

namespace TwoPointers;

public class MinimumSwapsToMoveZerosToEndTests
{
    [TestCase( new int[] { 0, 1, 0, 3, 12 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 0, 1, 0, 2 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 1, 2, 0 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 0, 65, 0 }, ExpectedResult = 1 )]
    public int MinimumSwapsTest( int[] nums ) =>
        new MinimumSwapsToMoveZerosToEnd().MinimumSwaps( nums );
}