using NUnit.Framework;

using Problems;

public class MaxConsecutiveOnesTests
{
    [TestCase( new int[] { 1, 1, 0, 1, 1, 1 }, ExpectedResult = 3 )]
    [TestCase( new int[] { 1, 0, 1, 1, 0, 1 }, ExpectedResult = 2 )]
    public int FindMaxConsecutiveOnesTest( int[] nums ) =>
        new MaxConsecutiveOnes().FindMaxConsecutiveOnes( nums );
}
