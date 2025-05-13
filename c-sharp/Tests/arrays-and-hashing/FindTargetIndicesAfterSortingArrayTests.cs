using System.Collections.Generic;

using NUnit.Framework;

using Problems;

public class FindTargetIndicesAfterSortingArrayTests
{
    [TestCase( new int[] { 1, 2, 5, 2, 3 }, 2, ExpectedResult = new int[] { 1, 2 } )]
    [TestCase( new int[] { 1, 2, 5, 2, 3 }, 3, ExpectedResult = new int[] { 3 } )]
    [TestCase( new int[] { 1, 2, 5, 2, 3 }, 5, ExpectedResult = new int[] { 4 } )]
    public IList<int> TargetIndicesTest( int[] nums, int target ) =>
        new FindTargetIndicesAfterSortingArray().TargetIndices( nums, target );
}
