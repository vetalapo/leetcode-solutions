using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class SetMismatchTests
{
    [TestCase( new int[] { 1, 2, 2, 4 }, ExpectedResult = new int[] { 2, 3 } )]
    [TestCase( new int[] { 1, 1 }, ExpectedResult = new int[] { 1, 2 } )]
    [TestCase( new int[] { 3, 2, 2 }, ExpectedResult = new int[] { 2, 1 } )]
    [TestCase( new int[] { 2, 3, 2 }, ExpectedResult = new int[] { 2, 1 } )]
    [TestCase( new int[] { 1, 3, 3 }, ExpectedResult = new int[] { 3, 2 } )]
    [TestCase( new int[] { 1, 2, 4, 4 }, ExpectedResult = new int[] { 4, 3 } )]
    public int[] FindErrorNumsTest( int[] nums ) =>
        new SetMismatch().FindErrorNums( nums );
}
