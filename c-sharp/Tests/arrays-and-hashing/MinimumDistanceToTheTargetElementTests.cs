using NUnit.Framework;

using Problems;

public class MinimumDistanceToTheTargetElementTests
{
    [TestCase( new int[] { 1, 2, 3, 4, 5 }, 5, 3, ExpectedResult = 1 )]
    [TestCase( new int[] { 1 }, 1, 0, ExpectedResult = 0 )]
    [TestCase( new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 1, 0, ExpectedResult = 0 )]
    public int GetMinDistanceTest( int[] nums, int target, int start ) =>
        new MinimumDistanceToTheTargetElement().GetMinDistance( nums, target, start );
}
