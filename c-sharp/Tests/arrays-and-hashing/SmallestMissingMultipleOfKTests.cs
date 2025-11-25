using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class SmallestMissingMultipleOfKTests
{
    [TestCase( new int[] { 8, 2, 3, 4, 6 }, 2, ExpectedResult = 10 )]
    [TestCase( new int[] { 1, 4, 7, 10, 15 }, 5, ExpectedResult = 5 )]
    public int MissingMultipleTest( int[] nums, int k ) =>
        new SmallestMissingMultipleOfK().MissingMultiple( nums, k );
}
