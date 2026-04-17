using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MergeSortedArrayTests
{
    [TestCase( new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 } )]
    [TestCase( new int[] { 1 }, 1, new int[0], 0, new int[] { 1 } )]
    [TestCase( new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 } )]
    public void MergeTest( int[] nums1, int m, int[] nums2, int n, int[] expectedResult )
    {
        new MergeSortedArray().Merge( nums1, m, nums2, n );

	Assert.AreEqual( nums1, expectedResult );
    }
}
