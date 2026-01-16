using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class FindCommonElementsBetweenTwoArraysTests
{
    [TestCase( new int[] { 2, 3, 2 }, new int[] { 1, 2 }, ExpectedResult = new int[] { 2, 1 } )]
    [TestCase( new int[] { 4, 3, 2, 3, 1 }, new int[] { 2, 2, 5, 2, 3, 6 }, ExpectedResult = new int[] { 3, 4 } )]
    [TestCase( new int[] { 3, 4, 2, 3 }, new int[] { 1, 5 }, ExpectedResult = new int[] { 0, 0 } )]
    public int[] FindIntersectionValuesTest( int[] nums1, int[] nums2 ) =>
        new FindCommonElementsBetweenTwoArrays().FindIntersectionValues( nums1, nums2 );
}
