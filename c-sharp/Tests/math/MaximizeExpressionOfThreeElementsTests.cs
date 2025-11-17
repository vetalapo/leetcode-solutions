using NUnit.Framework;

using Problems;

namespace Mathematics;

public class MaximizeExpressionOfThreeElementsTests
{
    [TestCase( new int[] { 1, 4, 2, 5 }, ExpectedResult = 8 )]
    [TestCase( new int[] { -2, 0, 5, -2, 4 }, ExpectedResult = 11 )]
    [TestCase( new int[] { -4, -8, -10 }, ExpectedResult = -2 )]
    public int MaximizeExpressionOfThreeTest( int[] nums ) =>
        new MaximizeExpressionOfThreeElements().MaximizeExpressionOfThree( nums );
}
