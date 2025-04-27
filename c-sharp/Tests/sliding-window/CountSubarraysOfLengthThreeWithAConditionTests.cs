using NUnit.Framework;

using Problems;

public class CountSubarraysOfLengthThreeWithAConditionTests
{
    [TestCase( new int[] { 1, 2, 1, 4, 1 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 1, 1, 1 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 0, -4, -4 }, ExpectedResult = 0 )]
    [TestCase( new int[] { -1, -4, -1, 4 }, ExpectedResult = 1 )]
    public int CountSubarraysTest( int[] nums ) =>
        new CountSubarraysOfLengthThreeWithACondition().CountSubarrays( nums );
}
