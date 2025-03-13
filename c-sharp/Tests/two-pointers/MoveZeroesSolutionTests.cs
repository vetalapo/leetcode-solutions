using NUnit.Framework;

using Problems;

public class MoveZeroesSolutionTests
{
    [TestCase( new int[] { 0, 1, 0, 3, 12 }, ExpectedResult = new int[] { 1, 3, 12, 0, 0 } )]
    [TestCase( new int[] { 0 }, ExpectedResult = new int[] { 0 } )]
    [TestCase( new int[] { 1 }, ExpectedResult = new int[] { 1 } )]
    [TestCase( new int[] { 1, 0 }, ExpectedResult = new int[] { 1, 0 } )]
    [TestCase( new int[] { 2, 1 }, ExpectedResult = new int[] { 2, 1 } )]
    public int[] MoveZeroesTest( int[] nums )
    {
        new MoveZeroesSolution().MoveZeroes( nums );

        return nums;
    }
}
