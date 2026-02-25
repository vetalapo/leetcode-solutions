using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class FindTheNumberOfGoodPairsITests
{
    [TestCase( new int[] { 1, 3, 4 }, new int[] { 1, 3, 4 }, 1, ExpectedResult = 5 )]
    [TestCase( new int[] { 1, 2, 4, 12 }, new int[] { 2, 4 }, 3, ExpectedResult = 2 )]
    public int NumberOfPairsTest( int[] nums1, int[] nums2, int k ) =>
        new FindTheNumberOfGoodPairsI().NumberOfPairs( nums1, nums2, k );
}
