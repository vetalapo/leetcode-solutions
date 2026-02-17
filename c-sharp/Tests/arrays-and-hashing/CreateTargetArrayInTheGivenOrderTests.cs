using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CreateTargetArrayInTheGivenOrderTests
{
    [TestCase( new int[] { 0, 1, 2, 3, 4 }, new int[] { 0, 1, 2, 2, 1 }, ExpectedResult = new int[] { 0, 4, 1, 3, 2 } )]
    [TestCase( new int[] { 1, 2, 3, 4, 0 }, new int[] { 0, 1, 2, 3, 0 }, ExpectedResult = new int[] { 0, 1, 2, 3, 4 } )]
    [TestCase( new int[] { 1 }, new int[] { 0 }, ExpectedResult = new int[] { 1 } )]
    public int[] CreateTargetArrayTest( int[] nums, int[] index ) =>
        new CreateTargetArrayInTheGivenOrder().CreateTargetArray( nums, index );
}
