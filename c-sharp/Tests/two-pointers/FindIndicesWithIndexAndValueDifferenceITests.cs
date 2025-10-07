using NUnit.Framework;

using Problems;

namespace TwoPointers;

public class FindIndicesWithIndexAndValueDifferenceITests
{
    [TestCase( new int[] { 5, 1, 4, 1 }, 2, 4, ExpectedResult = new int[] { 0, 3 } )]
    [TestCase( new int[] { 2, 1 }, 0, 0, ExpectedResult = new int[] { 0, 0 } )]
    [TestCase( new int[] { 1, 2, 3 }, 2, 4, ExpectedResult = new int[] { -1, -1 } )]
    public int[] FindIndicesTest( int[] nums, int indexDifference, int valueDifference ) =>
        new FindIndicesWithIndexAndValueDifferenceI().FindIndices( nums, indexDifference, valueDifference );
}
