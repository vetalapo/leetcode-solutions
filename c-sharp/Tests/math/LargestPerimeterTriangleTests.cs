using NUnit.Framework;

using Problems;

namespace Mathematics;

public class LargestPerimeterTriangleTests
{
    [TestCase( new int[] { 2, 1, 2 }, ExpectedResult = 5 )]
    [TestCase( new int[] { 1, 2, 1, 10 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 3, 6, 2, 3 }, ExpectedResult = 8 )]
    public int LargestPerimeterTest( int[] nums ) =>
        new LargestPerimeterTriangle().LargestPerimeter( nums );
}
