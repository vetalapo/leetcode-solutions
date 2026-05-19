using System.Collections;

using NUnit.Framework;

using Problems;

namespace TwoPointers;

public class MinimumCommonValueTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int GetCommonTest( int[] nums1, int[] nums2 ) =>
        new MinimumCommonValue().GetCommon( nums1, nums2 );
    
    [TestCaseSource( nameof( TestCases ) )]
    public int GetCommonBinarySearchTest( int[] nums1, int[] nums2 ) =>
        new MinimumCommonValue().GetCommonBinarySearch( nums1, nums2 );

    [TestCaseSource( nameof( TestCases ) )]
    public int GetCommonAltTest( int[] nums1, int[] nums2 ) =>
        new MinimumCommonValue().GetCommonAlt( nums1, nums2 );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new int[] { 1, 2, 3 }, new int[] { 2, 4 } ).Returns( 2 );

            yield return new TestCaseData( new int[] { 1, 2, 3, 6 }, new int[] { 2, 3, 4, 5 } ).Returns( 2 );

            yield return new TestCaseData( new int[] { 34, 225, 328, 530, 823, 834, 902, 989 },
                new int[]
                {
                    24, 30, 115, 121, 160, 173, 239, 265, 335, 362, 449, 557, 597, 624, 697, 766, 775, 881, 898, 919
                }
            ).Returns( -1 );

            yield return new TestCaseData( new int[] { 2 }, new int[] { 1, 2 } ).Returns( 2 );
        }
    }
}