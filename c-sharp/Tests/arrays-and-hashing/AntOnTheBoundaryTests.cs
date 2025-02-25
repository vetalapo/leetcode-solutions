using NUnit.Framework;

using Problems;

public class AntOnTheBoundaryTests
{
    [TestCase( new int[] { 2, 3, -5 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 3, 2, -3, -4 }, ExpectedResult = 0 )]
    public int ReturnToBoundaryCountTest( int[] nums ) =>
        new AntOnTheBoundary().ReturnToBoundaryCount( nums );
}
