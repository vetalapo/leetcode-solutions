using NUnit.Framework;

using Problems;

public class FormSmallestNumberFromTwoDigitArraysTests
{
    [TestCase( new int[] { 4, 1, 3 }, new int[] { 5, 7 }, ExpectedResult = 15 )]
    [TestCase( new int[] { 3, 5, 2, 6 }, new int[] { 3, 1, 7 }, ExpectedResult = 3 )]
    public int MinNumberTest( int[] nums1, int[] nums2 ) =>
        new FormSmallestNumberFromTwoDigitArrays().MinNumber( nums1, nums2 );
}
