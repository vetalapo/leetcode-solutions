using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class FindTheIntegerAddedToArrayITests
{
    [TestCase( new int[] { 2, 6, 4 }, new int[] { 9, 7, 5 }, ExpectedResult = 3 )]
    [TestCase( new int[] { 10 }, new int[] { 5 }, ExpectedResult = -5 )]
    [TestCase( new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, ExpectedResult = 0 )]
    public int AddedIntegerTest( int[] nums1, int[] nums2 ) =>
        new FindTheIntegerAddedToArrayI().AddedInteger( nums1, nums2 );
}
